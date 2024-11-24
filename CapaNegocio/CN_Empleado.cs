using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleado ocd_empleado = new CD_Empleado();

        public List<Empleado> Listar()
        {
            return ocd_empleado.Listar();
        }
    }
}
