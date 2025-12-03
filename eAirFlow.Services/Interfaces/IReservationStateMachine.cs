using eAirFlow.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Interfaces
{
    public interface IReservationStateMachine
    {
        Reservation Pay(int id);
    }
}
