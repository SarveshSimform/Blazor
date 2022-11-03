using HotelManagement.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Guest> Guest { get; set; }
    }
}
