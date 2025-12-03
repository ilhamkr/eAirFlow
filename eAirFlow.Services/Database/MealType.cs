using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Database
{
    public class MealType
    {
        public int MealTypeId { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}
