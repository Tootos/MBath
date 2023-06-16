using MBath.Shared.Models.UserModels;
using MBath.Shared.Models;

namespace MBath.Server.Services.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string email, string password);

        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);
    }
}
