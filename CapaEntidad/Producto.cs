using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }
        public string Memoria { get; set; }
        public string RAM { get; set; }
        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }
    }
}
