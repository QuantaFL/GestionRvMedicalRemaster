using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MetierRvMedical2.Models;

namespace MetierRvMedical2.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRendezVousService" in both code and config file together.
    [ServiceContract]
    public interface IRendezVousService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        IEnumerable<RendezVous> GetAllRendezVous();

        [OperationContract]
        RendezVous GetRendezVousById(int id);

        [OperationContract]
        void AddRendezVous(RendezVous rendezVous);

        [OperationContract]
        void UpdateRendezVous(RendezVous rendezVous);

        [OperationContract]
        void DeleteRendezVous(int id);
    }
}
