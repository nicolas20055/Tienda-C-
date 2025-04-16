using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IDCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public String TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> oDetalle_compra{ get; set; }
        public string FechaRegistro { get; set; }
    }
}
