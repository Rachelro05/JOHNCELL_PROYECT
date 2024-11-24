using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
        private string Cadena = "Data Source=(local);Initial Catalog=JOHNCELL;Integrated Security=True";
        public SqlConnection C
    }
}
