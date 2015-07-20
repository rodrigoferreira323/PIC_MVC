using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PIC_MVC.Models.Enum;
using PIC_MVC.Models;

namespace PIC_MVC.Repository
{
    public class UserRepository
    {
        private List<User> userList = new List<User>();

        public UserRepository()
        {
            if (HttpContext.Current.Session["BD"] == null)
            {
                CreateUsers();

                HttpContext.Current.Session["BD"] = userList;
            }
            else
            {
                userList = (List<User>)HttpContext.Current.Session["BD"];
            }
        }

        public User GetUser(string user, string password)
        {
            return userList.FirstOrDefault(x => x.username == user && x.password == password);
        }

        private void CreateUsers()
        {
            userList.Add(new User()
            {
                username = "visiontec",
                password = "visiontec123",
                tipoUsuario = tipoUsuario.Visiontec
            });

            userList.Add(new User()
            {
                username = "administrador",
                password = "vt4001adm",
                tipoUsuario = tipoUsuario.Administrador
            });

            userList.Add(new User()
            {
                username = "desenvolvedor",
                password = "vstudioPICmvc",
                tipoUsuario = tipoUsuario.Desenvolvedor
            });

            userList.Add(new User()
            {
                username = "operador",
                password = "opvt40tt",
                tipoUsuario = tipoUsuario.Operador
            });
        }

        public bool ExistsUser(string user, string password)
        {
            return userList.Any(u => u.username == user && u.password == password);
        }

    }
}