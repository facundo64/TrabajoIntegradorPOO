using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class FrmCategorias : Form
    {
        CategoriaService servicio;
        int idSeleccionado = 0;

        public FrmCategorias()
        {
            InitializeComponent();
            servicio = new CategoriaService();

            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = servicio.Listar();
            
            if (dgvCategorias.Columns["Productos"] != null)
                dgvCategorias.Columns["Productos"].Visible = false;
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            chkActiva.Checked = true;
            idSeleccionado = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria c = new Categoria();
                c.Descripcion = txtDescripcion.Text;
                c.Activa = chkActiva.Checked;

                if (servicio.Agregar(c))
                {
                    MessageBox.Show("Categoría creada.");
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;
            try
            {
                Categoria c = new Categoria();
                c.Id = idSeleccionado;
                c.Descripcion = txtDescripcion.Text;
                c.Activa = chkActiva.Checked;

                if (servicio.Modificar(c))
                {
                    MessageBox.Show("Categoría modificada.");
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;
            if (MessageBox.Show("¿Borrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                servicio.Borrar(idSeleccionado);
                CargarGrilla();
                Limpiar();
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var obj = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;
                idSeleccionado = obj.Id;
                txtDescripcion.Text = obj.Descripcion;
                chkActiva.Checked = obj.Activa;
            }
        }

        private void chkActiva_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}