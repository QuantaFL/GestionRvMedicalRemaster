using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class AuthService : BaseApiService, IAuthService
    {
        public AuthService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<LoginResponseData> LoginAsync(LoginRequest request)
        {
            return await PostAsync<LoginRequest, LoginResponseData>("login", request);
        }

        public async Task LogoutAsync()
        {
            await PostAsync<object, object>("logout", null); // Sending null for no body, expecting no specific data back
        }
    }
}
