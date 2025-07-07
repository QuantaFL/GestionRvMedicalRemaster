using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IMedecinService
    {
        Task<List<MedecinDetails>> ListMedecinsAsync(int? specialiteId = null);
        Task<MedecinDetails> GetMedecinAsync(int medecinId);
        Task<MedecinDetails> UpdateMedecinAsync(int medecinId, UpdateMedecinDetailsRequest request);
    }
}
