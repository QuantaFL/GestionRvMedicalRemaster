using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class GroupeSanguinService : BaseApiService, IGroupeSanguinService
    {
        public GroupeSanguinService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<GroupeSanguin>> ListGroupeSanguinsAsync()
        {
            return await GetAsync<List<GroupeSanguin>>("groupe-sanguins");
        }

        public async Task<GroupeSanguin> CreateGroupeSanguinAsync(CreateGroupeSanguinRequest request)
        {
            return await PostAsync<CreateGroupeSanguinRequest, GroupeSanguin>("groupe-sanguins", request);
        }

        public async Task<GroupeSanguin> GetGroupeSanguinAsync(int groupeSanguinId)
        {
           return await GetAsync<GroupeSanguin>($"groupe-sanguins/{groupeSanguinId}");
        }

        public async Task<GroupeSanguin> UpdateGroupeSanguinAsync(int groupeSanguinId, UpdateGroupeSanguinRequest request)
        {
            return await PutAsync<UpdateGroupeSanguinRequest, GroupeSanguin>($"groupe-sanguins/{groupeSanguinId}", request);
        }

        public async Task DeleteGroupeSanguinAsync(int groupeSanguinId)
        {
            await DeleteAsync($"groupe-sanguins/{groupeSanguinId}");
        }
    }
}
