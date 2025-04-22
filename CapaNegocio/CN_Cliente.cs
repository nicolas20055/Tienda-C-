using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_Cliente = new CD_Cliente();
        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }
        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario El Documento Del Cliente\n";

            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario El Nombre Completo Del Cliente\n";

            }
            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario El Correo  Del Cliente\n";

            }


            if (Mensaje != String.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validaciones
            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario El Documento Del Cliente\n";
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario El Nombre Completo Del Cliente\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario El Correo  Del Cliente\n";
            }

            // Verificar si hay mensajes de error
            if (Mensaje != String.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }
        }


        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validar que el ID del Cliente sea válido
            if (obj.idCliente <= 0)
            {
                Mensaje = "El ID del Cliente no es válido.";
                return false;
            }

            // Llamar al método de la capa de datos para eliminar el Cliente
            return objcd_Cliente.Eliminar(obj, out Mensaje);
        }
    }
}

