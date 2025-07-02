using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class ApplicationDataService : BaseApiService, IApplicationDataService
    {
        public ApplicationDataService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<AppDataSelectLists> GetSelectListsAsync()
        {
            return await GetAsync<AppDataSelectLists>("app-data/select-lists");
        }
    }
}
