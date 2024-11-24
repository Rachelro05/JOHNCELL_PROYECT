using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Sucursal
    {
        private CD_Sucursal ocd_sucursal = new CD_Sucursal();

        public List<Sucursal> Listar()
        {
            return ocd_sucursal.Listar();
        }
    }
}