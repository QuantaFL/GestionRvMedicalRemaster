using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISpecialiteService" in both code and config file together.
    [ServiceContract]
    public interface ISpecialiteService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        List<Specialite> GetAllSpecialites();
        [OperationContract]
        Specialite GetSpecialiteByCode(String code);
    }
}
