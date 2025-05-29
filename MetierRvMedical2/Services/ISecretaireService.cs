using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISecretaireService" in both code and config file together.
    [ServiceContract]
    public interface ISecretaireService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Secretaire GetSecretaireByMatricule(string matricule);

        [OperationContract]
        void ActiverSecretaire(string matricule);

        [OperationContract]
        void DesactiverSecretaire(string matricule);

        [OperationContract]
        IEnumerable<Secretaire> GetAllSecretaires();

        [OperationContract]
        int CountSecretaires();
    }
}
