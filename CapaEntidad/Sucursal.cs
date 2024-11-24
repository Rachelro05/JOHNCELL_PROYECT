using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Sucursal
    {
        public int IDSucursal { get; set; }
        public string Nombre { get; set; }

        public Tienda oTienda { get; set; }

        public string Direccion { get; set; }

    }
}
