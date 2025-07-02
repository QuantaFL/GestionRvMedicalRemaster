using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IAuthService
    {
        Task<LoginResponseData> LoginAsync(LoginRequest request);
        Task LogoutAsync();
    }
}
