using HotelManagement.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public interface IGuestRepository
    {
        Task<IEnumerable<Guest>> GetAllGuests();
        void AddGuest(Guest guest);
        void UpdateGuest(Guest guest);
        Guest GetGuestById(int id);
        void DeleteGuest(int id);
    }
}
