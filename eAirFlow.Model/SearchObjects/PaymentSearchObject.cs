using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.SearchObjects
{
    public class PaymentSearchObject : BaseSearchObject
    {
        public int? UserId { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
