using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Negocio
    {
        public int idNegocio { get; set; }
        public String Nombre { get; set; }
        public String Rut { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
