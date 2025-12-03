using eAirFlow.Model.Models;
using Mapster;

namespace eAirFlow.Services.Mapping
{
    public static class MappingConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<eAirFlow.Services.Database.Reservation, eAirFlow.Model.Models.Reservation>
                .NewConfig()
                .Map(dest => dest.Flight, src => src.Flight)
                .Map(dest => dest.Payment, src => src.Payment);

            TypeAdapterConfig<eAirFlow.Services.Database.Flight, eAirFlow.Model.Models.Flight>
                .NewConfig()
                .Map(dest => dest.FlightId, src => src.FlightId)
                .Map(dest => dest.DepartureLocation, src => src.DepartureLocation)
                .Map(dest => dest.ArrivalLocation, src => src.ArrivalLocation)
                .Map(dest => dest.DepartureTime, src => src.DepartureTime)
                .Map(dest => dest.ArrivalTime, src => src.ArrivalTime)
                .Map(dest => dest.Price, src => src.Price)
                .Map(dest => dest.StateMachine, src => src.StateMachine)
                .Map(dest => dest.Airline, src => src.Airline);

            


        }
    }
}
