using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;
using CapaNegocio;

namespace JOHNCELL_PROYECT
{
    public partial class Principal : Form
    {

        private static Button ButtonActivo = null;
        private static Form FormularioActivo = null;
        private static Empleado usuarioactual;

        public Principal(Empleado oempleado = null)
        {
                usuarioactual = oempleado;
                InitializeComponent();
             
        }


        private void Principal_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioactual.IDEmpleado);

            foreach (Control control in panel1.Controls)
            {
                // Verificar si el control es un botón
                if (control is Button iconbutton)
                {
                    // Comparar el nombre del botón con los nombres en la lista de permisos
                    bool encontrado = ListaPermisos.Any(m => string.Equals(m.Permitido, iconbutton.Name, StringComparison.OrdinalIgnoreCase));

                    // Ocultar el botón si no está permitido
                    iconbutton.Visible = encontrado;
                }
            }

            user.Text = usuarioactual.Usuario;
        }

        private void AbrirFormulario(Button button, Form formulario) {
            if (ButtonActivo != null) {
                ButtonActivo.BackColor = Color.White;

            }

            button.BackColor = Color.Silver;
            ButtonActivo = button;

            if (FormularioActivo != null) {
                FormularioActivo.Close();

            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
         //   formulario.BackColor = Color.;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void menuCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formCompra());
        }


        private void menuEmpleado_Click(object sender, EventArgs e)
        {

            AbrirFormulario((IconButton)sender, new formEmpleado());
       
        }

        private void submenuSucursal_Click(object sender, EventArgs e)
        {
            /*AbrirFormulario(menuTienda, new formSucursal());*/
        }

        private void menuProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formProveedor());
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formCliente());
        }

        private void menuVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formVenta());
        }

        private void menuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formProductos());
        }

        private void menuEmpleado_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconButton)sender, new formEmpleado());
        }

        private void Titulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuTienda_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new formProveedor());
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new formCompra());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new formProductos());
        }

        private void btnNuevaVenta_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new formVenta());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new formCliente());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Button)sender, new formEmpleado());
        }
    }
    
}
