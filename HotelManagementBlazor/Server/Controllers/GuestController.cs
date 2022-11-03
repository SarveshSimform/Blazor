using HotelManagement.Server.Models;
using HotelManagement.Server.Repositories;
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
    public class GuestController : ControllerBase
    {
        private IGuestRepository _guestRepository;

        public GuestController(IGuestRepository guestRepsitory)
        {
            _guestRepository = guestRepsitory;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return Ok(await _guestRepository.GetAllGuests());
        }



        [HttpPost]
        public void Create([FromBody] Guest guest)
        {
            if (ModelState.IsValid)
                this._guestRepository.AddGuest(guest);

        }



        [HttpGet("{id}")]
        public Guest Details(int id)
        {
            return _guestRepository.GetGuestById(id);
        }



        [HttpPut]
        public void Edit([FromBody] Guest guest)
        {
            if (ModelState.IsValid)
                this._guestRepository.UpdateGuest(guest);
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guestRepository.DeleteGuest(id);
        }
    }
}