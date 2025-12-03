using eAirFlow.Model;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
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
    public abstract class BaseService<TModel, TSearch, TDbEntity> : IService<TModel, TSearch> where TSearch : BaseSearchObject where TDbEntity : class where TModel : class
    {
        protected readonly _210019Context _context;
        protected readonly IMapper _mapper;


        public BaseService(_210019Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public PagedResult<TModel> GetPaged(TSearch search)
        {
            List<TModel> result = new List<TModel>();

            var query = _context.Set<TDbEntity>().AsQueryable();

            query = AddInclude(query);

            query = AddFilter(search, query);

            int count = query.Count();

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                query = query.Skip(search.Page.Value * search.PageSize.Value).Take(search.PageSize.Value);
            }


            var list = query.ToList();

            var mappedList = _mapper.Map<List<TModel>>(list);


            return new PagedResult<TModel>
            {
                Count = count,
                ResultList = mappedList
            };
        }

        public virtual IQueryable<TDbEntity> AddFilter(TSearch search, IQueryable<TDbEntity> query)
        {
            return query;
        }

        public virtual IQueryable<TDbEntity> AddInclude(IQueryable<TDbEntity> query)
        {
            return query;
        }

        public virtual PagedResult<TModel> Get(TSearch search)
        {
            return GetPaged(search);
        }



        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDbEntity>().Find(id);

            if (entity != null)
            {
                return _mapper.Map<TModel>(entity);
            }
            else
            {
                return null;
            }

        }


    }
}
