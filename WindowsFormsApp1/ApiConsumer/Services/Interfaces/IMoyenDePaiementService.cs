using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IMoyenDePaiementService
    {
        Task<List<MoyenDePaiement>> ListMoyenDePaiementsAsync();
        Task<MoyenDePaiement> CreateMoyenDePaiementAsync(CreateMoyenDePaiementRequest request);
        Task<MoyenDePaiement> GetMoyenDePaiementAsync(int moyenDePaiementId); // API uses {moyenDePaiement}
        Task<MoyenDePaiement> UpdateMoyenDePaiementAsync(int moyenDePaiementId, UpdateMoyenDePaiementRequest request);
        Task DeleteMoyenDePaiementAsync(int moyenDePaiementId);
    }
}
