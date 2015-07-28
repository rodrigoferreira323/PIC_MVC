using PIC_DATABASE.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_DATABASE.Models
{
    [Table("Users")]
    public class Users
    {  
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Job { get; set; }

        public string Departament { get; set; }

        public UserType UserType { get; set; }

        public bool Active { get; set; }

        public string Token { get; set; }

        public string IP { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime? FirstLogin { get; set; }

        public DateTime? LastLogin { get; set; }


    }
}
