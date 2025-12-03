using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Interfaces
{
    public interface ICheckInService : ICRUDService<CheckIn, CheckInSearchObject, CheckInInsertRequest, CheckInUpdateRequest>
    {
        public CheckIn Cancel (int id);
        public CheckIn Complete (int id);
    }
}
