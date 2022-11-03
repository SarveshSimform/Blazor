using HotelManagement.Server.Models;
using HotelManagement.Server.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Manager")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ManagerController : ControllerBase
    {
        private IManagerRepository _managerRepository;

        public ManagerController(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        [HttpGet]
        /*[Route("api/Doctor/Index")]*/
        
        public async Task<ActionResult> Index()
        {
            return Ok(await _managerRepository.GetAllManager());
        }

        [HttpPost]
       /* [Route("api/Doctor/Create")]*/
        public void Create([FromBody] Manager manager)
        {
            if (ModelState.IsValid)
                this._managerRepository.AddManager(manager);
        }

        [HttpGet("{id}")]
      /*  [Route("api/Doctor/Details/{id}")]*/
        public Manager Details(int id)
        {
            return _managerRepository.GetManagerById(id);
        }

        [HttpPut]
       /* [Route("api/Doctor/Edit")]*/
        public void Edit([FromBody] Manager manager)
        {
            if (ModelState.IsValid)
                this._managerRepository.UpdateManager(manager);
        }

        [HttpDelete("{id}")]
       /* [Route("api/Doctor/Delete/{id}")]*/
        public void Delete(int id)
        {
            _managerRepository.DeleteManager(id);
        }
    }
}
