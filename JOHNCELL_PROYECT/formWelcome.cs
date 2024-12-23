﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace JOHNCELL_PROYECT
{
    public partial class formWelcome : Form
    {

        public event Action OnWelcomeCompleted;


        public formWelcome(Empleado oempleado = null)
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 5;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
                OnWelcomeCompleted?.Invoke();
            }
        }

        private void formWelcomecs_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
