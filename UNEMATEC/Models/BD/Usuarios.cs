//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNEMATEC.Models.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string TelefonoCelular { get; set; }
        public int IdEstatus { get; set; }
        public System.DateTime FechaCaptura { get; set; }
        public string IdSuscripcionPayPal { get; set; }
    }
}
