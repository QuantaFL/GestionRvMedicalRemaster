using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IRoleService
    {
        Task<List<Role>> ListRolesAsync();
        Task<Role> CreateRoleAsync(CreateRoleRequest request);
        Task<Role> GetRoleAsync(int roleId);
        Task<Role> UpdateRoleAsync(int roleId, UpdateRoleRequest request);
        Task DeleteRoleAsync(int roleId);
    }
}
