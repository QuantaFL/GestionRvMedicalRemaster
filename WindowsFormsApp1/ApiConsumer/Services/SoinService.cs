using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class SoinService : BaseApiService, ISoinService
    {
        public SoinService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<Soin>> ListSoinsAsync()
        {
            return await GetAsync<List<Soin>>("soins");
        }

        public async Task<Soin> CreateSoinAsync(CreateSoinRequest request)
        {
            return await PostAsync<CreateSoinRequest, Soin>("soins", request);
        }

        public async Task<Soin> GetSoinAsync(int soinId)
        {
            return await GetAsync<Soin>($"soins/{soinId}");
        }

        public async Task<Soin> UpdateSoinAsync(int soinId, UpdateSoinRequest request)
        {
            return await PutAsync<UpdateSoinRequest, Soin>($"soins/{soinId}", request);
        }

        public async Task DeleteSoinAsync(int soinId)
        {
            await DeleteAsync($"soins/{soinId}");
        }
    }
}
