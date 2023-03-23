using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace WebApplication2
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public Admin() {; }
        public User_Working U = new User_Working();

    }
}