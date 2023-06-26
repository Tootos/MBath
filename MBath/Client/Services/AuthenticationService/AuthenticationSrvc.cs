using System.Net.Http.Json;

namespace MBath.Client.Services.AuthenticationService
{
    public class AuthenticationSrvc : IAuthenticationSrvc
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authentication;

        public AuthenticationSrvc(HttpClient http, AuthenticationStateProvider authentication)
        {
            _http = http;
            _authentication = authentication;
        }
        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/authentication/register", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _http.PostAsJsonAsync("api/authentication/login", request);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/authentication/change-password", request.Password);

            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<bool> IsAuthenticated()
        {
            return (await _authentication.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }
    }
}
