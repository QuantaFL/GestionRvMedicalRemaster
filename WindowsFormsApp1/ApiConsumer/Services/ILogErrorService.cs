using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface ILogErrorService
    {
        Task<List<LogError>> ListLogErrorsAsync();
        Task<LogError> GetLogErrorAsync(int logErreurId);
        Task DeleteLogErrorAsync(int logErreurId);
    }
}
