using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idempleado)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IDCargo, p.Permitido from Permiso p");
                    query.AppendLine("INNER JOIN Cargo c ON c.IDCargo = p.IDCargo");
                    query.AppendLine("INNER JOIN Empleado e ON e.IDCargo = c.IDCargo");
                    query.AppendLine("where e.IDEmpleado = @idempleado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idempleado", idempleado);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oCargo = new Cargo() { IDCargo = Convert.ToInt32(dr["IDCargo"])},
                                Permitido = dr["Permitido"].ToString(),
                             

                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;
        }
    }
}
