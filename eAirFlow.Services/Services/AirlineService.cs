using eAirFlow.Model;
using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class AirlineService : BaseCRUDService<Airline, AirlineSearchObject, Database.Airline, AirlineInsertRequest, AirlineUpdateRequest>, IAirlineService
    {
        public AirlineService(Database._210019Context context, IMapper mapper) : base(context, mapper) { }

        public override IQueryable<Database.Airline> AddFilter(AirlineSearchObject search, IQueryable<Database.Airline> query)
        {
            query = query.Include(a => a.Airport);

            if (search.AirportId.HasValue)
                query = query.Where(a => a.AirportId == search.AirportId);

            if (!string.IsNullOrWhiteSpace(search?.NameGTE))
                query = query.Where(a => a.Name.StartsWith(search.NameGTE));

            if (!string.IsNullOrWhiteSpace(search?.CountryGTE))
                query = query.Where(a => a.Country.StartsWith(search.CountryGTE));

            return query;
        }

        public override IQueryable<Database.Airline> AddInclude(IQueryable<Database.Airline> query)
        {
            query = query.Include(x => x.Airport);
            return query;
        }

        public override Airline GetById(int id)
        {
            var entity = _context.Airlines
                .Include(x => x.Airport)
                .FirstOrDefault(x => x.AirlineId == id);

            return _mapper.Map<eAirFlow.Model.Models.Airline>(entity);
        }

        public void Delete(int id)
        {
            var airline = _context.Airlines.FirstOrDefault(a => a.AirlineId == id);
            if (airline == null)
                throw new Exception("Airline not found");

            var flightIds = _context.Flights
                .Where(f => f.AirlineId == id)
                .Select(f => f.FlightId)
                .ToList();

            var reservations = _context.Reservations
                .Where(r => r.FlightId != null && flightIds.Contains(r.FlightId.Value))
                .ToList();
            var reservationIds = reservations.Select(r => r.ReservationId).ToList();

            var checkins = _context.CheckIns
               .Where(c => c.ReservationId != null && reservationIds.Contains(c.ReservationId.Value))
               .ToList();
            _context.CheckIns.RemoveRange(checkins);

            _context.Reservations.RemoveRange(reservations);

            var reviews = _context.FlightReviews
                .Where(fr => fr.FlightId != null && flightIds.Contains(fr.FlightId.Value))
                .ToList();
            _context.FlightReviews.RemoveRange(reviews);

            var flights = _context.Flights
                .Where(f => f.AirlineId == id)
                .ToList();
            _context.Flights.RemoveRange(flights);

            var airplanes = _context.Airplanes
                .Where(x => x.AirlineId == id)
                .ToList();
            foreach (var airplane in airplanes)
            {
                airplane.AirlineId = null;
            }

            _context.Airlines.Remove(airline);
            _context.SaveChanges();
        }


    }
}
