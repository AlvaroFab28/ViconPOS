

namespace ViconPOS.Modules.Login.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnIngresar = new Button();
            lblError = new Label();
            chkMostrar = new CheckBox();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            lblFraseLogo = new Label();
            pbAdorno3 = new PictureBox();
            pbAdorno2 = new PictureBox();
            pbAdorno1 = new PictureBox();
            pbLogo = new PictureBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdorno3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdorno2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdorno1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Microsoft PhagsPa", 12F);
            lblUsuario.ForeColor = Color.FromArgb(50, 50, 50);
            lblUsuario.Location = new Point(317, 58);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 26);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Microsoft PhagsPa", 12F);
            lblContraseña.ForeColor = Color.FromArgb(50, 50, 50);
            lblContraseña.Location = new Point(317, 134);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(114, 26);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Crimson;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(323, 270);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(209, 40);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "🔥 INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 10F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(262, 353);
            lblError.Name = "lblError";
            lblError.Size = new Size(139, 23);
            lblError.TabIndex = 6;
            lblError.Text = "Mensaje de Error";
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.BackColor = Color.Transparent;
            chkMostrar.Font = new Font("Segoe UI", 10F);
            chkMostrar.ForeColor = Color.Black;
            chkMostrar.Location = new Point(323, 217);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(180, 27);
            chkMostrar.TabIndex = 7;
            chkMostrar.Text = "Mostrar contraseña";
            chkMostrar.UseVisualStyleBackColor = false;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;
            // 
            // foreverClose1
            // 
            foreverClose1.BackColor = Color.Crimson;
            foreverClose1.BaseColor = Color.Transparent;
            foreverClose1.DefaultLocation = true;
            foreverClose1.Dock = DockStyle.Right;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(599, 0);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 10;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.Gold;
            parrotGradientPanel1.BottomRight = SystemColors.Window;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(lblFraseLogo);
            parrotGradientPanel1.Controls.Add(pbAdorno3);
            parrotGradientPanel1.Controls.Add(pbAdorno2);
            parrotGradientPanel1.Controls.Add(pbAdorno1);
            parrotGradientPanel1.Controls.Add(pbLogo);
            parrotGradientPanel1.Dock = DockStyle.Left;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(219, 400);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 11;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Cornsilk;
            parrotGradientPanel1.TopRight = Color.OldLace;
            // 
            // lblFraseLogo
            // 
            lblFraseLogo.AutoSize = true;
            lblFraseLogo.BackColor = Color.Transparent;
            lblFraseLogo.Font = new Font("Microsoft Himalaya", 13F, FontStyle.Italic);
            lblFraseLogo.ForeColor = Color.DimGray;
            lblFraseLogo.Location = new Point(3, 301);
            lblFraseLogo.Name = "lblFraseLogo";
            lblFraseLogo.Size = new Size(215, 22);
            lblFraseLogo.TabIndex = 5;
            lblFraseLogo.Text = "Gestión rápida para comida rápida";
            // 
            // pbAdorno3
            // 
            pbAdorno3.BackColor = Color.Transparent;
            pbAdorno3.Image = (Image)resources.GetObject("pbAdorno3.Image");
            pbAdorno3.Location = new Point(156, 335);
            pbAdorno3.Name = "pbAdorno3";
            pbAdorno3.Size = new Size(50, 50);
            pbAdorno3.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdorno3.TabIndex = 4;
            pbAdorno3.TabStop = false;
            // 
            // pbAdorno2
            // 
            pbAdorno2.BackColor = Color.Transparent;
            pbAdorno2.Image = (Image)resources.GetObject("pbAdorno2.Image");
            pbAdorno2.Location = new Point(84, 335);
            pbAdorno2.Name = "pbAdorno2";
            pbAdorno2.Size = new Size(50, 50);
            pbAdorno2.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdorno2.TabIndex = 3;
            pbAdorno2.TabStop = false;
            // 
            // pbAdorno1
            // 
            pbAdorno1.BackColor = Color.Transparent;
            pbAdorno1.Image = (Image)resources.GetObject("pbAdorno1.Image");
            pbAdorno1.Location = new Point(12, 343);
            pbAdorno1.Name = "pbAdorno1";
            pbAdorno1.Size = new Size(50, 50);
            pbAdorno1.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdorno1.TabIndex = 1;
            pbAdorno1.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 0);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(219, 195);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Info;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(323, 93);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "👤";
            txtUsuario.Size = new Size(209, 34);
            txtUsuario.TabIndex = 3;
            txtUsuario.PreviewKeyDown += txtUsuario_PreviewKeyDown;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Info;
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(323, 169);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "🔒";
            txtContraseña.Size = new Size(209, 34);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.PreviewKeyDown += txtContraseña_PreviewKeyDown;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(617, 400);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(parrotGradientPanel1);
            Controls.Add(foreverClose1);
            Controls.Add(chkMostrar);
            Controls.Add(lblError);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdorno3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdorno2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdorno1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblError;
        private Label lblFraseLogo;
        private CheckBox chkMostrar;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private PictureBox pbLogo;
        private PictureBox pbAdorno1;
        private PictureBox pbAdorno2;
        private PictureBox pbAdorno3;

    }
}