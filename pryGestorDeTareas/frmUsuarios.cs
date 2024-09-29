using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace pryGestorDeTareas
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        clsConexionBD ObjUsuarios = new clsConexionBD();
        private int idUsuario = 0;
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
                if (!ObjUsuarios.VerificarUsuario(nombre))
                {
                    string contraseña = txtContraseña.Text;
                    int cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                    int estado = Convert.ToInt32(cmbEstado.SelectedValue);
                    DateTime fechaCreacion = dtFechaCreacion.Value.Date;

                    ObjUsuarios.AgregarUsuario(nombre, contraseña, fechaCreacion, cargo, estado);
                    Limpiar();
                    ObjUsuarios.CargarUsuarios(dgvUsuarios);
                }else
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
            cmbEstado.Text = "";
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Error, estas seleccionando una fila vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.RowIndex >= 0)
            {
                idUsuario = 0;
                idUsuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["id_Usuario"].Value);
                
                DataTable datosUsuario = ObjUsuarios.DatosUsuarios(idUsuario);
                if (datosUsuario.Rows.Count > 0)
                {
                    txtNombre.Text = datosUsuario.Rows[0]["Nombre"].ToString();
                    txtContraseña.Text = datosUsuario.Rows[0]["Contraseña"].ToString();
                    cmbCargo.Text = datosUsuario.Rows[0]["Cargo"].ToString();
                    cmbEstado.Text = datosUsuario.Rows[0]["Estado"].ToString();
                    dtFechaCreacion.Value = Convert.ToDateTime(datosUsuario.Rows[0]["Fecha_Creacion"]);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres eliminar al usuario?",
                "Eliminar Usuario",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ObjUsuarios.EliminarUsuario(idUsuario);
                ObjUsuarios.CargarUsuarios(dgvUsuarios);
            }
            else
            {
                MessageBox.Show("No se ha eliminado el usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtContraseña.Text != "" && cmbCargo.Text != ""
                && cmbEstado.Text != "" && dtFechaCreacion.Text != "")
            {
                string nombre = txtNombre.Text;
                string contraseña = txtContraseña.Text;
                int cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                int estado = Convert.ToInt32(cmbEstado.SelectedValue);
                DateTime fechaCreacion = dtFechaCreacion.Value.Date;

                ObjUsuarios.ModificarUsuario(nombre, contraseña, fechaCreacion, cargo, estado, idUsuario);

            }
            else
            {
                MessageBox.Show("Error al modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtContraseña.Text = "";
            cmbCargo.Text = "";
            cmbEstado.Text = "";
            dtFechaCreacion.ResetText();
        }
    }
}
