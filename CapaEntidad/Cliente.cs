using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
