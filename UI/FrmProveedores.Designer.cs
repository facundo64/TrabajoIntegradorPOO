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
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(238, 204);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(125, 27);
            txtRazonSocial.TabIndex = 0;
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new Point(238, 243);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new Size(125, 27);
            txtCUIT.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(238, 336);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(481, 202);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(481, 274);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(481, 336);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Dock = DockStyle.Top;
            dgvProveedores.Location = new Point(0, 0);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.Size = new Size(800, 188);
            dgvProveedores.TabIndex = 7;
            dgvProveedores.SelectionChanged += dgvProveedores_SelectionChanged;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProveedores);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtCUIT);
            Controls.Add(txtRazonSocial);
            Name = "FrmProveedores";
            Text = "FrmProveedores";
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