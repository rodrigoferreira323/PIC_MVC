using PIC_MVC.Models;
using PIC_MVC.Models.Enum;
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

        public ActionResult Index(tipoUsuario tipoUsuario)
        {
            return View(tipoUsuario);
        }
        public ActionResult Compra(tipoUsuario tipoUsuario)
        {
            return View(tipoUsuario);
        }
        public ActionResult Retirada(tipoUsuario tipoUsuario)
        {
            return View(tipoUsuario);
        }
        public ActionResult Relatorios(tipoUsuario tipoUsuario)
        {
            return View(tipoUsuario);
        }
        public ActionResult Add_pedido(tipoUsuario tipoUsuario)
        {
            return View(tipoUsuario);
        }

    }
}
