using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMoyenPaiement" in both code and config file together.
    [ServiceContract]
    public interface IMoyenPaiementService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        List<MoyenDePaiement> GetAllMoyenDePaiements();
    }
}
