using HotelManagement.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Repositories
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAllStaffs();
        void AddStaff(Staff staff);
        void UpdateStaff(Staff staff);
        Staff GetStaffById(int id);
        void DeleteStaff(int id);
    }
}
