using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> Lista = new List<Categoria>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idCategoria, Descripcion, Estado FROM Categoria");

                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Categoria()
                            {
                                idCategoria = Convert.ToInt32(dr["idCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    Lista = new List<Categoria>();
                }
            }
            return Lista;
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            int idCategoriaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_RegistrarCategoria", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pDescripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("p_Estado", obj.Estado);
                    cmd.Parameters.Add("Resultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idCategoriaGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCategoriaGenerado = 0;
                Mensaje = ex.Message;
            }

            return idCategoriaGenerado;
        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EditarCategoria", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pidCategoria", obj.idCategoria);
                    cmd.Parameters.AddWithValue("pDescripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("p_Estado", obj.Estado);

                    cmd.Parameters.Add("p_respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["p_respuesta"].Value);
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


        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EliminarCategoria", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdCategoria", obj.idCategoria);
                    cmd.Parameters.Add("Resultado", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
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
