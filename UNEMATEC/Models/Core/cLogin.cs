using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNEMATEC.Models.BD;
using UNEMATEC.Models.ViewModels;

namespace UNEMATEC.Models.Core
{
    public class cLogin
    {
        public int GetAcceso(mLogin model)
        {
            using (UNEMATECEntities1 ctx = new UNEMATECEntities1())
            {
                try
                {
                    var acces = ctx.Usuarios.Where(p => p.CorreoElectronico == model.Correo && p.Password == model.Password && p.IdEstatus == 1).First();
                    return acces.IdUsuario;
                }
                catch
                {
                    return 0;
                }
            }
        }
    }
}