using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento  == "")
            {
                Mensaje += "Es Necesario El Documento Del Usuario\n";
                
            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario El Nombre Completo Del Usuario\n";

            }
            if (obj.clave == "")
            {
                Mensaje += "Es Necesario La Clave  Del Usuario\n";

            }

            if (Mensaje != String.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario El Documento Del Usuario\n";

            }
            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es Necesario El Nombre Completo Del Usuario\n";

            }
            if (obj.clave == "")
            {
                Mensaje += "Es Necesario La Clave  Del Usuario\n";

            }

            if (Mensaje != String.Empty)
            {
                return false;
            }
            else
            {
            return objcd_usuario.Editar(obj, out Mensaje);
                
            }
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validar que el ID del usuario sea válido
            if (obj.idUsuario <= 0)
            {
                Mensaje = "El ID del usuario no es válido.";
                return false;
            }

            // Llamar al método de la capa de datos para eliminar el usuario
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
