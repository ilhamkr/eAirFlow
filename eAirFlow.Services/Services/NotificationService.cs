using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Interfaces;
using Mapster;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class NotificationService : BaseCRUDService<Notification, NotificationSearchObject, Database.Notification, NotificationInsertRequest, NotificationUpdateRequest>, INotificationService
    {
        public NotificationService(Database._210019Context context, IMapper mapper) : base(context, mapper)
        {
            TypeAdapterConfig<NotificationUpdateRequest, Database.Notification>
                .NewConfig()
                .IgnoreNullValues(true);
        }

        public override IQueryable<Database.Notification> AddFilter(NotificationSearchObject search, IQueryable<Database.Notification> query)
        {
            if (search == null)
                return query;

            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId.Value);

            if (search.UnreadOnly == true)
                query = query.Where(x => x.IsSeen == false);

            return query;
        }

    }
}
