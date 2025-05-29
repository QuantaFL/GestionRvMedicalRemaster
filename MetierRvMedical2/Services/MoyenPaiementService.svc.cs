using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MoyenPaiement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MoyenPaiement.svc or MoyenPaiement.svc.cs at the Solution Explorer and start debugging.
    public class MoyenPaiementService : IMoyenPaiementService
    {
        public void DoWork()
        {
        }
        private bdRdvMedicalContext _db;

        public MoyenPaiementService(bdRdvMedicalContext context)
        {
            _db = context;
        }
        public MoyenPaiementService()
        {
            _db = new bdRdvMedicalContext();
        }
        /// <summary>
        /// Récupère tous les moyens de paiement.
        /// </summary>
        /// <returns>Liste des moyens de paiement</returns>
        public List<MoyenDePaiement> GetAllMoyenDePaiements()
        {
            return _db.MoyenDePaiements.ToList();
        }
    }
}
