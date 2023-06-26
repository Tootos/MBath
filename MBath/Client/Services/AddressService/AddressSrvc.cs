using System.Net.Http.Json;

namespace MBath.Client.Services.AddressService
{
    public class AddressSrvc : IAddressSrvc
    {
        private readonly HttpClient _http;

        public AddressSrvc(HttpClient http)
        {
            _http = http;
        }
        public async Task<Address> GetAddressAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Address>>("api/address");
            return result.Data;
        }

        public async Task<Address> UpdateAddressAsync(Address address)
        {
            var result = await _http.PostAsJsonAsync("api/address",address);
            return result.Content.ReadFromJsonAsync<ServiceResponse<Address>>().Result.Data;
        }
    }
}
