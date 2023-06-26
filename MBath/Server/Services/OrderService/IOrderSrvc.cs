
namespace MBath.Server.Services.OrderService
{
    public interface IOrderSrvc
    {
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrderItemsAsync();
        Task<ServiceResponse<bool>> CreateOrder(int userId);

        Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);
    }
}
