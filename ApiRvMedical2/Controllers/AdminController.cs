using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ApiRvMedical2.interfaces;
using ApiRvMedical2.Models;
using ApiRvMedical2.services;
using Serilog;

namespace ApiRvMedical2.Controllers
{
    
    public class AdminController : ApiController
    {

        private readonly bdRdvMedicalContext _db;
        private readonly AdminService _adminService;
        public AdminController()
        {
            _db = new bdRdvMedicalContext();
            _adminService = new AdminService(_db);
        }

        [HttpGet]
        [Route("api/v1/utilisateurs")]
        public async Task<IHttpActionResult> Get()
        {
            var utilisateurs = await _adminService.GetAllUtilisateursAsync();
            return Ok(utilisateurs);
        }

       


        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}