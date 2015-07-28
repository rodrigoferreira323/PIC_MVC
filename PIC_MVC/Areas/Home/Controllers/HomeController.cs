using PIC_DATABASE.Models.Enum;
using PIC_MVC.Models;
using PIC_DATABASE.Models.Enum;
using PIC_DATABASE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PIC_MVC.Areas.Home.Models;
using PIC_DATABASE.Models;

namespace PIC_MVC.Areas.Home.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/Home/
        [HttpGet]
        public ActionResult Index(UserType UserType)
        {
            return View(UserType);
        }

        [HttpGet]
        public ActionResult Compra(UserType UserType)
        {
            return View(UserType);
        }

        [HttpGet]
        public ActionResult Retirada(UserType UserType)
        {
            return View(UserType);
        }

        [HttpGet]
        public ActionResult Relatorios(UserType UserType)
        {
            return View(UserType);
        }

        [HttpGet]
        public ActionResult Add_pedido(UserType UserType)
        {
            return View(UserType);
        }

        [HttpGet]
        public ActionResult Usuario(UserType UserType)
        {
            return View(UserType);
        }

        [HttpGet]
        public ActionResult Add_usuario(UserType UserType)
        {
            if (UserType != UserType.Desenvolvedor)
            {
                return View("Index", UserType);
            }
            return View(new UserViewModel()
            {
                UserDev = UserType
            });
        }

        [HttpPost]
        public ActionResult Add_usuario(UserViewModel UserViewModel)
        {
            Users User = new Users();

            UserRepository UserRepository = new UserRepository();

            if (ModelState.IsValid)
            {
                User.Active = UserViewModel.Active;
                User.Departament = UserViewModel.Departament;
                User.Email = UserViewModel.Email;
                User.Job = UserViewModel.Job;
                User.Name = UserViewModel.Name;
                User.Password = UserViewModel.Password;
                User.Username = UserViewModel.Username;
                User.UserType = UserViewModel.UserType;
                User.RegisterDate = DateTime.Now;
                User.Token = "123";
                User.IP = "123";

                UserRepository.Add(User);

                return View("Index", UserViewModel.UserDev);
            }
                return View(UserViewModel);

        }

    }
}
