using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();
        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }
        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Codigo == "")
            {
                Mensaje += "Es Necesario El Codigo Del Producto\n";

            }
            if (obj.Nombre == "")
            {
                Mensaje += "Es Necesario El Nombre Del Producto\n";

            }
            if (obj.Descripcion == "")
            {
                Mensaje += "Es Necesario La Descripcion  Del Producto\n";

            }

            if (Mensaje != String.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Codigo == "")
            {
                Mensaje += "Es Necesario El Codigo Del Producto\n";

            }
            if (obj.Nombre == "")
            {
                Mensaje += "Es Necesario El Nombre Del Producto\n";

            }
            if (obj.Descripcion == "")
            {
                Mensaje += "Es Necesario La Descripcion  Del Producto\n";

            }

            if (Mensaje != String.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Validar que el ID del Producto sea válido
            if (obj.idProducto <= 0)
            {
                Mensaje = "El ID del Producto no es válido.";
                return false;
            }

            // Llamar al método de la capa de datos para eliminar el Producto
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }
    }
}

