using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.CheckInStateMachine
{
    public class PendingCheckInState : BaseCheckInState
    {
        public PendingCheckInState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider) : base(context, mapper, serviceProvider)
        {
        }

        public override eAirFlow.Model.Models.CheckIn Insert(CheckInInsertRequest request)
        {
            var entity = Mapper.Map<Database.CheckIn>(request);
            entity.StateMachine = "pending";
            entity.UserId = request.UserId;

            Context.CheckIns.Add(entity);
            Context.SaveChanges();

            return Mapper.Map<eAirFlow.Model.Models.CheckIn>(entity);
        }


        public override Model.Models.CheckIn Complete(int id)
        {
            var entity = Context.CheckIns.Find(id);
            if (entity == null) throw new Exception("CheckIn not found");

            entity.StateMachine = "completed";
            Context.SaveChanges();

            return Mapper.Map<Model.Models.CheckIn>(entity);
        }

        public override Model.Models.CheckIn Cancel(int id)
        {
            var entity = Context.CheckIns.Find(id);
            if (entity == null) throw new Exception("CheckIn not found");

            entity.StateMachine = "cancelled";
            Context.SaveChanges();

            return Mapper.Map<Model.Models.CheckIn>(entity);
        }
    }
}
