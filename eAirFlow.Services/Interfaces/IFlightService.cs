using eAirFlow.Model;
using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using Mapster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Interfaces
{
    public interface IFlightService : ICRUDService<Flight, FlightSearchObject, FlightInsertRequest, FlightUpdateRequest>
    {
        public Flight Schedule(int id);
        public Flight Delay(int id);
        public Flight Cancel(int id);
        public Flight Complete(int id);
        public Flight Boarding(int id);
        public Flight DelayWithTime(int id, int minutes);
        public Flight AdminInsert(FlightInsertRequest request);
        public Task<Dictionary<string, object>> GetStats(List<int> airportIds);
        Task<List<WeeklyTrendDto>> GetWeeklyTrend(List<int> airportIds);
        public Dictionary<string, List<string>> GetFutureLocations(int airlineId);

        void Delete(int id);

    }
}
