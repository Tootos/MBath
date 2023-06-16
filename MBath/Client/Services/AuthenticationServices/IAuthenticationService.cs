namespace MBath.Client.Services.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);

        Task<ServiceResponse<string>> Login(UserLogin request);

        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);
    }
}
