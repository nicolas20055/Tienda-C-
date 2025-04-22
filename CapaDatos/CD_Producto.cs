using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                using (MySqlConnection oConexion = new MySqlConnection(Conexion.cadena))
                {
                    string query = @"SELECT
                                        p.idProducto,
                                        p.Codigo,
                                        p.Nombre,
                                        p.Descripcion,
                                        p.idCategoria,
                                        c.Descripcion AS DescripcionCategoria,
                                        p.Stock,
                                        p.PrecioCompra,
                                        p.PrecioVenta,
                                        p.Estado
                                     FROM Producto p
                                     INNER JOIN Categoria c ON c.idCategoria = p.idCategoria";

                    MySqlCommand cmd = new MySqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                idProducto = dr["idProducto"] != DBNull.Value ? Convert.ToInt32(dr["idProducto"]) : 0,
                                Codigo = dr["Codigo"] != DBNull.Value ? dr["Codigo"].ToString() : string.Empty,
                                Nombre = dr["Nombre"] != DBNull.Value ? dr["Nombre"].ToString() : string.Empty,
                                Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty,
                                oCategoria = new Categoria()
                                {
                                    idCategoria = dr["idCategoria"] != DBNull.Value ? Convert.ToInt32(dr["idCategoria"]) : 0,
                                    Descripcion = dr["DescripcionCategoria"] != DBNull.Value ? dr["DescripcionCategoria"].ToString() : string.Empty
                                },
                                Stock = dr["Stock"] != DBNull.Value ? Convert.ToInt32(dr["Stock"]) : 0,
                                PrecioCompra = dr["PrecioCompra"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioCompra"]) : 0,
                                PrecioVenta = dr["PrecioVenta"] != DBNull.Value ? Convert.ToDecimal(dr["PrecioVenta"]) : 0,
                                Estado = dr["Estado"] != DBNull.Value ? Convert.ToBoolean(dr["Estado"]) : false
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar productos: {ex.Message}");
                lista = new List<Producto>();
            }

            return lista;
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            int idProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oConexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_RegistrarProducto", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pCodigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("pNombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("pDescripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("pIdCategoria", obj.oCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("pStock", obj.Stock);
                    cmd.Parameters.AddWithValue("pPrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("pPrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("pEstado", obj.Estado);

                    MySqlParameter pResultado = new MySqlParameter("pResultado", MySqlDbType.Int32);
                    pResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pResultado);

                    MySqlParameter pMensaje = new MySqlParameter("pMensaje", MySqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pMensaje);

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    idProductoGenerado = Convert.ToInt32(pResultado.Value);
                    Mensaje = pMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                Mensaje = ex.Message;
            }

            return idProductoGenerado;
        }

        public bool Editar(Producto obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oConexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EditarProducto", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdProducto", obj.idProducto);
                    cmd.Parameters.AddWithValue("pCodigo", obj.Codigo);
                    cmd.Parameters.AddWithValue("pNombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("pDescripcion", obj.Descripcion);
                    cmd.Parameters.AddWithValue("pIdCategoria", obj.oCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("pStock", obj.Stock);
                    cmd.Parameters.AddWithValue("pPrecioCompra", obj.PrecioCompra);
                    cmd.Parameters.AddWithValue("pPrecioVenta", obj.PrecioVenta);
                    cmd.Parameters.AddWithValue("pEstado", obj.Estado);

                    MySqlParameter pResultado = new MySqlParameter("pResultado", MySqlDbType.Bit);
                    pResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pResultado);

                    MySqlParameter pMensaje = new MySqlParameter("pMensaje", MySqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pMensaje);

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(pResultado.Value);
                    Mensaje = pMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }

            return resultado;
        }

        public bool Eliminar(Producto obj, out string Mensaje)
        {
            bool resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (MySqlConnection oConexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_EliminarProducto", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pIdProducto", obj.idProducto);

                    MySqlParameter pRespuesta = new MySqlParameter("pRespuesta", MySqlDbType.Bit);
                    pRespuesta.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pRespuesta);

                    MySqlParameter pMensaje = new MySqlParameter("pMensaje", MySqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pMensaje);

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(pRespuesta.Value);
                    Mensaje = pMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                Mensaje = ex.Message;
            }

            return resultado;
        }
    }
}
