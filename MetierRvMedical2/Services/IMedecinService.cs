using MetierRvMedical2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMedecinService" in both code and config file together.
    [ServiceContract]
    public interface IMedecinService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        Medecin GetMedecinByNumeroOrdre(string numeroOrdre);

        [OperationContract]
        void ActiverMedecin(string numeroOrdre);

        [OperationContract]
        void DesactiverMedecin(string numeroOrdre);

        [OperationContract]
        IEnumerable<Medecin> GetAllMedecins(string numeroOrdre);

        [OperationContract]
        Medecin GetMedecinBySpecialite(String specialite);

        [OperationContract]
        IEnumerable<Medecin> GetMedecinsBySpecialite(String specialite);
    }
}
