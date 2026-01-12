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
    public class AirportService : BaseCRUDService<Airport, AirportSearchObject, Database.Airport, AirportInsertRequest, AirportUpdateRequest>, IAirportService
    {
        public AirportService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Airport> AddInclude(IQueryable<Database.Airport> query)
        {
            return query.Include(a => a.TimeZone);
        }
        public override IQueryable<Database.Airport> AddFilter(AirportSearchObject search, IQueryable<Database.Airport> query)
        {
            if (search == null)
                return query;

            if (!string.IsNullOrWhiteSpace(search.Name))
                query = query.Where(x => x.Name.Contains(search.Name));

            if (!string.IsNullOrWhiteSpace(search.City))
                query = query.Where(x => x.City.Contains(search.City));

            if (!string.IsNullOrWhiteSpace(search.Country))
                query = query.Where(x => x.Country.Contains(search.Country));

            return base.AddFilter(search, query);
        }

        public void Delete(int id)
        {
            var entity = _context.Airports.FirstOrDefault(x => x.AirportId == id);

            if (entity == null)
                throw new Exception("Airport not found.");

            _context.Airports.Remove(entity);
            _context.SaveChanges();
        }
    }
}
