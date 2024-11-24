using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<Empleado> Listar()
        {
            List<Empleado> lista = new List<Empleado>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select IDEmpleado, Nombre, Apellido, Contraseña, Usuario from Empleado";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empleado()
                            {
                                IDEmpleado = Convert.ToInt32(dr["IDEmpleado"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Contraseña = dr["Contraseña"].ToString(),
                                Usuario = dr["Usuario"].ToString()

                            });

                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Empleado>();
                }
            }

            return lista;
        }
    }
}
