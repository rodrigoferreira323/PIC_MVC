using PIC_MVC.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIC_MVC.Models
{
    public class User
    {
        public string username { get; set; }
         
        public string password { get; set; }

        public tipoUsuario? tipoUsuario { get; set; }

    }

}