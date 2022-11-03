using HotelManagement.Server.Data;
using HotelManagement.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public class ManagerAccessLayer : IManagerRepository
    {
        private AppDbContext _context;
        public ManagerAccessLayer(AppDbContext context)
        {
            _context = context;
        }

        //To Get all Manager details   
        public async Task<IEnumerable<Manager>> GetAllManager()
        {
            try
            {
                return await _context.Manager.ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //To Add new Doctor record     
        public void AddManager(Manager manager)
        {
            try
            {
                _context.Manager.Add(manager);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Doctor    
        public void UpdateManager(Manager manager)
        {
            try
            {
                _context.Entry(manager).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Doctor    
        public Manager GetManagerData(long id)
        {
            try
            {
                Manager manager = _context.Manager.Find(id);
                return manager;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Doctor    
        public void DeleteManager(int id)
        {
            try
            {
                Manager emp = _context.Manager.Find(id);
                _context.Manager.Remove(emp);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public Manager GetManagerById(int id)
        {
            try
            {
                Manager manager = _context.Manager.Find(id);
                return manager;
            }
            catch
            {
                throw;
            }
        }
    }
}
