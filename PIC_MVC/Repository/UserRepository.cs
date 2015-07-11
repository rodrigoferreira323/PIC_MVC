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
                        return true;
                    }
                    break;

                case "operador":
                    if (usuario.Password == "opvt40tt")
                    {
                        return true;
                    }
                    break;

                case "desenvolvedor":
                    if (usuario.Password == "vstudioPICmvc")
                    {
                        return true;
                    }
                    break;

                case "visiontec":
                    if (usuario.Password == "visiontec123")
                    {
                        return true;
                    }
                    break;

                default:
                    return false;
            }
            return false;
        }

        public tipoUsuario SetTipoUsuario(User usuario)
        {
            switch (usuario._User)
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
                    return tipoUsuario.nulo;
            }
            return tipoUsuario.nulo;

        }

    }
}