using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRvMedical2.dto.get;
using ApiRvMedical2.Models;

namespace ApiRvMedical2.interfaces
{
    public interface IMedecin
    {
        Task<GetMedecinDto> GetMedecinByNumerOrdre(string NumerOrdre);
        Task<bool> BloquerMedecin(string numerOrdre);
        Task<bool> DebloquerMedecin(string numerOrdre);
    }
}
