using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string ShiftTime { get; set; }
    }
}
