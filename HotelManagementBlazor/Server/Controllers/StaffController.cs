using HotelManagement.Server.Models;
using HotelManagement.Server.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;



namespace HotelManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Manager, Staff")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class StaffController : ControllerBase
    {
        private IStaffRepository _staffRepository;



        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _staffRepository.GetAllStaffs());
        }



        [HttpPost]
        public void Create([FromBody] Staff staff)
        {
            if (ModelState.IsValid)
                this._staffRepository.AddStaff(staff);
        }



        [HttpGet("{id}")]
        public Staff Details(int id)
        {
            return _staffRepository.GetStaffById(id);
        }



        [HttpPut]
        public void Edit([FromBody] Staff staff)
        {
            if (ModelState.IsValid)
                this._staffRepository.UpdateStaff(staff);
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _staffRepository.DeleteStaff(id);
        }
    }
}