using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using JOHNCELL_PROYECT.Utilidades;

namespace JOHNCELL_PROYECT
{
    public partial class formEmpleado : Form
    {
        public formEmpleado()
        {
            InitializeComponent();
        }

        private void gbTitulo_Enter(object sender, EventArgs e)
        {

        }

        private void formEmpleado_Load(object sender, EventArgs e)
        {
            List<Cargo> listaCargo = new CN_Cargo().Listar();
       
            foreach (Cargo item in listaCargo)
            {
                cbCargo.Items.Add(new OpcionCombo() { Valor = item.IDCargo, Texto = item.Tipo });

            }
            cbCargo.DisplayMember = "Texto";
            cbCargo.ValueMember = "Valor";
            cbCargo.SelectedIndex = 0;


            List<Sucursal> listaSucursal = new CN_Sucursal().Listar();
            foreach (Sucursal item in listaSucursal)
            {
                cbSucursal.Items.Add(new OpcionCombo() { Valor = item.IDSucursal, Texto = item.Nombre });

            }
            cbSucursal.DisplayMember = "Texto";
            cbSucursal.ValueMember = "Valor";
            cbSucursal.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dtEmpleado.Columns) {
                if (columna.Visible == true)
                {
                    cbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dtEmpleado.Rows.Add(new object[] {"", txtIDEmpleado.Text,txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtClave.Text,
                ((OpcionCombo)cbCargo.SelectedItem).Valor.ToString(), 
                ((OpcionCombo)cbCargo.SelectedItem).Texto,
                ((OpcionCombo)cbSucursal.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbSucursal.SelectedItem).Texto,

            });
            Limpiar();
        }

        private void Limpiar() {
            txtIDEmpleado.Text = "0";
            txtNombre.Text = ""; 
            txtApellido.Text ="";
            txtUsuario.Text = "";
            txtClave.Text = "";
            cbCargo.SelectedIndex = 0;
            cbSucursal.SelectedIndex = 0;

        }
    }
}
