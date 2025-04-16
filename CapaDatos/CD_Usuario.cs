using System;

using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CapaDatos
{
    public class CD_Usuario
    { 
        public List<Usuario> Listar(){
            List<Usuario> Lista = new List<Usuario>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena)){

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT\r\n    u.idUsuario,\r\n    u.Documento,\r\n    u.NombreCompleto,\r\n    u.Correo,\r\n    u.Clave,\r\n    u.Estado,\r\n    r.idRol,\r\n    r.Descripcion\r\nFROM Usuario u");
                    query.AppendLine("INNER JOIN Rol r ON r.idRol = u.idRol");
   

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]), Descripcion = dr["Descripcion"].ToString() }
                                

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Usuario>();
                }
                  
                }
            return Lista;
        }


        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_RegistrarUsuario", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("p_NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("p_Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("p_Clave", obj.clave);
                    cmd.Parameters.AddWithValue("p_idRol", obj.oRol.idRol);
                    cmd.Parameters.AddWithValue("p_Estado", obj.Estado);
                    cmd.Parameters.Add("p_idUsuarioResultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["p_idUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["p_mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }


        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EditarUsuario", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_idUsuario", obj.idUsuario);
                    cmd.Parameters.AddWithValue("p_Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("p_NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("p_Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("p_Clave", obj.clave);
                    cmd.Parameters.AddWithValue("p_idRol", obj.oRol.idRol);
                    cmd.Parameters.AddWithValue("p_Estado", obj.Estado);

                    cmd.Parameters.Add("Respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["p_mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EliminarUsuario", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("p_idUsuario", obj.idUsuario);
                    cmd.Parameters.Add("Respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["p_mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }



    }
}

