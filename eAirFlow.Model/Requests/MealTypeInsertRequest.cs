using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Requests
{
    public class MealTypeInsertRequest
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}
