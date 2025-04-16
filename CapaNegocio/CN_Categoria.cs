using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
                Mensaje += "Es necesario ingresar la descripción de la categoría.\n";

            if (Mensaje != string.Empty)
                return 0;

            return objcd_Categoria.Registrar(obj, out Mensaje);
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.idCategoria <= 0)
                Mensaje += "El ID de la categoría no es válido.\n";

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
                Mensaje += "Es necesario ingresar la descripción de la categoría.\n";

            if (Mensaje != string.Empty)
                return false;

            return objcd_Categoria.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.idCategoria <= 0)
            {
                Mensaje = "El ID de la categoría no es válido.";
                return false;
            }

            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
