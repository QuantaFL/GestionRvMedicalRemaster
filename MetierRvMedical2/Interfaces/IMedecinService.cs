using MetierRvMedical2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MetierRvMedical2.Interfaces
{
    [ServiceContract]
    public interface IMedecinService
    {
        [OperationContract]
        Medecin GetMedecinByNumeroOrdre(string numeroOrdre);

        [OperationContract]
        void ActiverMedecin(string numeroOrdre);

        [OperationContract]
        void DesactiverMedecin(string numeroOrdre);
    }
}
