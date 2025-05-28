using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRvMedical2.dto;
using ApiRvMedical2.Models;

namespace ApiRvMedical2.interfaces
{
    public interface IAdmin
    {
        Task<List<UserDto>> GetAllUtilisateursAsync();
      
       
    }
}
