using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIC_MVC.Repository
{
    public class UserRepository
    {
        public Enum UserVerification(string User, string password)
        {
            switch (User)
            {
                case "administrador":
                    if (password == "vt4001adm")
                    {
                        return administrador;
                    }
                    break;

                case "operador":
                    if (password == "opvt40tt")
                    {
                        return operador;
                    }
                    break;

                case "desenvolvedor":
                    if (password == "vstudioPICmvc")
                    {
                        return desenvolvedor;
                    }
                    break;

                case "visiontec":
                    if (password == "visiontec123")
                    {
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