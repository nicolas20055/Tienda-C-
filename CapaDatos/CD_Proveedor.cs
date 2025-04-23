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
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> Lista = new List<Proveedor>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idProveedor,Documento,RazonSocial,Correo,Telefono,Estado from Proveedor;");


                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            Lista.Add(new Proveedor()
                            {
                                idProveedor = Convert.ToInt32(dr["idProveedor"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),



                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Proveedor>();
                    Console.WriteLine("Error al listar proveedores: " + ex.Message);
                }


            }
            return Lista;
        }


        public int Registrar(Proveedor obj, out string Mensaje)
        {
            int idProveedorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_RegistrarProveedor", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pDocumento", obj.Documento);
                    cmd.Parameters.AddWithValue("pRazonSocial", obj.RazonSocial);
                    cmd.Parameters.AddWithValue("pCorreo", obj.Correo);
                    cmd.Parameters.AddWithValue("pTelefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("pResultado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("pMensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("pRespuesta", MySqlDbType.Int32).Direction = ParameterDirection.Output;


                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["pResultado"].Value);
                    Mensaje = cmd.Parameters["pMensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                Mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }


        public bool Editar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EditarProveedor", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdProveedor", obj.idProveedor);
                    cmd.Parameters.AddWithValue("pDocumento", obj.Documento);
                    cmd.Parameters.AddWithValue("pRazonSocial", obj.RazonSocial);
                    cmd.Parameters.AddWithValue("pCorreo", obj.Correo);
                    cmd.Parameters.AddWithValue("pTelefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("pRespuesta", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("pResultado", MySqlDbType.Bit).Direction = ParameterDirection.Output;
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

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EliminarProveedor", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdProveedor", obj.idProveedor);
                    cmd.Parameters.Add("pRespuesta", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("pResultado", MySqlDbType.Bit).Direction = ParameterDirection.Output;
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



    }
}

