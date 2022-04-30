using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UNEMATEC.Models.ViewModels
{
    public class mUsuarios
    {
        [Required(ErrorMessage = "{0} es campo requerido")]
        [Display(Name = "Nombre:")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido paterno:")]
        public string ApellidoPaterno { get; set; }
        [Display(Name = "Apellido materno:")]
        public string ApellidoMaterno { get; set; }
        [Required(ErrorMessage = "{0} es campo requerido")]
        [Display(Name = "Correo electronico:")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "{0} es campo requerido")]
        [Display(Name = "Contraseña:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "{0} es campo requerido")]
        [Display(Name = "RFC:")]
        public string RFC { get; set; }
        [Required(ErrorMessage = "{0} es campo requerido")]
        [Display(Name = "CURP:")]
        public string CURP { get; set; }
        [Required(ErrorMessage = "{0} es campo requerido")]
        [Display(Name = "Telefono celular:")]
        public string TelefonoCelular { get; set; }
        
    }
}