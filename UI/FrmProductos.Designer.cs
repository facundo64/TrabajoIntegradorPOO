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
            dgvProductos.Size = new Size(800, 142);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 199);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(42, 250);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(42, 308);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 3;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(215, 257);
            Precio.Name = "Precio";
            Precio.Size = new Size(50, 20);
            Precio.TabIndex = 4;
            Precio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 199);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 315);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Stock";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(381, 191);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 7;
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(381, 249);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(151, 28);
            cmbProveedor.TabIndex = 8;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(381, 306);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(94, 29);
            Agregar.TabIndex = 9;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(381, 362);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(381, 409);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "FrmProductos";
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