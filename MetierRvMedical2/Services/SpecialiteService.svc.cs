using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SpecialiteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SpecialiteService.svc or SpecialiteService.svc.cs at the Solution Explorer and start debugging.
    public class SpecialiteService : ISpecialiteService
    {
        public void DoWork()
        {
        }
        private bdRdvMedicalContext _db;

        public SpecialiteService(bdRdvMedicalContext context)
        {
            _db = context;
        }
        public SpecialiteService()
        {
            _db = new bdRdvMedicalContext();
        }

        public List<Specialite> GetAllSpecialites()
        {
            return _db.Specialite.ToList();
        }

        public Specialite GetSpecialiteByCode(string code)
        {
            return _db.Specialite.FirstOrDefault(s => s.CodeSpecialte == code);
        }
    }
}
