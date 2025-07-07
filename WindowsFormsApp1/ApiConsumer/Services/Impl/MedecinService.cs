using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class MedecinService : BaseApiService, IMedecinService
    {
        public MedecinService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<MedecinDetails>> ListMedecinsAsync(int? specialiteId = null)
        {
            var queryParams = new Dictionary<string, string>();
            if (specialiteId.HasValue)
            {
                queryParams["specialite_id"] = specialiteId.Value.ToString();
            }
            return await GetAsync<List<MedecinDetails>>("medecins", queryParams);
        }

        public async Task<MedecinDetails> GetMedecinAsync(int medecinId)
        {
            return await GetAsync<MedecinDetails>($"medecins/{medecinId}");
        }

        public async Task<MedecinDetails> UpdateMedecinAsync(int medecinId, UpdateMedecinDetailsRequest request)
        {
            return await PutAsync<UpdateMedecinDetailsRequest, MedecinDetails>($"medecins/{medecinId}", request);
        }
    }
}
