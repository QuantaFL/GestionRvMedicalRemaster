using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class AgendaService : BaseApiService, IAgendaService
    {
        public AgendaService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<Agenda>> ListAgendasAsync(ListAgendasParams queryParams = null)
        {
            var dictParams = new Dictionary<string, string>();
            if (queryParams != null)
            {
                if (queryParams.MedecinId.HasValue)
                    dictParams["medecin_id"] = queryParams.MedecinId.Value.ToString();
                if (queryParams.DateFrom.HasValue)
                    dictParams["date_from"] = queryParams.DateFrom.Value.ToString("yyyy-MM-dd");
                if (queryParams.DateTo.HasValue)
                    dictParams["date_to"] = queryParams.DateTo.Value.ToString("yyyy-MM-dd");
                if (queryParams.SpecialiteId.HasValue)
                    dictParams["specialite_id"] = queryParams.SpecialiteId.Value.ToString();
                if (queryParams.Date.HasValue)
                    dictParams["date"] = queryParams.Date.Value.ToString("yyyy-MM-dd");
            }
            return await GetAsync<List<Agenda>>("agendas", dictParams);
        }

        public async Task<Agenda> CreateAgendaAsync(CreateAgendaRequest request)
        {
            return await PostAsync<CreateAgendaRequest, Agenda>("agendas", request);
        }

        public async Task<Agenda> GetAgendaAsync(int agendaId)
        {
            return await GetAsync<Agenda>($"agendas/{agendaId}");
        }

        public async Task<Agenda> UpdateAgendaAsync(int agendaId, UpdateAgendaRequest request)
        {
            return await PutAsync<UpdateAgendaRequest, Agenda>($"agendas/{agendaId}", request);
        }

        public async Task DeleteAgendaAsync(int agendaId)
        {
            await DeleteAsync($"agendas/{agendaId}");
        }
    }
}
