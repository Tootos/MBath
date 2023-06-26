
using Stripe.Checkout;

namespace MBath.Server.Services.PaymentService
{
    public interface IPaymentSrvc
    {
        Task<Session> CreateCheckoutSession();

        Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request);
    }
}
