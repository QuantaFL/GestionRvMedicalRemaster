using MetierRvMedical2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MedecinService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MedecinService.svc or MedecinService.svc.cs at the Solution Explorer and start debugging.
    public class MedecinService : IMedecinService
    {
        private bdRdvMedicalContext _db;

        public MedecinService()
        {
            _db = new bdRdvMedicalContext();
        }

        public MedecinService(bdRdvMedicalContext context)
        {
            _db = context;
        }

        /// <summary>
        /// cette methode permet d'activer un médecin en fonction de son numéro d'ordre.
        /// </summary>
        /// <param name="numeroOrdre"></param>
        public void ActiverMedecin(string numeroOrdre)
        {
            var medecin = GetMedecinByNumeroOrdre(numeroOrdre);
            if (medecin != null)
            {
                medecin.Status = true;
                _db.SaveChanges();
            }
        }

        /// <summary>
        /// cette methode permet de désactiver un médecin en fonction de son numéro d'ordre.
        /// </summary>
        /// <param name="numeroOrdre"></param>
        public void DesactiverMedecin(string numeroOrdre)
        {
            var medecin = GetMedecinByNumeroOrdre(numeroOrdre);
            if (medecin != null)
            {
                medecin.Status = false;
                _db.SaveChanges();
            }
        }

        public void DoWork()
        {
        }

        /// <summary>
        /// cette methode permet e recuperer un médecin en fonction de son numéro d'ordre.
        /// </summary>
        /// <param name="numeroOrdre"></param>
        /// <returns></returns>
        public Medecin GetMedecinByNumeroOrdre(string numeroOrdre)
        {
            return _db.Medecins.FirstOrDefault(m => m.NumeroOrdre == numeroOrdre);
        }


    }
}
