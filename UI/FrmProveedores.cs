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
using INFRA;

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

        // Agrego el handler de Load que está registrado en el Designer
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // Ya se llama en el constructor, pero mantener por consistencia del evento
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
                    MessageBox.Show("La Razón Social es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtCUIT.Text) && !RegexHelper.ValidarCUIT(txtCUIT.Text))
                {
                    MessageBox.Show("El formato del CUIT no es válido. Use el formato XX-XXXXXXXX-X", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !RegexHelper.ValidarEmail(txtEmail.Text))
                {
                    MessageBox.Show("El formato del email no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !RegexHelper.ValidarTelefono(txtTelefono.Text))
                {
                    MessageBox.Show("El formato del teléfono no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Proveedor p = new Proveedor();
                p.RazonSocial = txtRazonSocial.Text;
                p.CUIT = txtCUIT.Text;
                p.Email = txtEmail.Text;
                p.Telefono = txtTelefono.Text;

                if (servicio.Agregar(p))
                {
                    MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la grilla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    MessageBox.Show("La Razón Social es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtCUIT.Text) && !RegexHelper.ValidarCUIT(txtCUIT.Text))
                {
                    MessageBox.Show("El formato del CUIT no es válido. Use el formato XX-XXXXXXXX-X", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !RegexHelper.ValidarEmail(txtEmail.Text))
                {
                    MessageBox.Show("El formato del email no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !RegexHelper.ValidarTelefono(txtTelefono.Text))
                {
                    MessageBox.Show("El formato del teléfono no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Proveedor p = new Proveedor();
                p.Id = idSeleccionado;
                p.RazonSocial = txtRazonSocial.Text;
                p.CUIT = txtCUIT.Text;
                p.Email = txtEmail.Text;
                p.Telefono = txtTelefono.Text;

                if (servicio.Modificar(p))
                {
                    MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la grilla.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este proveedor?", "Confirmar eliminación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (servicio.Borrar(idSeleccionado))
                    {
                        MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrilla();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede eliminar. El proveedor tiene productos asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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