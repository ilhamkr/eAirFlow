using eAirFlow.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight = eAirFlow.Model.Models.Flight;


namespace eAirFlow.Services.Recommender
{
    public class FlightRecommenderService : IFlightRecommenderService
    {
        private readonly _210019Context _context;
        private readonly IMapper _mapper;

        public FlightRecommenderService(_210019Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Flight> GetRecommendedFlights(int userId, int brojPreporuka = 3)
        {
            var userReservations = _context.Reservations
                .Include(r => r.Flight)
                    .ThenInclude(f => f.Airline)
                .Where(r => r.UserId == userId)
                .Where(r => r.Flight != null)
                .ToList();

            if (!userReservations.Any())
            {
                var differentDestinations = _context.Flights
                    .Include(f => f.Airline)
                    .GroupBy(f => f.ArrivalLocation)
                    .Select(g => g.OrderBy(f => f.Price).First())
                    .Take(brojPreporuka)
                    .ToList();

                return _mapper.Map<List<Flight>>(differentDestinations);
            }

            var userProfileText = string.Join(" ",
                userReservations.Select(r =>
                {
                    var f = r.Flight!;
                    return $"{f.DepartureLocation} {f.ArrivalLocation} {f.Airline?.Name} {f.Airline?.Country}";
                }));

            var candidateFlightsQuery = _context.Flights
                .Include(f => f.Airline)
                .Where(f => f.DepartureTime >= DateTime.Now);

            var reservedFlightIds = userReservations
                .Select(r => r.FlightId)
                .Where(id => id.HasValue)
                .Select(id => id!.Value)
                .Distinct()
                .ToList();

            candidateFlightsQuery = candidateFlightsQuery
                .Where(f => !reservedFlightIds.Contains(f.FlightId));

            var candidateFlights = candidateFlightsQuery.ToList();

            if (!candidateFlights.Any())
            {
                var lastFlights = userReservations
                    .OrderByDescending(r => r.ReservationDate)
                    .Select(r => r.Flight!)
                    .GroupBy(f => f.ArrivalLocation)
                    .Select(g => g.First())
                    .Take(brojPreporuka)
                    .ToList();

                return _mapper.Map<List<Flight>>(lastFlights);
            }

            var flightTextData = candidateFlights.Select(f => new FlightTextData
            {
                Flight = f,
                Text = $"{f.DepartureLocation} {f.ArrivalLocation} {f.Airline?.Name} {f.Airline?.Country}"
            }).ToList();

            var mlContext = new MLContext();

            var dataForMl = flightTextData
                .Select(x => new FlightText { Text = x.Text })
                .ToList();

            dataForMl.Add(new FlightText { Text = userProfileText });

            var dataView = mlContext.Data.LoadFromEnumerable(dataForMl);

            var pipeline = mlContext.Transforms.Text
                .FeaturizeText("Features", nameof(FlightText.Text));

            var model = pipeline.Fit(dataView);
            var transformed = model.Transform(dataView);

            var featureVectors = transformed.GetColumn<float[]>("Features").ToArray();

            var userVector = featureVectors.Last();
            var flightVectors = featureVectors.Take(featureVectors.Length - 1).ToList();

            var scoredFlights = flightVectors
                .Select((vec, idx) => new
                {
                    Score = CosineSimilarity(userVector, vec),
                    Flight = flightTextData[idx].Flight
                })
                .OrderByDescending(x => x.Score)
                .GroupBy(x => x.Flight.ArrivalLocation)
                .Select(g => g.First())
                .Take(brojPreporuka)
                .Select(x => x.Flight)
                .ToList();

            return _mapper.Map<List<Flight>>(scoredFlights);
        }



        private class FlightText
        {
            public string Text { get; set; } = "";
        }

        private class FlightTextData
        {
            public Database.Flight Flight { get; set; } = null!;
            public string Text { get; set; } = "";
        }

        private float CosineSimilarity(float[] v1, float[] v2)
        {
            float dot = 0;
            float normA = 0;
            float normB = 0;

            for (int i = 0; i < v1.Length; i++)
            {
                dot += v1[i] * v2[i];
                normA += v1[i] * v1[i];
                normB += v2[i] * v2[i];
            }

            return dot / ((float)Math.Sqrt(normA) * (float)Math.Sqrt(normB) + 1e-5f);
        }
    }

}
