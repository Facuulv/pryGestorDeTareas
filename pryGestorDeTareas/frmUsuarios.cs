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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        clsConexionBD ObjUsuarios = new clsConexionBD();
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ObjUsuarios.CargarUsuarios(dgvUsuarios);
            ObjUsuarios.EstadosUsuarios(cmbEstado);
            ObjUsuarios.CargosUsuarios(cmbCargo);
            dgvUsuarios.Columns[0].HeaderText = "ID";
            dgvUsuarios.Columns[0].Width= 70;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtContraseña.Text != "" && cmbCargo.Text != ""
                && cmbEstado.Text != "" && dtFechaCreacion.Text != "")
            {
                string nombre = txtNombre.Text;
                string contraseña = txtContraseña.Text;
                int cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                int estado = Convert.ToInt32(cmbEstado.SelectedValue);
                DateTime fechaCreacion = dtFechaCreacion.Value.Date;

                ObjUsuarios.AgregarUsuario(nombre, contraseña, fechaCreacion, cargo, estado);
                ObjUsuarios.CargarUsuarios(dgvUsuarios);
            }
            else
            {
                MessageBox.Show("Error, no se pudo agregar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
