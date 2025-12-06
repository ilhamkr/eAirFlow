using eAirFlow.Model.Requests;
using eAirFlow.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.IO;
using System.Drawing.Imaging;
using SkiaSharp;


namespace eAirFlow.Services.ReservationStateMachine
{
    public class BaseReservationState
    {
        public _210019Context Context { get; set; }
        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }

        public BaseReservationState(_210019Context context, IMapper mapper, IServiceProvider serviceProvider)
        {
            Context = context;
            Mapper = mapper;
            ServiceProvider = serviceProvider;
        }

        public virtual BaseReservationState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return new InitialReservationState(Context, Mapper, ServiceProvider);
                case "confirmed":
                    return new ConfirmedReservationState(Context, Mapper, ServiceProvider);
                case "cancelled":
                    return new CancelledReservationState(Context, Mapper, ServiceProvider);
                case "completed":
                    return new CompletedReservationState(Context, Mapper, ServiceProvider);
                case "paid":
                    return new PaidReservationState(Context, Mapper, ServiceProvider);
                case "checkedin":
                    return new CheckedInReservationState(Context, Mapper, ServiceProvider);
                default:
                    throw new Exception("Invalid state");
            }
        }

        public virtual Model.Models.Reservation Insert(ReservationInsertRequest request)
        {
            throw new Exception("Insert not allowed in this state.");
        }

        public virtual Model.Models.Reservation Update(int id, ReservationUpdateRequest request)
        {
            throw new Exception("Update not allowed in this state.");
        }

        public virtual Model.Models.Reservation Confirm(int id)
        {
            throw new Exception("Confirm not allowed in this state.");
        }

        public virtual Model.Models.Reservation Cancel(int id)
        {
            throw new Exception("Cancel not allowed in this state.");
        }

        public virtual Model.Models.Reservation Complete(int id)
        {
            throw new Exception("Complete not allowed in this state.");
        }

        public virtual Model.Models.Reservation Pay(int id)
        {
            throw new Exception("Pay not allowed in this state.");
        }

        public string GenerateQrCode(string text)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

            var pngQrCode = new PngByteQRCode(qrData);
            byte[] qrBytes = pngQrCode.GetGraphic(20);

            return Convert.ToBase64String(qrBytes);
        }




    }
}
