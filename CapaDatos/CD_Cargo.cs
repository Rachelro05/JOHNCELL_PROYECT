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
    public class CD_Cargo
    {
        public List<Cargo> Listar()
        {
            List<Cargo> lista = new List<Cargo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from Cargo");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cargo()
                            {
                                IDCargo = Convert.ToInt32(dr["IDCargo"]),
                                Tipo = dr["Tipo"].ToString(),


                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Cargo>();
                }
            }

            return lista;
        }
    }
}
