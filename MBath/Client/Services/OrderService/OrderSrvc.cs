using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace MBath.Client.Services.OrderService
{
    public class OrderSrvc : IOrderSrvc
    {
        private readonly HttpClient _http;
        private readonly IAuthenticationSrvc _authentication;
        private readonly NavigationManager _navigationManager;

        public OrderSrvc(HttpClient http,IAuthenticationSrvc authentication, NavigationManager navigationManager)
        {
            _http = http;
            _authentication = authentication;
            _navigationManager = navigationManager;
        }

        public async Task<string> CreateOrder()
        {
            if(await _authentication.IsAuthenticated())
            {
                var result = await _http.PostAsync("api/payment/checkout",null);
                var url= await result.Content.ReadAsStringAsync();
                return url;
            }
            else
            {
                return "login";
            }
        }

        public async Task<OrderDetailsResponse> GetOrderDetails(int orderId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<OrderDetailsResponse>>($"api/order/{orderId}");
            return result.Data;
        }

        public async Task<List<OrderOverviewResponse>> GetOrders()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<OrderOverviewResponse>>>("api/order");
            return result.Data;
                     
        }

        
    }
}
