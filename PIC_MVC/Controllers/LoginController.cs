using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PIC_MVC.Models;
using PIC_DATABASE.Models;
using PIC_DATABASE.Repository;


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

            Users user = new UserRepository().Get(loginUser.User, loginUser.Password);

            if (user != null)
            {
                return RedirectToAction("Index", "Home", new { area = "Home", UserType = user.UserType });
            }
            else
            {
                ModelState.AddModelError("", "Usuário ou Senha Incorretos");
            }
            return View("Index");
        }
    }
}
