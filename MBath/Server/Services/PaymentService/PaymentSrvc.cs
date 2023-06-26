
using Stripe;
using Stripe.Checkout;

namespace MBath.Server.Services.PaymentService
{
    public class PaymentSrvc : IPaymentSrvc
    {
        private readonly ICartSrvc _cartService;
        private readonly IAuthenticationSrvc _authenticationService;
        private readonly IOrderSrvc _orderService;

        const string secret = "whsec_606f70acffba9b8c07119c979d1b1634ab392a376d3dffbd360bb18021a493d3";

        public PaymentSrvc(ICartSrvc cartService, IAuthenticationSrvc authenticationService, IOrderSrvc orderService)
        {
            StripeConfiguration.ApiKey = "sk_test_51NMQWxBUm3JlFkTp0oLWRdrw9lCKsbPzV8J6owvpaani2YPZbnxBRcVMZzUvtzet6g6EF18LTrSxb9C8cNiLUE1x00K831ot60";

            _cartService = cartService;
            _authenticationService = authenticationService;
            _orderService = orderService;
        }
        public async Task<Session> CreateCheckoutSession()
        {
            var products = (await _cartService.GetDbCartProducts()).Data;
            var lineItem = new List<SessionLineItemOptions>();
            products.ForEach(product => lineItem.Add(new SessionLineItemOptions
            {
                PriceData= new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal= product.Price * 100,
                    Currency= "usd",
                    ProductData= new SessionLineItemPriceDataProductDataOptions
                    {
                        Name= product.ProductName
                    }
                },
                Quantity= product.Quantity
            }));

            var options = new SessionCreateOptions
            {
                CustomerEmail = _authenticationService.GetUserEmail(),
                ShippingAddressCollection= 
                new SessionShippingAddressCollectionOptions
                {
                    AllowedCountries= new List<string> {"US"}
                },
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = lineItem,
                Mode = "payment",
                SuccessUrl = "https://localhost:44374/order-success",
                CancelUrl = "https://localhost:44374/cart"
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return session;
        }

        public async Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request)
        {
            var json = await new StreamReader(request.Body).ReadToEndAsync();
            try
            {
                var stripeEvent = EventUtility.ConstructEvent(
                    json,
                    request.Headers["Stripe-Signature"],
                    secret
                );
                if(stripeEvent.Type == Events.CheckoutSessionCompleted)
                {
                    var session = stripeEvent.Data.Object as Session;
                    var user = await _authenticationService.GetUser(session.CustomerEmail);
                    await _orderService.CreateOrder(user.Id);
                }

                return new ServiceResponse<bool> { Data = true, Success = true };
            }
            catch
            {
                return new ServiceResponse<bool> { Data = false };

            }
        }
    }
}
