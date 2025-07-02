using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class MoyenDePaiementService : BaseApiService, IMoyenDePaiementService
    {
        public MoyenDePaiementService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<MoyenDePaiement>> ListMoyenDePaiementsAsync()
        {
            return await GetAsync<List<MoyenDePaiement>>("moyen-de-paiements");
        }

        public async Task<MoyenDePaiement> CreateMoyenDePaiementAsync(CreateMoyenDePaiementRequest request)
        {
            return await PostAsync<CreateMoyenDePaiementRequest, MoyenDePaiement>("moyen-de-paiements", request);
        }

        public async Task<MoyenDePaiement> GetMoyenDePaiementAsync(int moyenDePaiementId)
        {
            return await GetAsync<MoyenDePaiement>($"moyen-de-paiements/{moyenDePaiementId}");
        }

        public async Task<MoyenDePaiement> UpdateMoyenDePaiementAsync(int moyenDePaiementId, UpdateMoyenDePaiementRequest request)
        {
            return await PutAsync<UpdateMoyenDePaiementRequest, MoyenDePaiement>($"moyen-de-paiements/{moyenDePaiementId}", request);
        }

        public async Task DeleteMoyenDePaiementAsync(int moyenDePaiementId)
        {
            await DeleteAsync($"moyen-de-paiements/{moyenDePaiementId}");
        }
    }
}
