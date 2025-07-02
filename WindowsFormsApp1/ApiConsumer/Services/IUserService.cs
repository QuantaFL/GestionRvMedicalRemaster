using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IUserService
    {
        Task<User> GetAuthenticatedUserAsync();
        Task ChangePasswordAsync(ChangePasswordRequest request);
        Task AdminResetPasswordAsync(int userId, AdminResetPasswordRequest request);
        Task<List<User>> ListUsersAsync();
        Task<User> CreateUserAsync(CreateUserRequest request);
        Task<User> GetUserAsync(int userId);
        Task<User> UpdateUserAsync(int userId, UpdateUserRequest request);
        Task DeleteUserAsync(int userId);
    }
}
