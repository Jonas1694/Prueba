using System;
using System.Collections.Generic;
using System.Text;

namespace ArquitecturaModel.Model
{
    public class Productos
    {
        public string ProductosId { get; set; }
        public string ProveedoresId { get; set; }
        public Proveedores Proveedores { get; set; }
        public string Codigo { get; set; }
        public string NombreDelProducto { get; set; }
        public string CantidadDelProducto { get; set; }
         

    }
}
