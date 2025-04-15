using System;

using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using MySql.Data.MySqlClient;
namespace CapaDatos
{
    public class CD_Usuario
    { 
        public List<Usuario> Listar(){
            List<Usuario> Lista = new List<Usuario>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena)){

                try
                {
                    string query = "select idUsuario,Documento,NombreCompleto,Correo,Clave,Estado  from Usuario";

                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
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
                                estado = Convert.ToBoolean(dr["Estado"]),
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
        }
    }

