﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string clave  { get; set; }
        public Rol oRol { get; set; }
        public bool estado { get; set; }
        public string FechaRegistro { get; set; }

    }
}
