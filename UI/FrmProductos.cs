using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using BE;
using INFRA;

namespace UI
{
    public partial class FrmProductos : Form
    {
        // Servicios
        ProductoService servicioProducto;
        CategoriaService servicioCategoria;
        ProveedorService servicioProveedor;

        // Variable auxiliar para guardar el ID cuando queremos MODIFICAR
        private int idSeleccionado = 0;

        public FrmProductos()
        {
            InitializeComponent();

            // Instanciamos los servicios
            servicioProducto = new ProductoService();
            servicioCategoria = new CategoriaService();
            servicioProveedor = new ProveedorService();

            // Configuración visual de la grilla
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.ReadOnly = true;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // CARGAMOS LOS DATOS AL INICIAR (En el constructor para asegurar que cargue)
            CargarCombos();
            CargarGrilla();
        }

        private void CargarCombos()
        {
            try
            {
                // Combos configurados para mostrar nombre y guardar ID
                cmbCategoria.DataSource = servicioCategoria.Listar();
                cmbCategoria.DisplayMember = "Descripcion";
                cmbCategoria.ValueMember = "Id";

                cmbProveedor.DataSource = servicioProveedor.Listar();
                cmbProveedor.DisplayMember = "RazonSocial";
                cmbProveedor.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = servicioProducto.Listar();

            // Ocultamos columnas técnicas
            if (dgvProductos.Columns["Categoria"] != null) dgvProductos.Columns["Categoria"].Visible = false;
            if (dgvProductos.Columns["Proveedor"] != null) dgvProductos.Columns["Proveedor"].Visible = false;
            if (dgvProductos.Columns["CategoriaId"] != null) dgvProductos.Columns["CategoriaId"].Visible = false;
            if (dgvProductos.Columns["ProveedorId"] != null) dgvProductos.Columns["ProveedorId"].Visible = false;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            idSeleccionado = 0; // Reseteamos el ID
            dgvProductos.ClearSelection();
        }


        // --- BOTÓN MODIFICAR (Implementado) ---
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un producto de la grilla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!RegexHelper.ValidarNumeroPositivo(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!RegexHelper.ValidarNumeroPositivo(txtStock.Text))
                {
                    MessageBox.Show("Ingrese un stock válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto p = new Producto();
                p.Id = idSeleccionado; // ¡IMPORTANTE! Pasamos el ID que guardamos al hacer clic
                p.Nombre = txtNombre.Text;
                p.Precio = Convert.ToDecimal(txtPrecio.Text.Replace(',', '.'));
                p.Stock = Convert.ToInt32(txtStock.Text);
                p.Activo = true; // O lo que corresponda

                p.CategoriaId = (int)cmbCategoria.SelectedValue;
                p.ProveedorId = (int)cmbProveedor.SelectedValue;

                if (servicioProducto.Modificar(p))
                {
                    MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- EVENTO CLIC EN LA GRILLA ---
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            // Verificamos que haya algo seleccionado para evitar errores
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    // Convertimos la fila seleccionada en un objeto Producto
                    Producto seleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                    // Guardamos el ID en la variable global para usarla al Modificar
                    idSeleccionado = seleccionado.Id;

                    // Llenamos los campos visuales
                    txtNombre.Text = seleccionado.Nombre;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtStock.Text = seleccionado.Stock.ToString();
                    cmbCategoria.SelectedValue = seleccionado.CategoriaId;
                    cmbProveedor.SelectedValue = seleccionado.ProveedorId;
                }
                catch { }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validacion simple para que no explote si está vacío
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!RegexHelper.ValidarNumeroPositivo(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!RegexHelper.ValidarNumeroPositivo(txtStock.Text))
                {
                    MessageBox.Show("Ingrese un stock válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto p = new Producto();
                p.Nombre = txtNombre.Text;
                p.Precio = Convert.ToDecimal(txtPrecio.Text.Replace(',', '.'));
                p.Stock = Convert.ToInt32(txtStock.Text);
                p.Activo = true;
                p.FechaAlta = DateTime.Now;

                // Obtenemos los IDs de los combos
                p.CategoriaId = (int)cmbCategoria.SelectedValue;
                p.ProveedorId = (int)cmbProveedor.SelectedValue;

                if (servicioProducto.Agregar(p))
                {
                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto de la grilla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Producto seleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show($"¿Está seguro de eliminar el producto '{seleccionado.Nombre}'?", 
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (servicioProducto.Borrar(seleccionado.Id))
                    {
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrilla();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}