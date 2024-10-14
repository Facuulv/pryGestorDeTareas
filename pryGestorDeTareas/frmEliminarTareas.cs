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
    public partial class frmEliminarTareas : Form
    {
        public frmEliminarTareas()
        {
            InitializeComponent();
        }
        clsConexionBD ObjEliminar = new clsConexionBD();
        String UsuarioActual = clsConexionBD.Sesion.UsuarioActual;
        private int idTarea = 0;
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTareas.DataSource = null;
            dgvTareas.Rows.Clear();
        }

        private void frmEliminarTareas_Load(object sender, EventArgs e)
        {
            
        }
        public void AjustarCol()
        {
            dgvTareas.Columns[0].HeaderText = "ID";
            dgvTareas.Columns["id_Tarea"].Width = 40;
            dgvTareas.Columns["Titulo"].Width = 120;
            dgvTareas.Columns["Descripcion"].Width = 220;
            dgvTareas.Columns["Prioridad"].Width = 70;
            dgvTareas.Columns["Fecha_Vencimiento"].Width = 80;
            dgvTareas.Columns["Estado"].Width = 80;
            dgvTareas.Columns["Categoria"].Width = 70;
            dgvTareas.Columns["Usuario"].Width = 60;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ObjEliminar.ListarTareas(dgvTareas);
            AjustarCol();
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTarea = 0;
                idTarea = Convert.ToInt32(dgvTareas.Rows[e.RowIndex].Cells["id_Tarea"].Value);

                DataTable datosTarea = ObjEliminar.CargarDatosTarea(idTarea);
                if (datosTarea.Rows.Count > 0)
                {
                    txtIdTarea.Text = idTarea.ToString();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdTarea.Text != "")
            {
                DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres eliminar la tarea seleccionada?",
                "Eliminar Tarea",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ObjEliminar.EliminarTarea(idTarea);
                    ObjEliminar.ListarTareas(dgvTareas);
                    AjustarCol();                   
                }
                else
                {
                    MessageBox.Show("La tarea no se ha eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }else
            {
                MessageBox.Show("Debe seleccionar una tarea.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (UsuarioActual == "admin")
            {
                DialogResult resultado = MessageBox.Show(
                "¿Se eliminarán todas las tareas, estas seguro?",
                "Eliminar Tareas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ObjEliminar.EliminarTodo();
                    ObjEliminar.ListarTareas(dgvTareas);
                    AjustarCol();
                }
                else
                {
                    MessageBox.Show("Se ha cancelado la acción.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Solo el Administrador tiene permisos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
