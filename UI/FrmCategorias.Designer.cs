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
            Label lblDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(180, 240);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 27);
            txtDescripcion.TabIndex = 0;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(33, 37, 41);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(180, 295);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(142, 24);
            chkActiva.TabIndex = 1;
            chkActiva.Text = "¿Categoría Activa?";
            chkActiva.UseVisualStyleBackColor = true;
            chkActiva.CheckedChanged += chkActiva_CheckedChanged;
            chkActiva.ForeColor = Color.FromArgb(33, 37, 41);
            chkActiva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkActiva.FlatStyle = FlatStyle.Flat;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(50, 242);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(95, 20);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.ForeColor = Color.FromArgb(33, 37, 41);
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(180, 350);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 40);
            btnAgregar.TabIndex = 2;
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
            btnModificar.Location = new Point(360, 350);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 40);
            btnModificar.TabIndex = 3;
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
            btnBorrar.Location = new Point(540, 350);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 40);
            btnBorrar.TabIndex = 4;
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
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Top;
            dgvCategorias.Location = new Point(0, 0);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(900, 200);
            dgvCategorias.TabIndex = 5;
            dgvCategorias.SelectionChanged += dgvCategorias_SelectionChanged;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.GridColor = Color.FromArgb(222, 226, 230);
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
            dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCategorias.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvCategorias.ColumnHeadersHeight = 40;
            dgvCategorias.DefaultCellStyle.BackColor = Color.White;
            dgvCategorias.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dgvCategorias.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCategorias.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvCategorias.RowTemplate.Height = 35;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(lblDescripcion);
            Controls.Add(dgvCategorias);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(chkActiva);
            Controls.Add(txtDescripcion);
            Name = "FrmCategorias";
            Text = "Gestión de Categorías";
            BackColor = Color.FromArgb(248, 249, 250);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
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