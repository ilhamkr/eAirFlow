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
            var environment = new SandboxEnvironment(
                _paypal.ClientId,
                _paypal.Secret
            );
            var client = new PayPalHttpClient(environment);

            var captureRequest = new OrdersCaptureRequest(req.OrderId);
            captureRequest.RequestBody(new OrderActionRequest());

            var response = await client.Execute(captureRequest);
            var result = response.Result<Order>();

            if (result.Status != "COMPLETED")
                return BadRequest("Payment not completed");

            var payment = new eAirFlow.Services.Database.Payment
            {
                UserId = req.UserId,
                Amount = req.Amount,
                PaymentMethod = "PayPal",
                TransactionDate = DateTime.Now,
                TransactionReference = req.OrderId
            };

            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();

            var updated = _reservationService.MarkAsPaid(
                req.ReservationId, payment.PaymentId
            );

            return Ok(new
            {
                success = true,
                qrCode = updated.QrCodeBase64
            });
        }





    }
}
