using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IApplicationDataService
    {
        Task<AppDataSelectLists> GetSelectListsAsync();
    }
}
