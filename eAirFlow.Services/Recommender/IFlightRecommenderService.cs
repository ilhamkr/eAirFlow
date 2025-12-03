using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Recommender
{
    public interface IFlightRecommenderService
    {
        List<eAirFlow.Model.Models.Flight> GetRecommendedFlights(int userId, int brojPreporuka = 3);
    }
}
