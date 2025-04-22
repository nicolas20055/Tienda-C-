using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> Lista = new List<Cliente>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("    \r\nselect idCliente,Documento,NombreCompleto,Correo,Telefono,Estado from Cliente;");



                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Cliente()
                            {
                                idCliente = Convert.ToInt32(dr["idCliente"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                


                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Cliente>();
                }

            }
            return Lista;
        }


        public int Registrar(Cliente obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_RegistrarCliente", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pDocumento", obj.Documento);
                    cmd.Parameters.AddWithValue("pNombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("pCorreo", obj.Correo);
                    cmd.Parameters.AddWithValue("pTelefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("pEstado", obj.Estado);
                    cmd.Parameters.Add("pResultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("pMensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["pResultado"].Value);
                    Mensaje = cmd.Parameters["pMensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }

            return idClienteGenerado;
        }


        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EditarCliente", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdCliente", obj.idCliente);
                    cmd.Parameters.AddWithValue("pDocumento", obj.Documento);
                    cmd.Parameters.AddWithValue("pNombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("pCorreo", obj.Correo);
                    cmd.Parameters.AddWithValue("pTelefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("pEstado", obj.Estado);
                    cmd.Parameters.AddWithValue("pResultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("pMensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["pResultado"].Value);
                    Mensaje = cmd.Parameters["pMensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("delete from Cliente where idCliente=@idCliente", oconexion);
                    cmd.Parameters.AddWithValue("@idCliente", obj.idCliente);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;


                    //MySqlCommand cmd = new MySqlCommand("sp_EliminarCliente", oconexion);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.AddWithValue("pIdCliente", obj.idCliente);
                    //cmd.Parameters.Add("pRespuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    //cmd.Parameters.Add("pMensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    //oconexion.Open();
                    //cmd.ExecuteNonQuery();

                    //respuesta = Convert.ToBoolean(cmd.Parameters["pRespuesta"].Value);
                    //Mensaje = cmd.Parameters["pMensaje"].Value.ToString();
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

