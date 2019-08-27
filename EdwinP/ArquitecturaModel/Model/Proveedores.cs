using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArquitecturaModel.Model
{
    public class Proveedores
    {
        public string ProveedoresId { get; set; }

        [Display(Name = "Nombre ")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Apellido { get; set; }

        [Display(Name = "Cedula")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string  Email { get; set; }

        [Display(Name ="Nombre De La Empresa")]
        public string NombreDelaEmpresa { get; set; }

    }
}
