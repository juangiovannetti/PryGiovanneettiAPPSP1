using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanneettiAPPSP1
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")

            {
                txtContraseña.Enabled = false;
            }
            else
            {
                txtContraseña.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";

            txtContraseña.Text = "";

            cmbModulo.SelectedIndex = -1;
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModulo.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled= false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                cmbModulo.Enabled = true;
            }
            else 
            {
                cmbModulo.Enabled= false;
                cmbModulo.SelectedIndex = -1;
            }
        }
    }
}
