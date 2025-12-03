using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public abstract class BaseCRUDService<TModel, TSearch, TDbEntity, TInsert, TUpdate> : BaseService<TModel, TSearch, TDbEntity> where TModel : class where TSearch : BaseSearchObject where TDbEntity : class
    {
        public BaseCRUDService(_210019Context context, IMapper mapper) : base(context, mapper)
        {

        }

        public virtual TModel Insert(TInsert request)
        {
            //if (request.Passsword != request.PasswordConfirmation)
            //  throw new Exception("Password and confirmation must match!");

            TDbEntity entity = _mapper.Map<TDbEntity>(request);

            BeforeInsert(request, entity);

            _context.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual void BeforeInsert(TInsert request, TDbEntity entity)
        { }

        public virtual TModel Update(int id, TUpdate request)
        {
            var set = _context.Set<TDbEntity>();

            var entity = set.Find(id);

            _mapper.Map(request, entity);

            BeforeUpdate(request, entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual void BeforeUpdate(TUpdate request, TDbEntity entity) { }

        public virtual IQueryable<TDbEntity> AddInclude(IQueryable<TDbEntity> query)
        {
            return query;
        }

        public virtual async Task<TModel> InsertAsync(TInsert request)
        {
            TDbEntity entity = _mapper.Map<TDbEntity>(request);

            BeforeInsert(request, entity);

            _context.Add(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<TModel>(entity);
        }



    }
}
