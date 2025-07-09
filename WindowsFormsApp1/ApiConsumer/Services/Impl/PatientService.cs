using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsFormsApp1.ApiConsumer.Models;
using WindowsFormsApp1.ApiConsumer.Requests;

namespace WindowsFormsApp1.ApiConsumer.Services
{
    public class PatientService : BaseApiService, IPatientService
    {
        public PatientService(HttpClient httpClient, string baseUrl, SerializerType defaultSerializer = SerializerType.NewtonsoftJson)
            : base(httpClient, baseUrl, defaultSerializer)
        {
        }

        public async Task<List<Patient>> ListPatientsAsync()
        {
           
            return await GetAsync<List<Patient>>("patients");
        }

        public async Task<Patient> CreatePatientAsync(CreatePatientRequest request)
        {
            return await PostAsync<CreatePatientRequest, Patient>("patients", request);
        }

        public async Task<Patient> GetPatientAsync(int patientId)
        {
            return await GetAsync<Patient>($"patients/{patientId}");
        }

        public async Task<Patient> UpdatePatientAsync(int patientId, UpdatePatientRequest request)
        {
            return await PutAsync<UpdatePatientRequest, Patient>($"patients/{patientId}", request);
        }

        public async Task DeletePatientAsync(int patientId)
        {
            await DeleteAsync($"patients/{patientId}");
        }
    }
}
