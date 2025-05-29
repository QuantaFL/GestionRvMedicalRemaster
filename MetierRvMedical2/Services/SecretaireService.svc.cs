using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SecretaireService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SecretaireService.svc or SecretaireService.svc.cs at the Solution Explorer and start debugging.
    public class SecretaireService : ISecretaireService
    {
        private readonly bdRdvMedicalContext _db;

        public void AddSecretaire(Secretaire secretaire)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public SecretaireService()
        {
            _db = new bdRdvMedicalContext();
        }

        public SecretaireService(bdRdvMedicalContext context)
        {
            _db = context;
        }


        public Secretaire GetSecretaireByMatricule(string matricule)
        {
            return _db.Secretaires.FirstOrDefault(s => s.Matricule == matricule);
        }

        public void ActiverSecretaire(string matricule)
        {
            var secretaire = GetSecretaireByMatricule(matricule);
            if (secretaire != null)
            {
                secretaire.Status = true;
                _db.SaveChanges();
            }
        }

        public void DesactiverSecretaire(string matricule)
        {
            var secretaire = GetSecretaireByMatricule(matricule);
            if (secretaire != null)
            {
                secretaire.Status = false;
                _db.SaveChanges();
            }
        }

        public IEnumerable<Secretaire> GetAllSecretaires()
        {
            return _db.Secretaires.ToList();
        }

        public int CountSecretaires()
        {
            try
            {
                return _db.Secretaires.Count();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
