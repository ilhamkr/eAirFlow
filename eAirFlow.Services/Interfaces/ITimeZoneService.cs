using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eAirFlow.Model.Models;

namespace eAirFlow.Services.Interfaces
{
    public interface ITimeZoneService
    {
        List<Model.Models.TimeZone> GetAll();
    }
}
