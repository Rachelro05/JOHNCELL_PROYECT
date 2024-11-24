using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public string IDCompra { get; set; }
        public string Fecha { get; set; }
        public int Total { get; set; }
        public decimal MontoTotal { get; set; }
        public Proveedor oProveedor { get; set; }
        public Producto Codigo { get; set; }
        public Tienda oTienda { get; set; }
    }
}
