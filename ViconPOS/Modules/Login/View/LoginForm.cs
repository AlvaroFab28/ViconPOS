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
    public partial class LoginForm : Form, ILoginView
    {
        // Eventos que escuchará el Presenter
        public event Action IngresarClick = delegate { };

        public LoginForm()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
            // Wireo de eventos de UI → ILoginView
            btnIngresar.Click += (_, __) => IngresarClick();

        }

        // Datos expuestos al Presenter
        public string Usuario => txtUsuario.Text.Trim();
        public string Contraseña => txtContraseña.Text;

        // Métodos de la interfaz
        public void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }

        public void LimpiarError()
        {
            lblError.Text = string.Empty;
        }

        public void Cerrar()
        {
            Close();
        }
        public void Ocultar()
        {
            Hide();
        }
        public void Mostrar()
        {
            limpiarCampos();
            BeginInvoke(new Action(() => ActiveControl = btnDummyFocus));

            Show();
        }
        public void limpiarCampos()
        {
            txtContraseña.Text = string.Empty;
            lblError.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }
        // Evento que se dispara cuando el usuario cambia el estado del checkbox "Mostrar contraseña"
        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        // 🧠 Este método se dispara *antes* del KeyDown tradicional
        private void txtUsuario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick(); // Disparás el ingreso como si hicieras clic
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                return true; // Suprime por completo el Enter si queda colgado
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private Button btnDummyFocus = new Button
        {
            Visible = false,
            TabStop = false,
            Enabled = false
        };


        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(btnDummyFocus); // Solo la primera vez
            this.ActiveControl = btnDummyFocus;
        }
    }
}
