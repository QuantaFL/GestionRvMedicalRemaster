using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IGroupeSanguinService
    {
        Task<List<GroupeSanguin>> ListGroupeSanguinsAsync();
        Task<GroupeSanguin> CreateGroupeSanguinAsync(CreateGroupeSanguinRequest request);
        Task<GroupeSanguin> GetGroupeSanguinAsync(int groupeSanguinId); // API uses {groupeSanguin}
        Task<GroupeSanguin> UpdateGroupeSanguinAsync(int groupeSanguinId, UpdateGroupeSanguinRequest request);
        Task DeleteGroupeSanguinAsync(int groupeSanguinId);
    }
}
