﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2
{
    public class Donator
    {
        [Key]
        public int id { get; set; }
        public string CNP { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BloodType { get; set; }
        public string Zona { get; set; }
        public Donator()
        {

        }
        public Donator(int id,string CNP,string Firstname,string LastName,string BloodType,string Zona)
        {
            this.id = id;
            this.CNP = CNP;
            this.BloodType = BloodType;
            this.FirstName = Firstname;
            this.LastName = LastName;
            this.Zona = Zona;
        }
        public User_Working U=new User_Working();
    }
}