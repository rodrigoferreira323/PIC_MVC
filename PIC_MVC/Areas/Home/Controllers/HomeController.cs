using PIC_MVC.Models;
using PIC_MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIC_MVC.Areas.Home.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/Home/

        public ActionResult Index(string username, string password)
        {
            User user = new UserRepository().GetUser(username, password);

            return View(user);
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}
