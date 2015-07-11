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
        public Enum UserVerification(User usuario)
        {
            switch (usuario.User)
            {
                case "administrador":
                    if (usuario.Password == "vt4001adm")
                    {
                        return tipoUsuario.administrador;
                    }
                    break;

                case "operador":
                    if (usuario.Password == "opvt40tt")
                    {
                        return tipoUsuario.operador;
                    }
                    break;

                case "desenvolvedor":
                    if (usuario.Password == "vstudioPICmvc")
                    {
                        return tipoUsuario.desenvolvedor;
                    }
                    break;

                case "visiontec":
                    if (usuario.Password == "visiontec123")
                    {
                        return tipoUsuario.visiontec;
                    }
                    break;

                default:
                    return null;
            }
            return null;
        }
    }
}