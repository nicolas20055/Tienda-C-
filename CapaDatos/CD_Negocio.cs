using System;
using System.Data;
using MySql.Data.MySqlClient;
using CapaEntidad;
using System.Text;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT idNegocio, Nombre, Rut, Direccion FROM Negocio WHERE idNegocio = 1";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj.idNegocio = int.Parse(dr["idNegocio"].ToString());
                            obj.Nombre = dr["Nombre"].ToString();
                            obj.Rut = dr["Rut"].ToString();
                            obj.Direccion = dr["Direccion"].ToString();
                        }
                    }
                }
            }
            catch
            {
                obj = new Negocio();
            }

            return obj;
        }

        public bool GuardarDatos(Negocio objeto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Negocio SET");
                    query.AppendLine("Nombre = @nombre,");
                    query.AppendLine("Rut = @rut,");
                    query.AppendLine("Direccion = @direccion");
                    query.AppendLine("WHERE idNegocio = 1;");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@rut", objeto.Rut);
                    cmd.Parameters.AddWithValue("@direccion", objeto.Direccion);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;
                    mensaje = respuesta ? "Datos guardados correctamente." : "No se pudo guardar el negocio.";
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] logoBytes = new byte[0];

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT Logo FROM Negocio WHERE idNegocio = 1";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read() && dr["Logo"] != DBNull.Value)
                        {
                            logoBytes = (byte[])dr["Logo"];
                        }
                        else
                        {
                            obtenido = false;
                        }
                    }
                }
            }
            catch
            {
                obtenido = false;
            }

            return logoBytes;
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Negocio SET Logo = @imagen WHERE idNegocio = 1";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@imagen", imagen);

                    resultado = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            return resultado;
        }
    }
}

