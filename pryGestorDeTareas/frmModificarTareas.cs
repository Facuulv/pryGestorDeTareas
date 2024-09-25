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
    public partial class frmModificarTareas : Form
    {
        public frmModificarTareas()
        {
            InitializeComponent();
        }
        clsConexionBD ObjModificar = new clsConexionBD();
        private int idTarea = 0;
        private void frmModificarTareas_Load(object sender, EventArgs e)
        {
            ObjModificar.CargarUsuarios(cmbUsuarios);
            ObjModificar.CargarCategorias(cmbCategorias);
            ObjModificar.CargarPrioridades(cmbPrioridades);
            ObjModificar.CargarEstados(cmbEstados);
        }

        private void optMisTareas_CheckedChanged(object sender, EventArgs e)
        {
            DataTable datosTareasU = ObjModificar.CargarTareasUsuario();
            dgvTareas.DataSource = datosTareasU;
            AjustarCol();
            Limpiar();
        }

        private void optTodas_CheckedChanged(object sender, EventArgs e)
        {
            DataTable datosTareas = ObjModificar.CargarTareas();
            dgvTareas.DataSource = datosTareas;
            AjustarCol();
            Limpiar();
        }
        private void AjustarCol()
        {
            dgvTareas.Columns[0].HeaderText = "ID";
            dgvTareas.Columns["id_Tarea"].Width = 40;
            dgvTareas.Columns["Titulo"].Width = 120;
            dgvTareas.Columns["Descripcion"].Width = 220;
            dgvTareas.Columns["Prioridad"].Width = 60;
            dgvTareas.Columns["Fecha_Vencimiento"].Width = 70;
            dgvTareas.Columns["Estado"].Width = 70;
            dgvTareas.Columns["Categoria"].Width = 70;
            dgvTareas.Columns["Usuario"].Width = 60;


        }
        private void Limpiar()
        {
            cmbUsuarios.Text = "";
            txtTitulo.Text = "";
            rtxtDescripcion.Text = "";
            cmbCategorias.Text = "";
            cmbPrioridades.Text = "";
            cmbEstados.Text = "";
            dtFechaVenc.Text = "";
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTareas.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Error, estas seleccionando una fila vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.RowIndex >= 0)
            {
                idTarea = 0;
                idTarea = Convert.ToInt32(dgvTareas.Rows[e.RowIndex].Cells["id_Tarea"].Value);

                DataTable datosTarea = ObjModificar.CargarDatosTarea(idTarea);
                if (datosTarea.Rows.Count > 0)
                {
                    cmbUsuarios.Text = datosTarea.Rows[0]["Nombre"].ToString();
                    txtTitulo.Text = datosTarea.Rows[0]["Titulo"].ToString();
                    rtxtDescripcion.Text = datosTarea.Rows[0]["Descripcion"].ToString();
                    cmbCategorias.Text = datosTarea.Rows[0]["Categoria"].ToString();
                    cmbPrioridades.Text = datosTarea.Rows[0]["Prioridad"].ToString();
                    cmbEstados.Text = datosTarea.Rows[0]["Estado"].ToString();
                    dtFechaVenc.Value = Convert.ToDateTime(datosTarea.Rows[0]["Fecha_Vencimiento"]);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            optMisTareas.Select();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text != "" && txtTitulo.Text != "" && rtxtDescripcion.Text != "" &&
                cmbCategorias.Text != "" && cmbPrioridades.Text != "" && cmbEstados.Text != "" &&
                dtFechaVenc.Text != "")
            {
                int usuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
                string titulo = txtTitulo.Text;
                string descripcion = rtxtDescripcion.Text;
                int cate = Convert.ToInt32(cmbCategorias.SelectedValue);
                int prioridad = Convert.ToInt32(cmbPrioridades.SelectedValue);
                string estado = cmbEstados.Text;
                DateTime fechaVenc = dtFechaVenc.Value.Date;

                ObjModificar.ModificarTarea(idTarea, titulo, descripcion, prioridad, fechaVenc, estado, cate, usuario);
            } else
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
