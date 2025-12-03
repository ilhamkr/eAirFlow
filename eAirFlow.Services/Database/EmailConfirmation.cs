using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Database
{
    public class EmailConfirmation
    {
        public int EmailConfirmationId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool IsConfirmed { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
