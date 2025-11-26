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
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmProveedores : Form
    {
        ProveedorService servicio;
        private int idSeleccionado = 0;

        public FrmProveedores()
        {
            InitializeComponent();
            servicio = new ProveedorService();

            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.MultiSelect = false;
            dgvProveedores.ReadOnly = true;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = servicio.Listar();

            if (dgvProveedores.Columns["Productos"] != null)
                dgvProveedores.Columns["Productos"].Visible = false;
        }

        private void Limpiar()
        {
            txtRazonSocial.Text = "";
            txtCUIT.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            idSeleccionado = 0;
            dgvProveedores.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    MessageBox.Show("La Razón Social es obligatoria.");
                    return;
                }

                Proveedor p = new Proveedor();
                p.RazonSocial = txtRazonSocial.Text;
                p.CUIT = txtCUIT.Text;
                p.Email = txtEmail.Text;
                p.Telefono = txtTelefono.Text;

                if (servicio.Agregar(p))
                {
                    MessageBox.Show("Proveedor agregado con éxito.");
                    CargarGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el proveedor. Verifique los datos.");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al agregar: " + ex.Message + "\n\n" + ex.InnerException?.Message); 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la grilla.");
                return;
            }

            try
            {
                Proveedor p = new Proveedor();
                p.Id = idSeleccionado;
                p.RazonSocial = txtRazonSocial.Text;
                p.CUIT = txtCUIT.Text;
                p.Email = txtEmail.Text;
                p.Telefono = txtTelefono.Text;

                if (servicio.Modificar(p))
                {
                    MessageBox.Show("Proveedor modificado.");
                    CargarGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el proveedor.");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al modificar: " + ex.Message + "\n\n" + ex.InnerException?.Message); 
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la grilla.");
                return;
            }

            if (MessageBox.Show("¿Seguro desea borrar este proveedor?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (servicio.Borrar(idSeleccionado))
                {
                    CargarGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se puede borrar. Posiblemente tenga productos asociados.");
                }
            }
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                try
                {
                    var obj = (Proveedor)dgvProveedores.SelectedRows[0].DataBoundItem;
                    idSeleccionado = obj.Id;

                    txtRazonSocial.Text = obj.RazonSocial;
                    txtCUIT.Text = obj.CUIT;
                    txtEmail.Text = obj.Email;
                    txtTelefono.Text = obj.Telefono;
                }
                catch { }
            }
        }
    }
}