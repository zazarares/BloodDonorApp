using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace WebApplication2
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Doctor()
        {
            
        }
        public User_Working U = new User_Working();


    }
}