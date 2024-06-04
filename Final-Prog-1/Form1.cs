using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Prog_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerDeuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su deuda es de xxxx");
        }

        private void btnPagarDeuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deuda pagada");
        }

        private void brnCargarDeuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuanto quiere cargar de deuda");
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            lblDNI.Visible = true;
            btnAceptar.Visible= true;
            btnCacelar.Visible= true;
            btnAgregar.Visible= false;
            txtContraseña.Visible= true;
            btnPagarDeuda.Visible = true;
            btnVerDeuda.Visible = true;
            btnCargarDeuda.Visible = true;
        }

        private void btnCacelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            lblDNI.Visible = false;
            btnAceptar.Visible = false;
            btnCacelar.Visible = false;
            btnAgregar.Visible = true;
            txtContraseña.Visible = false;
            btnPagarDeuda.Visible = false;
            btnVerDeuda.Visible = false;
            btnCargarDeuda.Visible = false;
        }
    }
}
