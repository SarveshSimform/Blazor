using HotelManagement.Server.Data;
using HotelManagement.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public class StaffAccessLayer : IStaffRepository
    {
        private AppDbContext _context;
        public StaffAccessLayer(AppDbContext context)
        {
            _context = context;
        }
        public void AddStaff(Staff staff)
        {
            try
            {
                _context.Staff.Add(staff);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteStaff(int id)
        {
            try
            {
                Staff staff = _context.Staff.Find(id);
                _context.Staff.Remove(staff);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Staff>> GetAllStaffs()
        {
            try
            {
                return await _context.Staff.ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Staff GetStaffById(int id)
        {
            try
            {
                Staff staff = _context.Staff.Find(id);

                return staff;
            }
            catch
            {
                throw;
            }
        }

        public void UpdateStaff(Staff staff)
        {
            try
            {
                _context.Entry(staff).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
