using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class UserService : BaseApiService, IUserService
    {
        public UserService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<User> GetAuthenticatedUserAsync()
        {
            return await GetAsync<User>("user");
        }

        public async Task ChangePasswordAsync(ChangePasswordRequest request)
        {
             await PostAsync("user/change-password", request);
        }

        public async Task AdminResetPasswordAsync(int userId, AdminResetPasswordRequest request)
        {
            await PostAsync($"users/{userId}/admin-reset-password", request);
        }

        public async Task<List<User>> ListUsersAsync()
        {
            return await GetAsync<List<User>>("users");
        }

        public async Task<User> CreateUserAsync(CreateUserRequest request)
        {
            return await PostAsync<CreateUserRequest, User>("users", request);
        }

        public async Task<User> GetUserAsync(int userId)
        {
            return await GetAsync<User>($"users/{userId}");
        }

        public async Task<User> UpdateUserAsync(int userId, UpdateUserRequest request)
        {
            return await PutAsync<UpdateUserRequest, User>($"users/{userId}", request);
        }

        public async Task DeleteUserAsync(int userId)
        {
            await DeleteAsync($"users/{userId}");
        }
    }
}
