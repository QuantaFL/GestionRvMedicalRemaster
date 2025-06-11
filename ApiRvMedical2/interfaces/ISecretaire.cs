using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRvMedical2.dto.get;

namespace ApiRvMedical2.interfaces
{
    public interface ISecretaire
    {

        Task<GetSecretaireDto> GetSecretaireByTelOrMatricule(string identifiant);
        Task<bool> BloquerSecretaire(string identifiant);
        Task<bool> DebloquerSecretaire(string identifiant);
        Task<List<GetSecretaireDto>> GetAllSecretaire();
        Task<List<GetSecretaireDto>> GetAllActiveSecretaire();
    }
}
