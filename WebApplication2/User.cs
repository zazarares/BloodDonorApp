using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2
{
    public class User
    {

    }
    public class UserDBContext : DbContext
    {
        public UserDBContext()
        {

        }
        public DbSet<User_Working> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}