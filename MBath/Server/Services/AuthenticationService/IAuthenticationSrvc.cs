
namespace MBath.Server.Services.AuthenticationServices
{
    public interface IAuthenticationSrvc
    {
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string email, string password);

        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);

        int GetUserId();

        string GetUserEmail();

        Task<User> GetUser(string email);
    }
}
