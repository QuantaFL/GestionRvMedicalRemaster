using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PatientService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PatientService.svc or PatientService.svc.cs at the Solution Explorer and start debugging.
    public class PatientService : IPatientService
    {
        private readonly bdRdvMedicalContext _db;

        public PatientService()
        {
            _db = new bdRdvMedicalContext();
        }

        public PatientService(bdRdvMedicalContext context)
        {
            _db = context;
        }

        public void DoWork()
        {
        }

        public List<Patient> GetAllPatients()
        {
            return _db.Patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
            return _db.Patients.FirstOrDefault(p => p.IdP == id);
        }

        public void AddPatient(Patient patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            var existing = _db.Patients.FirstOrDefault(p => p.IdP == patient.IdP);
            if (existing != null)
            {
                _db.Entry(existing).CurrentValues.SetValues(patient);
                _db.SaveChanges();
            }
        }

        public void DeletePatient(int id)
        {
            var patient = _db.Patients.FirstOrDefault(p => p.IdP == id);
            if (patient != null)
            {
                _db.Patients.Remove(patient);
                _db.SaveChanges();
            }
        }
    }
}
