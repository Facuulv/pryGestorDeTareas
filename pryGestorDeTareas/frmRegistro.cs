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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        clsConexionBD ObjRegistro = new clsConexionBD();
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Habilitado");
            cmbEstado.SelectedIndex = 0;
            ObjRegistro.CargosUsuarios(cmbCargo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtContraseña.Text != "" && cmbCargo.Text != ""
                && cmbEstado.Text != "" && dtFechaCreacion.Text != "")
            {
                string nombre = txtNombre.Text;
                if (!ObjRegistro.VerificarUsuario(nombre))
                {
                    string contraseña = txtContraseña.Text;
                    int cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                    int estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    DateTime fechaCreacion = dtFechaCreacion.Value.Date;

                    ObjRegistro.AgregarUsuario(nombre, contraseña, fechaCreacion, cargo, estado);
                    Limpiar();                    
                }
                else
                {
                    MessageBox.Show($"El usuario {nombre} ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Error, no se pudo agregar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            cmbCargo.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
