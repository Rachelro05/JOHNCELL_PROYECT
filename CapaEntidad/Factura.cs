using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {
        public string IDFactura { get; set; }
        public string Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPago { get; set; }
        public Empleado oEmpleado { get; set; }
        public Producto Codigo { get; set; }
        public decimal MontoCambio { get; set; }

        public Cliente oCliente { get; set; }
    }
}
