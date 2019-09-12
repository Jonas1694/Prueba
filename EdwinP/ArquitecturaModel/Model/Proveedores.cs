using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArquitecturaModel.Model
{
    public class Proveedores
    {
        public string ProveedoresId { get; set; }

        [Display(Name = "Razon Social  ")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Display(Name = "Cedula / Rif")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Cedula { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage ="Este Campo Es Obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage ="Este Campo Es Obligatorio")]
        public string  Email { get; set; }

        [Display(Name ="Contacto")]
        [Required(ErrorMessage ="Este Campo Es Obligatorio")]
        public string NombreDelaEmpresa { get; set; }

    }
}
