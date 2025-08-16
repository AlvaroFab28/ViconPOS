using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViconPOS.Modules.Login.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {

            // Cambia la propiedad UseSystemPasswordChar del TextBox de contraseña
            // txtContraseña.UseSystemPasswordChar es una propiedad que determina si el TextBox muestra los caracteres como asteriscos o no.
            // y con !chkMostrar.Checked se invierte el valor de la propiedad.
            txtContraseña.UseSystemPasswordChar = !chkMostrar.Checked;

        }
    }
}
