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
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> Lista = new List<Permiso>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.idRol, p.Menu from Permiso p");
                    query.AppendLine("INNER JOIN Rol r ON r.idRol = p.idRol");
                    query.AppendLine("INNER JOIN Usuario u ON u.idRol = r.idRol");
                    query.AppendLine("WHERE u.idUsuario = @idUsuario");


                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;
                    
                    oconexion.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Permiso()
                            {
                                oRol = new Rol() { idRol = Convert.ToInt32(dr["idRol"]) },
                                Menu = dr["Menu"].ToString(),
                            
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Permiso>();
                }
            }
            return Lista;
        }
    }
}

