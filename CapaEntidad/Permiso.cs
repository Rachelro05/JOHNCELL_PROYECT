using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int IDPermiso { get; set; }
        public string Permitido { get; set; }
        public Cargo oCargo { get; set; }
    }
}
