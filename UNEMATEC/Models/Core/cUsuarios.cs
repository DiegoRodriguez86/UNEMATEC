using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNEMATEC.Models.BD;
using UNEMATEC.Models.ViewModels;

namespace UNEMATEC.Models.Core
{
    public class cUsuarios
    {
        public int AddUsuario(mUsuarios model)
        {
            try
            {
                using(UNEMATECEntities1 ctx = new UNEMATECEntities1())
                {

                    Usuarios us = new Usuarios();
                    us.Nombre = model.Nombre.ToUpper();
                    us.ApellidoPaterno = model.ApellidoPaterno.ToUpper();
                    us.ApellidoMaterno = model.ApellidoMaterno.ToUpper();
                    us.CURP = model.CURP;
                    us.RFC = model.RFC;
                    us.CorreoElectronico = model.Correo;
                    us.Password = model.Password;
                    us.TelefonoCelular = model.TelefonoCelular;
                    us.IdEstatus = 1;
                    us.FechaCaptura = DateTime.Now;
                    ctx.Usuarios.Add(us);
                    ctx.SaveChanges();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public Usuarios GetUsuarioById(int IdUsuario)
        {
            using (UNEMATECEntities1 ctx = new UNEMATECEntities1())
            {
                var query = ctx.Usuarios.Where(p => p.IdUsuario == IdUsuario && p.IdEstatus == 1).First();
                return query;
            }
        }
    }
}