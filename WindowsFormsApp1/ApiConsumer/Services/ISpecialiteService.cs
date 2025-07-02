using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface ISpecialiteService
    {
        Task<List<Specialite>> ListSpecialitesAsync();
        Task<Specialite> CreateSpecialiteAsync(CreateSpecialiteRequest request);
        Task<Specialite> GetSpecialiteAsync(int specialiteId);
        Task<Specialite> UpdateSpecialiteAsync(int specialiteId, UpdateSpecialiteRequest request);
        Task DeleteSpecialiteAsync(int specialiteId);
    }
}
