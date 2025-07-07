using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class ListRendezVousParams
    {
        public int? PatientId { get; set; }
        public int? MedecinId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }

    public interface IRendezVousService
    {
        Task<List<RendezVous>> ListRendezVousAsync(ListRendezVousParams queryParams = null);
        Task<RendezVous> CreateRendezVousAsync(CreateRendezVousRequest request);
        Task<RendezVous> GetRendezVousAsync(int rendezVousId);
        Task<RendezVous> UpdateRendezVousAsync(int rendezVousId, UpdateRendezVousRequest request);
        Task DeleteRendezVousAsync(int rendezVousId);
        Task<RendezVous> ConfirmRendezVousAsync(int rendezVousId);
        Task<RendezVous> CancelRendezVousAsync(int rendezVousId, CancelRendezVousRequest request = null);
    }
}
