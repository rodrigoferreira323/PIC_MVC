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
        public bool UserVerification(User usuario)
        {
            switch (usuario._User)
            {
                case "administrador":
                    if (usuario.Password == "vt4001adm")
                    {
                        usuario.tipoUsuario = tipoUsuario.administrador;
                        return true;
                    }
                    break;

                case "operador":
                    if (usuario.Password == "opvt40tt")
                    {
                        usuario.tipoUsuario = tipoUsuario.operador;
                        return true;
                    }
                    break;

                case "desenvolvedor":
                    if (usuario.Password == "vstudioPICmvc")
                    {
                        usuario.tipoUsuario = tipoUsuario.desenvolvedor;
                        return true;
                    }
                    break;

                case "visiontec":
                    if (usuario.Password == "visiontec123")
                    {
                        usuario.tipoUsuario = tipoUsuario.visiontec;
                        return true;
                    }
                    break;

                default:
                    return false;
            }
            return false;
        }
    }
}