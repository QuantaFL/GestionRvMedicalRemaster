using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface ISoinService
    {
        Task<List<Soin>> ListSoinsAsync();
        Task<Soin> CreateSoinAsync(CreateSoinRequest request);
        Task<Soin> GetSoinAsync(int soinId);
        Task<Soin> UpdateSoinAsync(int soinId, UpdateSoinRequest request);
        Task DeleteSoinAsync(int soinId);
    }
}
