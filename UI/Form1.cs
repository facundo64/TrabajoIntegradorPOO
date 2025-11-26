using BE;
using System.Text.RegularExpressions;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string patronUsuario = @"^[a-zA-Z0-9]{5,15}$";

                if (!Regex.IsMatch(txtUsuario.Text, patronUsuario))
                {
                    MessageBox.Show("El usuario debe tener entre 5 y 15 caracteres alfanuméricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Ingrese una contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UsuarioService servicio = new UsuarioService();
                Usuario usuarioLogueado = servicio.ValidarUsuario(txtUsuario.Text, txtPass.Text);

                if (usuarioLogueado != null)
                {
                    MessageBox.Show($"Bienvenido {usuarioLogueado.NombreUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmPrincipal menu = new FrmPrincipal();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error técnico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
