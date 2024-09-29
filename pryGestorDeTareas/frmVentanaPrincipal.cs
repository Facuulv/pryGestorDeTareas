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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }
        clsConexionBD ObjPrincipal = new clsConexionBD();       
        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            ObjPrincipal.ActualizarTareasVencidas();
            ObjPrincipal.ReporteTareas();
            string usuario = clsConexionBD.Sesion.UsuarioActual;
            tslUsuario.Text = usuario;
        }

        private void frmVentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsbCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres cerrar sesión?",
                "Confirmar Cierre de Sesión",
                MessageBoxButtons.YesNo,              
                MessageBoxIcon.Question);         

            if (resultado == DialogResult.Yes)
            {                
                MessageBox.Show("Sesión cerrada con éxito.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("No se ha cerrado la sesión.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optMisTareas_CheckedChanged(object sender, EventArgs e)
        {
            ObjPrincipal.ListarTareasUsuario(dgvHacer, "Hacer");
            ObjPrincipal.ListarTareasUsuario(dgvHaciendo, "Haciendo");
            ObjPrincipal.ListarTareasUsuario(dgvHecha, "Hecha");
            AjustarCol();
        }

        private void optTodas_CheckedChanged(object sender, EventArgs e)
        {
            ObjPrincipal.ListarTareas(dgvHacer, "Hacer");
            ObjPrincipal.ListarTareas(dgvHaciendo, "Haciendo");
            ObjPrincipal.ListarTareas(dgvHecha, "Hecha");
            AjustarCol();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarTareas agregarTareas = new frmAgregarTareas();
            agregarTareas.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarTareas modificarTareas = new frmModificarTareas();
            modificarTareas.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarTareas eliminarTareas = new frmEliminarTareas();
            eliminarTareas.ShowDialog();
        }
        public void AjustarCol()
        {
            dgvHacer.Columns[0].HeaderText = "ID";
            dgvHacer.Columns["id_Tarea"].Width = 40;
            dgvHacer.Columns["Titulo"].Width = 120;
            dgvHacer.Columns["Descripcion"].Width = 220;
            dgvHacer.Columns["Prioridad"].Width = 70;
            dgvHacer.Columns["Fecha_Vencimiento"].Width = 80;
            dgvHacer.Columns["Estado"].Width = 80;
            dgvHacer.Columns["Categoria"].Width = 70;
            dgvHacer.Columns["Usuario"].Width = 60;

            dgvHaciendo.Columns[0].HeaderText = "ID";
            dgvHaciendo.Columns["id_Tarea"].Width = 40;
            dgvHaciendo.Columns["Titulo"].Width = 120;
            dgvHaciendo.Columns["Descripcion"].Width = 220;
            dgvHaciendo.Columns["Prioridad"].Width = 70;
            dgvHaciendo.Columns["Fecha_Vencimiento"].Width = 80;
            dgvHaciendo.Columns["Estado"].Width = 80;
            dgvHaciendo.Columns["Categoria"].Width = 70;
            dgvHaciendo.Columns["Usuario"].Width = 60;

            dgvHecha.Columns[0].HeaderText = "ID";
            dgvHecha.Columns["id_Tarea"].Width = 40;
            dgvHecha.Columns["Titulo"].Width = 120;
            dgvHecha.Columns["Descripcion"].Width = 220;
            dgvHecha.Columns["Prioridad"].Width = 70;
            dgvHecha.Columns["Fecha_Vencimiento"].Width = 80;
            dgvHecha.Columns["Estado"].Width = 80;
            dgvHecha.Columns["Categoria"].Width = 70;
            dgvHecha.Columns["Usuario"].Width = 60;
        }

        private void tsbConfirmar_Click(object sender, EventArgs e)
        {
            DataGridView dgvAux = null;
            if (tbControl.SelectedTab == tpHacer)
            {
                dgvAux = dgvHacer;
            }
            if (tbControl.SelectedTab == tpHaciendo)
            {
                dgvAux = dgvHaciendo;
            }

            if (dgvAux == null)
            {
                MessageBox.Show("La tarea seleccionada se encuentra como Hecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {               
                if (dgvAux.SelectedRows.Count > 0)
                {
                    int idTarea = Convert.ToInt32(dgvAux.SelectedRows[0].Cells["id_Tarea"].Value);

                    DialogResult resultado = MessageBox.Show(
                            "La tarea seleccionada se va a marcar como Hecha. ¿Estas seguro?",
                            "Completar Tarea",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ObjPrincipal.ConfirmarTarea(idTarea, "Hecha");
                        MessageBox.Show("La tarea seleccionada se ha completado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ObjPrincipal.ListarTareasUsuario(dgvHacer, "Hacer");
                        ObjPrincipal.ListarTareasUsuario(dgvHaciendo, "Haciendo");
                        ObjPrincipal.ListarTareasUsuario(dgvHecha, "Hecha");
                        ObjPrincipal.ListarTareas(dgvHacer, "Hacer");
                        ObjPrincipal.ListarTareas(dgvHaciendo, "Haciendo");
                        ObjPrincipal.ListarTareas(dgvHecha, "Hecha");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una tarea para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            frmModificarTareas modificarTareas = new frmModificarTareas();
            modificarTareas.ShowDialog();
        }

        private void dgvHacer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHacer.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Error, estas seleccionando una fila vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvHaciendo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHaciendo.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Error, estas seleccionando una fila vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvHecha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHecha.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Error, estas seleccionando una fila vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tsbPapelera_Click(object sender, EventArgs e)
        {
            DataGridView dgvAux = null;
            if (tbControl.SelectedTab == tpHacer)
            {
                dgvAux = dgvHacer;
            }
            if (tbControl.SelectedTab == tpHaciendo)
            {
                dgvAux = dgvHaciendo;
            }
            if (tbControl.SelectedTab == tpHecha)
            {
                dgvAux = dgvHecha;
            }

            if (dgvAux == null)
            {
                MessageBox.Show("Error al seleccionar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgvAux.SelectedRows.Count > 0)
                {
                    int idTarea = Convert.ToInt32(dgvAux.SelectedRows[0].Cells["id_Tarea"].Value);

                    DialogResult resultado = MessageBox.Show(
                            "La tarea seleccionada se eliminará y no podrás recuperarla. ¿Estas seguro?",
                            "Eliminar Tarea",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ObjPrincipal.EliminarTarea(idTarea);

                        ObjPrincipal.ListarTareasUsuario(dgvHacer, "Hacer");
                        ObjPrincipal.ListarTareasUsuario(dgvHaciendo, "Haciendo");
                        ObjPrincipal.ListarTareasUsuario(dgvHecha, "Hecha");
                        ObjPrincipal.ListarTareas(dgvHacer, "Hacer");
                        ObjPrincipal.ListarTareas(dgvHaciendo, "Haciendo");
                        ObjPrincipal.ListarTareas(dgvHecha, "Hecha");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una tarea para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.ShowDialog();
        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            if (optMisTareas.Checked == true)
            {
                ObjPrincipal.ListarTareasUsuario(dgvHacer, "Hacer");
                ObjPrincipal.ListarTareasUsuario(dgvHaciendo, "Haciendo");
                ObjPrincipal.ListarTareasUsuario(dgvHecha, "Hecha");
            }
            if (optTodas.Checked == true)
            {
                ObjPrincipal.ListarTareas(dgvHacer, "Hacer");
                ObjPrincipal.ListarTareas(dgvHaciendo, "Haciendo");
                ObjPrincipal.ListarTareas(dgvHecha, "Hecha");
            } 
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarTareas buscar = new frmBuscarTareas();
            buscar.ShowDialog();
        }
    }
}
