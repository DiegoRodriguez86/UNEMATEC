using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNEMATEC.Models.Core;
using UNEMATEC.Models.ViewModels;

namespace UNEMATEC.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(mUsuarios model)
        {
            cUsuarios cu = new cUsuarios();
            int error = cu.AddUsuario(model);
            if (error == 0)
            { return RedirectToAction("Index"); }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}