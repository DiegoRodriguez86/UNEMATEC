using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNEMATEC.Models.Core;

namespace UNEMATEC.Controllers
{
    public class InfoSindicalizadosController : Controller
    {
        // GET: InfoSindicalizados
        public ActionResult Index()
        {
            int IdUsuario = int.Parse(Session["sIdUsuario"].ToString());
            cUsuarios cu = new cUsuarios();
            var InfoUsuario = cu.GetUsuarioById(IdUsuario);
            cHistorialPagos chp = new cHistorialPagos();
            var Historial = chp.GetHistorialPago(InfoUsuario.IdSuscripcionPayPal);
            return View();
        }

        public ActionResult TablaPagos()
        {
            return View();
        }
    }
}