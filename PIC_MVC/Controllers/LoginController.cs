using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PIC_MVC.Models;
using PIC_MVC.Repository;

namespace PIC_MVC.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/LP Gonçalves

        public ActionResult Index()
        {
            User usuario = new User();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Index(User usuario)
        {
            if (usuario == null)
            {
                ModelState.AddModelError("", "Usuário ou Senha Incorretos");
                return View("Index");
            }

            if (new UserRepository().UserVerification(usuario._user, usuario.Password))
            {
                return RedirectToAction("Index", "Home", new { area = "Home" });
            }
            else
            {
                ModelState.AddModelError("", "Usuário ou Senha Incorretos");
            }
            return View("Index");
        }


    }
}
