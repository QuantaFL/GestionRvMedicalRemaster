using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class SecretaireService : BaseApiService, ISecretaireService
    {
        public SecretaireService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<SecretaireDetails>> ListSecretairesAsync()
        {
            return await GetAsync<List<SecretaireDetails>>("secretaires");
        }

        public async Task<SecretaireDetails> GetSecretaireAsync(int secretaireId)
        {
            return await GetAsync<SecretaireDetails>($"secretaires/{secretaireId}");
        }

        public async Task<SecretaireDetails> UpdateSecretaireAsync(int secretaireId, UpdateSecretaireDetailsRequest request)
        {
            return await PutAsync<UpdateSecretaireDetailsRequest, SecretaireDetails>($"secretaires/{secretaireId}", request);
        }
    }
}
