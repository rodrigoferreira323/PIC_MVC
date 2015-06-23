using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIC_MVC.Repository
{
    public class UserRepository
    {
        public bool UserVerification(string User, string password)
        {
            switch (User)
            {
                case "administrador":
                    if (password == "vt4001adm")
                    {
                        return true;
                    }
                    break;

                case "desenvolvedor":
                    if (password == "vstudioPICmvc")
                    {
                        return true;
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