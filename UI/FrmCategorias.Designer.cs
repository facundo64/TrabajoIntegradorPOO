namespace UI
{
    partial class FrmCategorias
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
            txtDescripcion = new TextBox();
            chkActiva = new CheckBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(479, 311);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 0;
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(53, 299);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(117, 24);
            chkActiva.TabIndex = 1;
            chkActiva.Text = "¿Esta Activa?";
            chkActiva.UseVisualStyleBackColor = true;
            chkActiva.CheckedChanged += chkActiva_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(341, 299);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(190, 215);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(190, 271);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Top;
            dgvCategorias.Location = new Point(0, 0);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(800, 188);
            dgvCategorias.TabIndex = 5;
            dgvCategorias.SelectionChanged += dgvCategorias_SelectionChanged;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(chkActiva);
            Controls.Add(txtDescripcion);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private CheckBox chkActiva;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private DataGridView dgvCategorias;
    }
}