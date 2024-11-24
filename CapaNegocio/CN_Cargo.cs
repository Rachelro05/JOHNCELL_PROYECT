using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cargo
    {
        private CD_Cargo ocd_cargo = new CD_Cargo();

        public List<Cargo> Listar()
        {
            return ocd_cargo.Listar();
        }
    }
}
