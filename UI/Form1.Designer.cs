namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnIngresar = new Button();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelLogin = new Panel();
            panelHeader = new Panel();
            lblIcono = new Label();
            panelLogin.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(248, 249, 250);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.ForeColor = Color.FromArgb(33, 37, 41);
            txtUsuario.Location = new Point(40, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(320, 32);
            txtUsuario.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(248, 249, 250);
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.ForeColor = Color.FromArgb(33, 37, 41);
            txtPass.Location = new Point(40, 150);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.PlaceholderText = "Ingrese su contraseña";
            txtPass.Size = new Size(320, 32);
            txtPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 2;
            label1.Text = "👤 Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Location = new Point(40, 120);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 3;
            label2.Text = "🔒 Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 123, 255);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(40, 206);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(320, 45);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "🚀 INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(120, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Gestión";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(240, 248, 255);
            lblSubtitulo.Location = new Point(170, 88);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(193, 23);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Ingrese sus credenciales";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(txtPass);
            panelLogin.Controls.Add(btnIngresar);
            panelLogin.Location = new Point(50, 150);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(400, 280);
            panelLogin.TabIndex = 7;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 123, 255);
            panelHeader.Controls.Add(lblIcono);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(521, 120);
            panelHeader.TabIndex = 6;
            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font("Segoe UI", 32F);
            lblIcono.ForeColor = Color.White;
            lblIcono.Location = new Point(12, 39);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(104, 72);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "🔐";
            lblIcono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(521, 578);
            Controls.Add(panelLogin);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión - Login";
            Load += Form1_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button btnIngresar;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelLogin;
        private Panel panelHeader;
        private Label lblIcono;
    }
}
