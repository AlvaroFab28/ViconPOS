using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViconPOS.Core.Interfaces.Services;
using ViconPOS.Core.Models;
using ViconPOS.Modules.Login.View;

namespace ViconPOS.UI
{
    public partial class MainMenuForm : Form
    {
        ILoginView vistaLogin;
        IAuthService autenticacionServicio;
        private bool colapsando = false;
        private int anchoColapsado = 65;
        private int anchoExpandido = 189;


        public MainMenuForm(IAuthService usuarioLogeado, ILoginView view)
        {

            InitializeComponent();
            SidePanel.Height = btnDashboard.Height;
            SidePanel.Top = btnDashboard.Top;
            lblUsuario.Text = usuarioLogeado.ObtenerUsuarioActivo().Username;
            autenticacionServicio = usuarioLogeado;
            vistaLogin = view;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnDashboard);

        }

        private void btnPuntoDeVenta_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnPuntoDeVenta);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnInventario);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnCompras);
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnFinanzas);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            MoverSidePanel(btnConfiguracion);
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        #region // Metodos de Efectos visuales
        private void MoverSidePanel(Control boton)
        {
            SidePanel.Height = boton.Height;
            SidePanel.Top = boton.Top;
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            colapsando = panelLateral.Width == anchoExpandido;
            timerSidebar.Start();
        }
        #endregion

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (colapsando)
            {
                panelLateral.Width -= 10;
                if (panelLateral.Width <= anchoColapsado)
                {
                    timerSidebar.Stop();
                    panelLateral.Width = anchoColapsado;

                    pBLogo.Size = new Size(66, 66);
                    pBLogo.Location = new Point(0, 33);
                    btnToggleSidebar.IconColor = Color.OrangeRed;
                    // OcultarTextosMenu();

                }
            }
            else
            {
                panelLateral.Width += 10;
                if (panelLateral.Width >= anchoExpandido)
                {
                    timerSidebar.Stop();
                    panelLateral.Width = anchoExpandido;
                    pBLogo.Size = new Size(120, 120);
                    pBLogo.Location = new Point(36, 3);
                    btnToggleSidebar.IconColor = Color.DarkGray;
                    // MostrarTextosMenu();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            vistaLogin.Mostrar();             // Mostrár login limpio
            autenticacionServicio.CerrarSesion(); // Limpiár estado interno
            Close();                          // Cerrár MainMenuForm
        }
    }
}
