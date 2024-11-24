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
    public class CD_Sucursal
    {
        public List<Sucursal> Listar()
        {
            List<Sucursal> lista = new List<Sucursal>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IDSucursal, Nombre from Sucursal");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Sucursal()
                            {
                                IDSucursal = Convert.ToInt32(dr["IDSucursal"]),
                                Nombre = dr["Nombre"].ToString(),


                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Sucursal>();
                }
            }

            return lista;
        }
    }
}
