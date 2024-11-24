using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace JOHNCELL_PROYECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Empleado> test = new CN_Empleado().Listar();

            Empleado oempleado = new CN_Empleado().Listar().Where(u => u.Usuario == txtUser.Text && u.Contraseña == txtContraseña.Text).FirstOrDefault();
            if (oempleado != null)
            {
                formWelcome welcome = new formWelcome();

                // Suscribir al evento OnWelcomeCompleted para mostrar Principal
                welcome.OnWelcomeCompleted += () =>
                {
                    // Mostrar el formulario principal después de cerrar el formulario de bienvenida
                    Principal formPrincipal = new Principal(oempleado);
                    formPrincipal.Show();
                    formPrincipal.FormClosing += frm_closing; // Suscribir cierre del formulario principal
                };

                // Mostrar el formulario de bienvenida y ocultar el login
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Clear();
                txtContraseña.Clear();

            }

        }

   

        private void frm_closing(object sender, FormClosingEventArgs e) {

            txtUser.Clear();
            txtContraseña.Clear();
            this.Show();
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
