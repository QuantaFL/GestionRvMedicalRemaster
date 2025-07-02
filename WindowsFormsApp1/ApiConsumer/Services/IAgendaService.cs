using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class ListAgendasParams
    {
        public int? MedecinId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? SpecialiteId { get; set; }
        public DateTime? Date { get; set; }
    }

    public interface IAgendaService
    {
        Task<List<Agenda>> ListAgendasAsync(ListAgendasParams queryParams = null);
        Task<Agenda> CreateAgendaAsync(CreateAgendaRequest request);
        Task<Agenda> GetAgendaAsync(int agendaId);
        Task<Agenda> UpdateAgendaAsync(int agendaId, UpdateAgendaRequest request);
        Task DeleteAgendaAsync(int agendaId);
    }
}
