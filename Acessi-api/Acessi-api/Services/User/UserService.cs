using Acessi_api.Context;
using Acessi_api.Interfaces.User;
using Acessi_api.Models.User;


namespace Acessi_api.Services.User
{

    public class UserService: IUserService
    {
        private readonly AcessiContext _context;

        public UserService(AcessiContext context)
        {
            _context = context;
        }

        public async Task<UserModel> CreateUserAsync(UserModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<UserModel> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }
    }
}
