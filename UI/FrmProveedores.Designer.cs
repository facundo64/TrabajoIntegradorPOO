namespace UI
{
    partial class FrmProveedores
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
            txtRazonSocial = new TextBox();
            txtCUIT = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            dgvProveedores = new DataGridView();
            Label lblRazonSocial = new Label();
            Label lblCUIT = new Label();
            Label lblEmail = new Label();
            Label lblTelefono = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(150, 220);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(250, 27);
            txtRazonSocial.TabIndex = 0;
            txtRazonSocial.BackColor = Color.White;
            txtRazonSocial.ForeColor = Color.FromArgb(33, 37, 41);
            txtRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            txtRazonSocial.Font = new Font("Segoe UI", 10F);
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(150, 268);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(250, 27);
            txtCUIT.TabIndex = 1;
            txtCUIT.BackColor = Color.White;
            txtCUIT.ForeColor = Color.FromArgb(33, 37, 41);
            txtCUIT.BorderStyle = BorderStyle.FixedSingle;
            txtCUIT.Font = new Font("Segoe UI", 10F);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 316);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 2;
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.FromArgb(33, 37, 41);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 364);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 27);
            txtTelefono.TabIndex = 3;
            txtTelefono.BackColor = Color.White;
            txtTelefono.ForeColor = Color.FromArgb(33, 37, 41);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(30, 222);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(102, 20);
            lblRazonSocial.TabIndex = 8;
            lblRazonSocial.Text = "Razón Social:";
            lblRazonSocial.ForeColor = Color.FromArgb(33, 37, 41);
            lblRazonSocial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Location = new Point(30, 270);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new Size(45, 20);
            lblCUIT.TabIndex = 9;
            lblCUIT.Text = "CUIT:";
            lblCUIT.ForeColor = Color.FromArgb(33, 37, 41);
            lblCUIT.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 318);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            lblEmail.ForeColor = Color.FromArgb(33, 37, 41);
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(30, 366);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(75, 20);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.ForeColor = Color.FromArgb(33, 37, 41);
            lblTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(450, 218);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "✓ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.BackColor = Color.FromArgb(0, 123, 255);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(450, 274);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 38);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "✎ Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.BackColor = Color.FromArgb(255, 193, 7);
            btnModificar.ForeColor = Color.FromArgb(33, 37, 41);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(450, 330);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(140, 38);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "✗ Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.BackColor = Color.FromArgb(220, 53, 69);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Dock = DockStyle.Top;
            dgvProveedores.Location = new Point(0, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(900, 200);
            dgvProveedores.TabIndex = 7;
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.GridColor = Color.FromArgb(222, 226, 230);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProveedores.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvProveedores.ColumnHeadersHeight = 40;
            dgvProveedores.DefaultCellStyle.BackColor = Color.White;
            dgvProveedores.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvProveedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dgvProveedores.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProveedores.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvProveedores.RowTemplate.Height = 35;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblCUIT);
            Controls.Add(lblRazonSocial);
            Controls.Add(dgvProveedores);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtCUIT);
            Controls.Add(txtRazonSocial);
            Name = "FrmProveedores";
            Text = "Gestión de Proveedores";
            BackColor = Color.FromArgb(248, 249, 250);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRazonSocial;
        private TextBox txtCUIT;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dgvProveedores;
    }
}