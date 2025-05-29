using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SoinService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SoinService.svc or SoinService.svc.cs at the Solution Explorer and start debugging.
    public class SoinService : ISoinService
    {
        public void DoWork()
        {
        }
        private bdRdvMedicalContext _db;

        public SoinService(bdRdvMedicalContext context)
        {
            _db = context;
        }
        public SoinService()
        {
            _db = new bdRdvMedicalContext();
        }
        /// <summary>
        /// Récupère tous les soins.
        /// </summary>
        /// <returns>Liste des soins</returns>
        public List<Soin> GetAllSoins()
        {
            return _db.Soins.ToList();
        }

        /// <summary>
        /// Récupère un soin par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du soin</param>
        /// <returns>Soin trouvé ou null</returns>
        public Soin GetSoinById(int id)
        {
            return _db.Soins.FirstOrDefault(s => s.IdSoin == id);
        }
    }
}
