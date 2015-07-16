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
            return View(new LoginUser());
        }

        [HttpPost]
        public ActionResult Index(LoginUser loginUser)
        {
            if (loginUser == null || !ModelState.IsValid)
            {
                ModelState.AddModelError("", "Usuário ou Senha Incorretos");
                return View("Index");
            }

            User user = new UserRepository().GetUser(loginUser.User, loginUser.Password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home", new { area = "Home", tipoUsuario = user.tipoUsuario });
            }
            else
            {
                ModelState.AddModelError("", "Usuário ou Senha Incorretos");
            }
            return View("Index");
        }
    }
}
