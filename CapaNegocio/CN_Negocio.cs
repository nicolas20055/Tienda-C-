using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Nombre))
                Mensaje += "Es necesario el nombre del negocio\n";

            if (string.IsNullOrWhiteSpace(obj.Rut))
                Mensaje += "Es necesario el número de RUT\n";

            if (string.IsNullOrWhiteSpace(obj.Direccion))
                Mensaje += "Es necesaria la dirección\n";

            return Mensaje == string.Empty && objcd_Negocio.GuardarDatos(obj, out Mensaje);
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_Negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objcd_Negocio.ActualizarLogo(imagen, out mensaje);
        }
    }
}


