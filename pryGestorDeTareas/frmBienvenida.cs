using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestorDeTareas
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }
        private bool contraseñaVisible = false;
        clsConexionBD ObjBienvenida = new clsConexionBD();
        private void frmBienvenida_Load(object sender, EventArgs e)
        {

            Controles();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ObjBienvenida.ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("Usuario validado correctamente");
                frmVentanaPrincipal principal = new frmVentanaPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (contraseñaVisible)
            {
                txtContraseña.PasswordChar = '*';
            }
            else
            {
                // muestra la pass
                txtContraseña.PasswordChar = '\0'; 
            }
            contraseñaVisible = !contraseñaVisible;
        }
        private void Controles()
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) &&
                !string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                btnIngresar.Enabled = true;
                btnMostrarOcultar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
                btnMostrarOcultar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Controles();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            Controles();
        }
    }
}
