namespace ViconPOS.UI
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            lblRolUsuario = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lblUsuario = new Label();
            panelLateral = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            SidePanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            btnConfiguracion = new FontAwesome.Sharp.IconButton();
            btnFinanzas = new FontAwesome.Sharp.IconButton();
            btnCompras = new FontAwesome.Sharp.IconButton();
            pBLogo = new PictureBox();
            btnInventario = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            btnPuntoDeVenta = new FontAwesome.Sharp.IconButton();
            btnToggleSidebar = new FontAwesome.Sharp.IconPictureBox();
            parrotSlidingPanel1 = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            panel1 = new Panel();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            panelContenedor = new Panel();
            timerSidebar = new System.Windows.Forms.Timer(components);
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleSidebar).BeginInit();
            parrotGradientPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.Transparent;
            lblRolUsuario.Font = new Font("Segoe UI", 10.2F);
            lblRolUsuario.ForeColor = Color.DimGray;
            lblRolUsuario.Location = new Point(914, 72);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(210, 23);
            lblRolUsuario.TabIndex = 1;
            lblRolUsuario.Text = "Administrador del Sistema";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(192, 0, 0);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(1069, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.Black;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.Black;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(914, 48);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(121, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Alvaro Villena";
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.White;
            panelLateral.Controls.Add(btnLogout);
            panelLateral.Controls.Add(SidePanel);
            panelLateral.Controls.Add(btnConfiguracion);
            panelLateral.Controls.Add(btnFinanzas);
            panelLateral.Controls.Add(btnCompras);
            panelLateral.Controls.Add(pBLogo);
            panelLateral.Controls.Add(btnInventario);
            panelLateral.Controls.Add(btnDashboard);
            panelLateral.Controls.Add(btnPuntoDeVenta);
            panelLateral.Controls.Add(btnToggleSidebar);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(189, 829);
            panelLateral.TabIndex = 6;
            panelLateral.Paint += panelLateral_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DimGray;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btnLogout.IconColor = Color.DarkGray;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 40;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(14, 775);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(179, 51);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "         Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // SidePanel
            // 
            SidePanel.BottomLeft = Color.Red;
            SidePanel.BottomRight = Color.FromArgb(255, 128, 0);
            SidePanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            SidePanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            SidePanel.Location = new Point(0, 217);
            SidePanel.Name = "SidePanel";
            SidePanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            SidePanel.PrimerColor = Color.White;
            SidePanel.Size = new Size(16, 51);
            SidePanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            SidePanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            SidePanel.TabIndex = 0;
            SidePanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            SidePanel.TopLeft = Color.FromArgb(255, 198, 28);
            SidePanel.TopRight = Color.White;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.Cornsilk;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.DimGray;
            btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnConfiguracion.IconColor = Color.Black;
            btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguracion.IconSize = 40;
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(17, 572);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(182, 51);
            btnConfiguracion.TabIndex = 7;
            btnConfiguracion.Text = "        Configuracion";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnFinanzas
            // 
            btnFinanzas.BackColor = Color.Transparent;
            btnFinanzas.Cursor = Cursors.Hand;
            btnFinanzas.FlatAppearance.BorderSize = 0;
            btnFinanzas.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnFinanzas.FlatAppearance.MouseOverBackColor = Color.Cornsilk;
            btnFinanzas.FlatStyle = FlatStyle.Flat;
            btnFinanzas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinanzas.ForeColor = Color.DimGray;
            btnFinanzas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnFinanzas.IconColor = Color.Black;
            btnFinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinanzas.IconSize = 40;
            btnFinanzas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinanzas.Location = new Point(17, 501);
            btnFinanzas.Name = "btnFinanzas";
            btnFinanzas.Size = new Size(182, 51);
            btnFinanzas.TabIndex = 6;
            btnFinanzas.Text = "        Finanzas";
            btnFinanzas.TextAlign = ContentAlignment.MiddleLeft;
            btnFinanzas.UseVisualStyleBackColor = false;
            btnFinanzas.Click += btnFinanzas_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.Transparent;
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnCompras.FlatAppearance.MouseOverBackColor = Color.Cornsilk;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = Color.DimGray;
            btnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            btnCompras.IconColor = Color.Black;
            btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompras.IconSize = 40;
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(17, 430);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(182, 51);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "        Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // pBLogo
            // 
            pBLogo.Anchor = AnchorStyles.Top;
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(36, 3);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(120, 120);
            pBLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pBLogo.TabIndex = 1;
            pBLogo.TabStop = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.Transparent;
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnInventario.FlatAppearance.MouseOverBackColor = Color.Cornsilk;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.DimGray;
            btnInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            btnInventario.IconColor = Color.Black;
            btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventario.IconSize = 40;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(17, 359);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(182, 51);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "        Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Cornsilk;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.DimGray;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            btnDashboard.IconColor = Color.Black;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 40;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(17, 217);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(182, 51);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "        Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPuntoDeVenta
            // 
            btnPuntoDeVenta.BackColor = Color.Transparent;
            btnPuntoDeVenta.Cursor = Cursors.Hand;
            btnPuntoDeVenta.FlatAppearance.BorderSize = 0;
            btnPuntoDeVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnPuntoDeVenta.FlatAppearance.MouseOverBackColor = Color.Cornsilk;
            btnPuntoDeVenta.FlatStyle = FlatStyle.Flat;
            btnPuntoDeVenta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPuntoDeVenta.ForeColor = Color.DimGray;
            btnPuntoDeVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnPuntoDeVenta.IconColor = Color.Black;
            btnPuntoDeVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPuntoDeVenta.IconSize = 40;
            btnPuntoDeVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnPuntoDeVenta.Location = new Point(17, 288);
            btnPuntoDeVenta.Name = "btnPuntoDeVenta";
            btnPuntoDeVenta.Size = new Size(182, 51);
            btnPuntoDeVenta.TabIndex = 2;
            btnPuntoDeVenta.Text = "        Punto de Venta";
            btnPuntoDeVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnPuntoDeVenta.UseVisualStyleBackColor = false;
            btnPuntoDeVenta.Click += btnPuntoDeVenta_Click;
            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.BackColor = Color.White;
            btnToggleSidebar.Cursor = Cursors.Hand;
            btnToggleSidebar.ForeColor = Color.DarkGray;
            btnToggleSidebar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnToggleSidebar.IconColor = Color.DarkGray;
            btnToggleSidebar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnToggleSidebar.IconSize = 33;
            btnToggleSidebar.Location = new Point(19, 144);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new Size(41, 33);
            btnToggleSidebar.SizeMode = PictureBoxSizeMode.Zoom;
            btnToggleSidebar.TabIndex = 0;
            btnToggleSidebar.TabStop = false;
            btnToggleSidebar.UseGdi = true;
            btnToggleSidebar.Click += btnToggleSidebar_Click;
            // 
            // parrotSlidingPanel1
            // 
            parrotSlidingPanel1.BottomLeft = Color.Black;
            parrotSlidingPanel1.BottomRight = Color.DodgerBlue;
            parrotSlidingPanel1.CollapseControl = null;
            parrotSlidingPanel1.Collapsed = true;
            parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotSlidingPanel1.Dock = DockStyle.Left;
            parrotSlidingPanel1.HideControls = false;
            parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotSlidingPanel1.Location = new Point(189, 0);
            parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            parrotSlidingPanel1.PanelWidthCollapsed = 50;
            parrotSlidingPanel1.PanelWidthExpanded = 200;
            parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotSlidingPanel1.PrimerColor = Color.White;
            parrotSlidingPanel1.Size = new Size(10, 829);
            parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotSlidingPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            parrotSlidingPanel1.TabIndex = 7;
            parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotSlidingPanel1.TopLeft = Color.White;
            parrotSlidingPanel1.TopRight = Color.FromArgb(236, 237, 242);
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.White;
            parrotGradientPanel1.BottomRight = Color.FromArgb(255, 198, 0);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(nightControlBox1);
            parrotGradientPanel1.Dock = DockStyle.Top;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1208, 31);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel1.TabIndex = 8;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(255, 198, 28);
            parrotGradientPanel1.TopRight = Color.White;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(parrotPictureBox1);
            panel1.Controls.Add(parrotGradientPanel1);
            panel1.Controls.Add(lblRolUsuario);
            panel1.Controls.Add(lblUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(199, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 103);
            panel1.TabIndex = 9;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            parrotPictureBox1.ColorLeft = Color.DodgerBlue;
            parrotPictureBox1.ColorRight = Color.DodgerBlue;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = (Image)resources.GetObject("parrotPictureBox1.Image");
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = true;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(1130, 33);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(66, 66);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 10;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(199, 103);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1208, 726);
            panelContenedor.TabIndex = 10;
            // 
            // timerSidebar
            // 
            timerSidebar.Interval = 10;
            timerSidebar.Tick += timerSidebar_Tick;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 237, 242);
            ClientSize = new Size(1407, 829);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            Controls.Add(parrotSlidingPanel1);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnToggleSidebar).EndInit();
            parrotGradientPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblRolUsuario;
        private Label lblUsuario;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panelLateral;
        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotSlidingPanel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox btnToggleSidebar;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private PictureBox pBLogo;
        private FontAwesome.Sharp.IconButton btnPuntoDeVenta;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnFinanzas;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnLogout;
        private ReaLTaiizor.Controls.ParrotGradientPanel SidePanel;
        private Panel panelContenedor;
        private System.Windows.Forms.Timer timerSidebar;
    }
}