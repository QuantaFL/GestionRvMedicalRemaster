using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface ISecretaireService
    {
        Task<List<SecretaireDetails>> ListSecretairesAsync();
        Task<SecretaireDetails> GetSecretaireAsync(int secretaireId);
        Task<SecretaireDetails> UpdateSecretaireAsync(int secretaireId, UpdateSecretaireDetailsRequest request);
    }
}
