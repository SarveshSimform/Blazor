using HotelManagement.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public interface IManagerRepository
    {
        Task<IEnumerable<Manager>> GetAllManager();
        void AddManager(Manager manager);
        void UpdateManager(Manager manager);
        Manager GetManagerById(int id);
        void DeleteManager(int id);
    }
}
