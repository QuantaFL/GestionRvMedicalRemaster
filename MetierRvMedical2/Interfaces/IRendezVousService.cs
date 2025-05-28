using MetierRvMedical2.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace MetierRvMedical2.Interfaces
{
    [ServiceContract]
    public interface IRendezVousService
    {
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