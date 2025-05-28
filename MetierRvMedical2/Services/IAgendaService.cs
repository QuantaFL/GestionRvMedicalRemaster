using MetierRvMedical2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MetierRvMedical2.Services
{
    [ServiceContract]
    public interface IAgendaService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        IEnumerable<Agenda> GetAllAgendas();

        [OperationContract]
        Agenda GetAgendaById(int id);

        [OperationContract]
        void CreateAgenda(Agenda agenda);

        [OperationContract]
        void UpdateAgenda(Agenda agenda);

        [OperationContract]
        void DeleteAgenda(int id);

        [OperationContract]
        IEnumerable<Agenda> GetAgendasByMedecinId(int medecinId);
    }
}
