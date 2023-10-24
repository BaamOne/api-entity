using Acessi_api.Models.User;

namespace Acessi_api.Interfaces.User
{

    public interface IUserService
    {
        Task<UserModel> CreateUserAsync(UserModel user);
        Task<UserModel> GetUserByIdAsync(int userId);
    }
}
