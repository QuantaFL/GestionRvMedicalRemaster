using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public interface IPatientService
    {
        Task<List<Patient>> ListPatientsAsync(string search = null);
        Task<Patient> CreatePatientAsync(CreatePatientRequest request);
        Task<Patient> GetPatientAsync(int patientId);
        Task<Patient> UpdatePatientAsync(int patientId, UpdatePatientRequest request);
        Task DeletePatientAsync(int patientId);
    }
}
