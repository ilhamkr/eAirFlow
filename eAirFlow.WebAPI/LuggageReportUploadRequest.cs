
namespace eAirFlow.WebAPI
{
    public class LuggageReportUploadRequest
    {
         public int UserId { get; set; }
         public int FlightId { get; set; }
         public string Description { get; set; }
         public IFormFile Image { get; set; }
         public int? AirportId { get; set; }

    }
}
