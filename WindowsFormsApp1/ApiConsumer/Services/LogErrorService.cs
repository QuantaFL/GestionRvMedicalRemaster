using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class LogErrorService : BaseApiService, ILogErrorService
    {
        public LogErrorService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<LogError>> ListLogErrorsAsync()
        {
            return await GetAsync<List<LogError>>("log-erreurs");
        }

        public async Task<LogError> GetLogErrorAsync(int logErreurId)
        {
            return await GetAsync<LogError>($"log-erreurs/{logErreurId}");
        }

        public async Task DeleteLogErrorAsync(int logErreurId)
        {
            await DeleteAsync($"log-erreurs/{logErreurId}");
        }
    }
}
