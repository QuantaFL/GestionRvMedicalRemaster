using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class RendezVousService : BaseApiService, IRendezVousService
    {
        public RendezVousService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<RendezVous>> ListRendezVousAsync(ListRendezVousParams queryParams = null)
        {
            var dictParams = new Dictionary<string, string>();
            if (queryParams != null)
            {
                if (queryParams.PatientId.HasValue)
                    dictParams["patient_id"] = queryParams.PatientId.Value.ToString();
                if (queryParams.MedecinId.HasValue)
                    dictParams["medecin_id"] = queryParams.MedecinId.Value.ToString();
                if (queryParams.DateFrom.HasValue)
                    dictParams["date_from"] = queryParams.DateFrom.Value.ToString("yyyy-MM-dd");
                if (queryParams.DateTo.HasValue)
                    dictParams["date_to"] = queryParams.DateTo.Value.ToString("yyyy-MM-dd");
            }
            return await GetAsync<List<RendezVous>>("rendez-vous", dictParams);
        }

        public async Task<RendezVous> CreateRendezVousAsync(CreateRendezVousRequest request)
        {
            return await PostAsync<CreateRendezVousRequest, RendezVous>("rendez-vous", request);
        }

        public async Task<RendezVous> GetRendezVousAsync(int rendezVousId)
        {
            // API uses {rendezVou} in path, ensure this matches if BaseApiService relies on exact segment names for anything (it doesn't currently)
            return await GetAsync<RendezVous>($"rendez-vous/{rendezVousId}");
        }

        public async Task<RendezVous> UpdateRendezVousAsync(int rendezVousId, UpdateRendezVousRequest request)
        {
            return await PutAsync<UpdateRendezVousRequest, RendezVous>($"rendez-vous/{rendezVousId}", request);
        }

        public async Task DeleteRendezVousAsync(int rendezVousId)
        {
            await DeleteAsync($"rendez-vous/{rendezVousId}");
        }

        public async Task<RendezVous> ConfirmRendezVousAsync(int rendezVousId)
        {
           return await PostAsync<object, RendezVous>($"rendez-vous/{rendezVousId}/confirm", null);
        }

        public async Task<RendezVous> CancelRendezVousAsync(int rendezVousId, CancelRendezVousRequest request = null)
        {
            return await PostAsync<CancelRendezVousRequest, RendezVous>($"rendez-vous/{rendezVousId}/cancel", request ?? new CancelRendezVousRequest());
        }
    }
}
