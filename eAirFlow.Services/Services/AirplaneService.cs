using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbSeat = eAirFlow.Services.Database.Seat;

namespace eAirFlow.Services.Services
{
    public class AirplaneService : BaseCRUDService<Airplane, AirplaneSearchObject, Database.Airplane, AirplaneInsertRequest, AirplaneUpdateRequest>, IAirplaneService
    {
        public AirplaneService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Airplane> AddFilter(AirplaneSearchObject search, IQueryable<Database.Airplane> query)
        {
            if (!string.IsNullOrWhiteSpace(search?.ModelGTE))
            {
                query = query.Where(x => x.Model.StartsWith(search.ModelGTE));
            }


            return base.AddFilter(search, query);
        }

        public override Airplane Insert(AirplaneInsertRequest request)
        {
            var entity = _mapper.Map<Database.Airplane>(request);
            _context.Airplanes.Add(entity);
            _context.SaveChanges();

            GenerateSeats(entity.AirplaneId, entity.TotalSeats ?? 60);

            return _mapper.Map<Model.Models.Airplane>(entity);
        }

        private void GenerateSeats(int airplaneId, int totalSeats)
        {
            int rows = totalSeats / 6;
            var letters = new[] { "A", "B", "C", "D", "E", "F" };

            List<DbSeat> list = new();

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    list.Add(new DbSeat
                    {
                        AirplaneId = airplaneId,
                        SeatNumber = $"{r}{letters[c]}",
                        SeatClassId = 1
                    });
                }
            }

            _context.Seats.AddRange(list);
            _context.SaveChanges();
        }



    }
}
