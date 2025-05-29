using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RoleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RoleService.svc or RoleService.svc.cs at the Solution Explorer and start debugging.
    public class RoleService : IRoleService
    {
        public void DoWork()
        {
        }
        private bdRdvMedicalContext _db;
        public RoleService(bdRdvMedicalContext context)
        {
            _db = context;
        }
        public RoleService()
        {
            _db = new bdRdvMedicalContext();
        }

        public Role GetRoleByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new ArgumentException("Le code ne peut pas être vide.", nameof(code));
            }
            var role = _db.Role.FirstOrDefault(r => r.CodeRole == code);
            if (role == null)
            {
                throw new KeyNotFoundException($"Aucun rôle trouvé avec le code : {code}");
            }
            return role;
        }
    }
}
