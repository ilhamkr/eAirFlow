using System;
using System.Collections.Generic;
using System.Text;

namespace eAirFlow.Model.Models
{
    public class EmailConfirmation
    {
        public int EmailConfirmationId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
