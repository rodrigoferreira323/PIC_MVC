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
        [Required(ErrorMessage = "Insira o usuário")]
        public string User { get; set; }
         
        [Required(ErrorMessage = "Insira a senha")]
        public string Password { get; set; }

        public tipoUsuario tipoUsuario { get; set; }

    }

}