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

namespace eAirFlow.Services.Services
{
    public class PaymentService : BaseCRUDService<Payment, PaymentSearchObject, Database.Payment, PaymentInsertRequest, PaymentUpdateRequest>, IPaymentService
    {
        public PaymentService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Database.Payment> AddFilter(PaymentSearchObject search, IQueryable<Database.Payment> query)
        {
            if (search == null)
                return query;

            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId.Value);

            if (!string.IsNullOrWhiteSpace(search.PaymentMethod))
                query = query.Where(x => x.PaymentMethod == search.PaymentMethod);

            return base.AddFilter(search, query);
        }
    }
}
