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
        public void Index(mUsuarios model)
        {
            cUsuarios cu = new cUsuarios();
            int error = cu.AddUsuario(model);
        }
    }
}