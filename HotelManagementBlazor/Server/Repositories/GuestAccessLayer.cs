using HotelManagement.Server.Data;
using HotelManagement.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public class GuestAccessLayer : IGuestRepository
    {
        private AppDbContext _context;
        public GuestAccessLayer(AppDbContext context)
        {
            _context = context;
        }
        public void AddGuest(Guest guest)
        {
            try
            {
                _context.Guest.Add(guest);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteGuest(int id)
        {
            try
            {
                Guest guest = _context.Guest.Find(id);
                _context.Guest.Remove(guest);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Guest>> GetAllGuests()
        {
            try
            {
                return await _context.Guest.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Guest GetGuestById(int id)
        {
            try
            {
                Guest guest = _context.Guest.Find(id);

                return guest;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateGuest(Guest guest)
        {
            try
            {
                _context.Entry(guest).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
