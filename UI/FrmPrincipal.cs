using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmPrincipal : Form
    {

        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(T))
                {
                    f.BringToFront();
                    return;
                }
                f.Close();
            }
            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        //metodo singelton,me lo recomendo gpt

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmProductos>();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCategorias>();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmProveedores>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
