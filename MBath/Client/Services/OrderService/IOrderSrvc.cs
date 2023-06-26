namespace MBath.Client.Services.OrderService
{
    public interface IOrderSrvc
    {

        Task<string> CreateOrder();

        Task<List<OrderOverviewResponse>> GetOrders();

        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
