using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int IDProveedor {  get; set; }

        public String Documento { get; set; }

        public String RazonSocial { get; set; }
        public String Correo { get; set; }

        public String Telefono { get; set; }
        public bool estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
