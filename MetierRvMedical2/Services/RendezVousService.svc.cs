using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RendezVousService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RendezVousService.svc or RendezVousService.svc.cs at the Solution Explorer and start debugging.
    public class RendezVousService : IRendezVousService
    {
        public void DoWork()
        {
        }
        private readonly bdRdvMedicalContext _db = new bdRdvMedicalContext();

        public RendezVousService()
        {
            _db = new bdRdvMedicalContext();
        }

        public RendezVousService(bdRdvMedicalContext context)
        {
            _db = context;
        }

        public IEnumerable<RendezVous> GetAllRendezVous()
        {
            return _db.RendezVous.ToList();
        }

        public RendezVous GetRendezVousById(int id)
        {
            return _db.RendezVous.FirstOrDefault(rv => rv.IdRendezVous == id);
        }

        public void AddRendezVous(String DateRv, String HeureRv, int? IdSoin, int? IdPatient, int? IdMedecin, int? IdAgenda, string CodeRdv)
        {
            RendezVous rendezVous = new RendezVous {DateRv=DateRv, HeureRv = HeureRv,IdAgenda = IdAgenda, CodeRdv = CodeRdv, IdMedecin = IdMedecin, IdPatient = IdPatient, IdSoin = IdSoin };
            _db.RendezVous.Add(rendezVous);
            _db.SaveChanges();
        }

        public void UpdateRendezVous(RendezVous rendezVous)
        {
            var existing = _db.RendezVous.FirstOrDefault(rv => rv.IdRendezVous == rendezVous.IdRendezVous);
            if (existing != null)
            {
                _db.Entry(existing).CurrentValues.SetValues(rendezVous);
                _db.SaveChanges();
            }
        }

        public void DeleteRendezVous(int id)
        {
            var rendezVous = _db.RendezVous.FirstOrDefault(rv => rv.IdRendezVous == id);
            if (rendezVous != null)
            {
                _db.RendezVous.Remove(rendezVous);
                _db.SaveChanges();
            }
        }

   
    }
}
