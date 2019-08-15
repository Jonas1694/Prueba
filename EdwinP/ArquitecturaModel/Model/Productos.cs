using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArquitecturaModel.Model
{
    public class Productos
    {
        public string ProductosId { get; set; }
        public string ProveedoresId { get; set; }
        [Display(Name = "Proveedor")]
        public Proveedores Proveedores { get; set; }

        [Display(Name = "Codigo Del Producto")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre Del Producto")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string NombreDelProducto { get; set; }

        [Display(Name = "Cantidad Del Producto")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string CantidadDelProducto { get; set; }
         

    }
}
