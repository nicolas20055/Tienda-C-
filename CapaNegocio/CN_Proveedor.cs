using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
            private CD_Proveedor objcd_Proveedor = new CD_Proveedor();
            public List<Proveedor> Listar()
            {
                return objcd_Proveedor.Listar();
            }
            public int Registrar(Proveedor obj, out string Mensaje)
            {
                Mensaje = string.Empty;
                if (obj.Documento == "")
                {
                    Mensaje += "Es Necesario El Documento Del Proveedor\n";

                }
                if (obj.RazonSocial == "")
                {
                    Mensaje += "Es Necesario La Razon Social Del Proveedor\n";

                }
                if (obj.Correo == "")
                {
                    Mensaje += "Es Necesario El Correo  Del Proveedor\n";

                }

                if (Mensaje != String.Empty)
                {
                    return 0;
                }
                else
                {
                    return objcd_Proveedor.Registrar(obj, out Mensaje);
                }
            }
            public bool Editar(Proveedor obj, out string Mensaje)
            {
                Mensaje = string.Empty;
            if (obj.Documento == "")
            {
                Mensaje += "Es Necesario El Documento Del Proveedor\n";

            }
            if (obj.RazonSocial == "")
            {
                Mensaje += "Es Necesario La Razon Social Del Proveedor\n";

            }
            if (obj.Correo == "")
            {
                Mensaje += "Es Necesario El Correo  Del Proveedor\n";

            }


            if (Mensaje != String.Empty)
                {
                    return false;
                }
                else
                {
                    return objcd_Proveedor.Editar(obj, out Mensaje);

                }
            }
            public bool Eliminar(Proveedor obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                // Validar que el ID del Proveedor sea válido
                if (obj.idProveedor <= 0)
                {
                    Mensaje = "El ID del Proveedor no es válido.";
                    return false;
                }

                // Llamar al método de la capa de datos para eliminar el Proveedor
                return objcd_Proveedor.Eliminar(obj, out Mensaje);
            }
        }
    }

