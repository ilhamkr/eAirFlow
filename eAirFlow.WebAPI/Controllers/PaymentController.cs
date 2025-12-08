using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Orders;
using eAirFlow.WebAPI.Settings;
using Microsoft.Extensions.Options;
using System.Globalization;
using QRCoder;
using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;
using System.IO;



namespace eAirFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : BaseCRUDController<Model.Models.Payment, PaymentSearchObject, PaymentInsertRequest, PaymentUpdateRequest>
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly _210019Context _context;
        private readonly IReservationService _reservationService;
        private readonly PayPalSettings _paypal;


        public PaymentController(IPaymentService service, _210019Context context, IReservationService reservationService, IServiceProvider serviceProvider, IOptions<PayPalSettings> paypalOptions) : base(service)
        {
            _context = context;
            _reservationService = reservationService;
            _serviceProvider = serviceProvider;
            _paypal = paypalOptions.Value;
        }

        [AllowAnonymous]
        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest req)
        {
            var environment = new SandboxEnvironment(
                _paypal.ClientId,
                _paypal.Secret
            );

            var client = new PayPalHttpClient(environment);

            var orderRequest = new OrdersCreateRequest();
            orderRequest.Prefer("return=representation");

            orderRequest.RequestBody(
                new OrderRequest()
                {
                    CheckoutPaymentIntent = "CAPTURE",
                    PurchaseUnits = new List<PurchaseUnitRequest>
                    {
                new PurchaseUnitRequest
                {
                    AmountWithBreakdown = new AmountWithBreakdown
                    {
                        CurrencyCode = "USD",
                        Value = req.Amount.ToString("0.00", CultureInfo.InvariantCulture)

                    }
                }
                    },
                    ApplicationContext = new ApplicationContext
                    {
                        BrandName = "AirFlow",
                        LandingPage = "NO_PREFERENCE",
                        ReturnUrl = req.ReturnUrl,
                        CancelUrl = req.CancelUrl
                    }
                }
            );

            var response = await client.Execute(orderRequest);
            var result = response.Result<Order>();

            var approvalUrl = result.Links.First(x => x.Rel == "approve").Href;

            return Ok(new
            {
                orderId = result.Id,
                approvalUrl
            });
        }

        [AllowAnonymous]
        [HttpPost("capture-order")]
        public async Task<IActionResult> Capture([FromBody] CaptureOrderRequest req)
        {
            var environment = new SandboxEnvironment(_paypal.ClientId, _paypal.Secret);
            var client = new PayPalHttpClient(environment);

            var captureRequest = new OrdersCaptureRequest(req.OrderId);
            captureRequest.RequestBody(new OrderActionRequest());
            var response = await client.Execute(captureRequest);
            var result = response.Result<Order>();

            if (result.Status != "COMPLETED")
                return BadRequest("Payment not completed");

            var payment = new Services.Database.Payment
            {
                UserId = req.UserId,
                Amount = req.Amount,
                PaymentMethod = "PayPal",
                TransactionDate = DateTime.Now,
                TransactionReference = req.OrderId
            };

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();

            var reservation = new Services.Database.Reservation
            {
                UserId = req.UserId,
                FlightId = req.FlightId,
                SeatId = req.SeatId,
                MealTypeId = req.MealTypeId,
                AirportId = req.AirportId,
                AirplaneId = req.AirplaneId,
                PaymentId = payment.PaymentId,
                StateMachine = "paid",
                ReservationDate = DateTime.Now
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            var qrCodeBase64 = GenerateQrBase64(
                $"RES:{reservation.ReservationId}|PAY:{payment.PaymentId}|AMOUNT:{payment.Amount}"
            );

            reservation.QrCodeBase64 = qrCodeBase64;
            await _context.SaveChangesAsync();

            return Ok(new
            {
                success = true,
                qrCode = qrCodeBase64,
                reservationId = reservation.ReservationId
            });
        }



        private string GenerateQrBase64(string text)
        {
            var qrGenerator = new QRCodeGenerator();

            var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.H);

            using (var ms = new MemoryStream())
            {
                using (var skBitmap = new SkiaSharp.SKBitmap(qrCodeData.ModuleMatrix[0].Length * 10, qrCodeData.ModuleMatrix.Count * 10))
                {
                    using (var canvas = new SkiaSharp.SKCanvas(skBitmap))
                    {
                        canvas.Clear(SkiaSharp.SKColors.White);
                        var paint = new SkiaSharp.SKPaint
                        {
                            Color = SkiaSharp.SKColors.Black,
                            Style = SkiaSharp.SKPaintStyle.Fill
                        };

                        for (int y = 0; y < qrCodeData.ModuleMatrix.Count; y++)
                        {
                            for (int x = 0; x < qrCodeData.ModuleMatrix[y].Length; x++)
                            {
                                if (qrCodeData.ModuleMatrix[y][x]) 
                                {
                                    canvas.DrawRect(x * 10, y * 10, 10, 10, paint);
                                }
                            }
                        }
                    }

                    using (var pngImage = skBitmap.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100))
                    {
                        pngImage.SaveTo(ms);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

















    }
}
