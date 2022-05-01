using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNEMATEC.Models.Core;
using UNEMATEC.Models.ViewModels;

namespace UNEMATEC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(mLogin model)
        {
            cLogin cl = new cLogin();
            int acces = cl.GetAcceso(model);
            if (acces == 1)
            {
                return RedirectToAction("Index", "InfoSindicalizados", new { model = model });
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}