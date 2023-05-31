using HotelManagement.Server.Data;
using HotelManagement.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public class GuestAccessLayer : IGuestRepository
    {
        private AppDbContext _context;
        private readonly ILogger<GuestAccessLayer> _logger;
        public GuestAccessLayer(AppDbContext context, ILogger<GuestAccessLayer> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void AddGuest(Guest guest)
        {
            try
            {
                _context.Guest.Add(guest);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while inserting data.");
                throw;
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
                _logger.LogError(ex, "Error while deleting data.");
                throw;
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
                _logger.LogError(ex, "Error while fetching all data.");
                throw;
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
                _logger.LogError(ex, "Error while fetching selected data");
                throw;
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
                _logger.LogError(ex, "Error while updating data.");
                throw;
            }
        }
    }
}
