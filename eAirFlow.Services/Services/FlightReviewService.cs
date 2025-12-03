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
    public class FlightReviewService : BaseCRUDService<FlightReview, FlightReviewSearchObject, Database.FlightReview, FlightReviewInsertRequest, FlightReviewUpdateRequest>, IFlightReviewService
    {
        public FlightReviewService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.FlightReview> AddFilter(FlightReviewSearchObject search, IQueryable<Database.FlightReview> query)
        {
            if (search == null)
                return query;

            if (search.UserId.HasValue)
            {
                query = query.Where(x => x.UserId == search.UserId.Value);
            }

            if (search.FlightId.HasValue)
            {
                query = query.Where(x => x.FlightId == search.FlightId.Value);
            }

            if (search.MinRating.HasValue)
            {
                query = query.Where(x => x.Rating >= search.MinRating.Value);
            }

            if (search.MaxRating.HasValue)
            {
                query = query.Where(x => x.Rating <= search.MaxRating.Value);
            }

            query = query.Include(x => x.Flight);


            return base.AddFilter(search, query);
        }

        public override Model.Models.FlightReview Insert(FlightReviewInsertRequest request)
        {
            request ??= new FlightReviewInsertRequest();

            var entity = _mapper.Map<Database.FlightReview>(request);
            entity.SubmittedAt = DateTime.Now;

            _context.Set<Database.FlightReview>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Models.FlightReview>(entity);
        }



    }
}
