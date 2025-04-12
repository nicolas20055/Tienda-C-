using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_venta
    {
        public int IdDetalle_venta { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public String FechaRegistro { get; set; }
        
    }
}
