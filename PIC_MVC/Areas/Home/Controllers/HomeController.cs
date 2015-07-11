using PIC_MVC.Models;
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

        public ActionResult Index(User usuario)
        {
            return View(usuario);
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}
