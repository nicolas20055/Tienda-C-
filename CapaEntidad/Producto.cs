using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IDProducto { get; set; }
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String Descripcion { get; set; }
        public Categoria oCategoria{ get; set; }

        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }
        public bool estado { get; set; }
        public string FechaRegistro { get; set; }
    }

}
