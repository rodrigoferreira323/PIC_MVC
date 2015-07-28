using PIC_DATABASE.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIC_MVC.Areas.Home.Models
{
    public class UserViewModel
    {

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Job { get; set; }

        public string Departament { get; set; }

        public UserType UserType { get; set; }

        public bool Active { get; set; }

        public string IP { get; set; }

        public UserType UserDev { get; set; }
    }
}