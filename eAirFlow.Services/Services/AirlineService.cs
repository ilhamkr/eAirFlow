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
            var flights = _context.Flights
                .Where(f => f.AirlineId == id)
                .ToList();

            _context.Flights.RemoveRange(flights);
            _context.SaveChanges();

            var airplanes = _context.Airplanes
                .Where(a => a.AirlineId == id)
                .ToList();

            var airplaneIds = airplanes.Select(a => a.AirplaneId).ToList();

            var seats = _context.Seats
                .Where(s => s.AirplaneId.HasValue && airplaneIds.Contains(s.AirplaneId.Value))
                .ToList();

            _context.Seats.RemoveRange(seats);
            _context.SaveChanges();

            _context.Airplanes.RemoveRange(airplanes);
            _context.SaveChanges();

            var airline = _context.Airlines.Find(id);
            if (airline == null)
                throw new Exception("Airline not found");

            _context.Airlines.Remove(airline);
            _context.SaveChanges();
        }



    }
}
