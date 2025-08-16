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
        public event Action<bool> MostrarPasswordCambio = delegate { };

        public LoginForm()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
            // Wireo de eventos de UI → ILoginView
            btnIngresar.Click += (_, __) => IngresarClick();
            chkMostrar.CheckedChanged += (_, __) => MostrarPasswordCambio(chkMostrar.Checked);
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

        // Maneja el cambio de visibilidad de la contraseña (llamado por LoginPresenter)
        public void CambiarVisibilidadPassword(bool mostrar)
        {
            txtContraseña.UseSystemPasswordChar = !mostrar;
        }
    }
}
