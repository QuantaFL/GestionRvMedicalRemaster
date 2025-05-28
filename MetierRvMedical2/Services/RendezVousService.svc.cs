using MetierRvMedical2.Interfaces;
using MetierRvMedical2.Models;
using System.Collections.Generic;
using System.Linq;

namespace MetierRvMedical2.Services
{
    public class RendezVousService : IRendezVousService
    {
        private readonly bdRdvMedicalContext _db = new bdRdvMedicalContext();

        public IEnumerable<RendezVous> GetAllRendezVous()
        {
            return _db.RendezVous.ToList();
        }

        public RendezVous GetRendezVousById(int id)
        {
            return _db.RendezVous.FirstOrDefault(rv => rv.IdRendezVous == id);
        }

        public void AddRendezVous(RendezVous rendezVous)
        {
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