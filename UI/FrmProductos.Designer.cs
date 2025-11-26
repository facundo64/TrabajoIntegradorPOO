namespace UI
{
    partial class FrmProductos
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
            dgvProductos = new DataGridView();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            Precio = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            cmbProveedor = new ComboBox();
            Agregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            Label lblCategoria = new Label();
            Label lblProveedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Top;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(1000, 200);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.GridColor = Color.FromArgb(222, 226, 230);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 123, 255);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvProductos.ColumnHeadersHeight = 40;
            dgvProductos.DefaultCellStyle.BackColor = Color.White;
            dgvProductos.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255);
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProductos.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvProductos.RowTemplate.Height = 35;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 240);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 1;
            txtNombre.BackColor = Color.White;
            txtNombre.ForeColor = Color.FromArgb(33, 37, 41);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 288);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(250, 27);
            txtPrecio.TabIndex = 2;
            txtPrecio.BackColor = Color.White;
            txtPrecio.ForeColor = Color.FromArgb(33, 37, 41);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 10F);
            // 
            // txtStock
            // 
            txtStock.Location = new Point(150, 336);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(250, 27);
            txtStock.TabIndex = 3;
            txtStock.BackColor = Color.White;
            txtStock.ForeColor = Color.FromArgb(33, 37, 41);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 10F);
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(30, 290);
            Precio.Name = "Precio";
            Precio.Size = new Size(58, 20);
            Precio.TabIndex = 4;
            Precio.Text = "Precio:";
            Precio.ForeColor = Color.FromArgb(33, 37, 41);
            Precio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 242);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 338);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 6;
            label2.Text = "Stock:";
            label2.ForeColor = Color.FromArgb(33, 37, 41);
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(590, 240);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(250, 28);
            cmbCategoria.TabIndex = 7;
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.ForeColor = Color.FromArgb(33, 37, 41);
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(590, 288);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(250, 28);
            cmbProveedor.TabIndex = 8;
            cmbProveedor.BackColor = Color.White;
            cmbProveedor.ForeColor = Color.FromArgb(33, 37, 41);
            cmbProveedor.FlatStyle = FlatStyle.Flat;
            cmbProveedor.Font = new Font("Segoe UI", 10F);
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(470, 242);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(82, 20);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoría:";
            lblCategoria.ForeColor = Color.FromArgb(33, 37, 41);
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(470, 290);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(87, 20);
            lblProveedor.TabIndex = 13;
            lblProveedor.Text = "Proveedor:";
            lblProveedor.ForeColor = Color.FromArgb(33, 37, 41);
            lblProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // Agregar
            // 
            Agregar.Location = new Point(150, 390);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(150, 40);
            Agregar.TabIndex = 9;
            Agregar.Text = "✓ Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.BackColor = Color.FromArgb(0, 123, 255);
            Agregar.ForeColor = Color.White;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.FlatAppearance.BorderSize = 0;
            Agregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Agregar.Cursor = Cursors.Hand;
            Agregar.Click += Agregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(330, 390);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 40);
            btnModificar.TabIndex = 11;
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
            btnBorrar.Location = new Point(510, 390);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 40);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "✗ Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.BackColor = Color.FromArgb(220, 53, 69);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBorrar.Cursor = Cursors.Hand;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(lblProveedor);
            Controls.Add(lblCategoria);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(Agregar);
            Controls.Add(cmbProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Precio);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(dgvProductos);
            Name = "FrmProductos";
            Text = "Gestión de Productos";
            BackColor = Color.FromArgb(248, 249, 250);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label Precio;
        private Label label1;
        private Label label2;
        private ComboBox cmbCategoria;
        private ComboBox cmbProveedor;
        private Button Agregar;
        private Button btnBorrar;
        private Button btnModificar;
    }
}