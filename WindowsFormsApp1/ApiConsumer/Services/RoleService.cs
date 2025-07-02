using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class RoleService : BaseApiService, IRoleService
    {
        public RoleService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<Role>> ListRolesAsync()
        {
            return await GetAsync<List<Role>>("roles");
        }

        public async Task<Role> CreateRoleAsync(CreateRoleRequest request)
        {
            return await PostAsync<CreateRoleRequest, Role>("roles", request);
        }

        public async Task<Role> GetRoleAsync(int roleId)
        {
            return await GetAsync<Role>($"roles/{roleId}");
        }

        public async Task<Role> UpdateRoleAsync(int roleId, UpdateRoleRequest request)
        {
            return await PutAsync<UpdateRoleRequest, Role>($"roles/{roleId}", request);
        }

        public async Task DeleteRoleAsync(int roleId)
        {
            await DeleteAsync($"roles/{roleId}");
        }
    }
}
