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
                using(UNEMATECEntities ctx = new UNEMATECEntities())
                {

                    Usuarios us = new Usuarios();
                    us.Nombre = model.Nombre;
                    us.ApellidoPaterno = model.ApellidoPaterno;
                    us.ApellidoPaterno = model.ApellidoPaterno;
                    us.CURP = model.CURP;
                    us.RFC = model.RFC;
                    us.CorreoElectronico = model.Correo;
                    us.Password = model.Password;
                    us.TelefonoCelular = model.TelefonoCelular;
                    us.IdEstatus = 1;
                    us.FechaCaptura = DateTime.Now;
                    ctx.SaveChanges();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}