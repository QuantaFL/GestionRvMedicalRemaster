using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class SpecialiteService : BaseApiService, ISpecialiteService
    {
        public SpecialiteService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<Specialite>> ListSpecialitesAsync()
        {
            return await GetAsync<List<Specialite>>("specialites");
        }

        public async Task<Specialite> CreateSpecialiteAsync(CreateSpecialiteRequest request)
        {
            return await PostAsync<CreateSpecialiteRequest, Specialite>("specialites", request);
        }

        public async Task<Specialite> GetSpecialiteAsync(int specialiteId)
        {
            return await GetAsync<Specialite>($"specialites/{specialiteId}");
        }

        public async Task<Specialite> UpdateSpecialiteAsync(int specialiteId, UpdateSpecialiteRequest request)
        {
            return await PutAsync<UpdateSpecialiteRequest, Specialite>($"specialites/{specialiteId}", request);
        }

        public async Task DeleteSpecialiteAsync(int specialiteId)
        {
            await DeleteAsync($"specialites/{specialiteId}");
        }
    }
}
