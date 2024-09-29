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
    public partial class frmBuscarTareas : Form
    {
        public frmBuscarTareas()
        {
            InitializeComponent();
        }
        clsConexionBD ObjBusqueda = new clsConexionBD();
        public void Controles()
        {
            cmbCategorias.Enabled = false;
            cmbPrioridades.Enabled = false;
            optVencimiento.Enabled = false;
            if (optMisTareas.Checked || optTodas.Checked)
            {
                cmbTipoFiltro.Enabled = true;
            }else
            {
                cmbTipoFiltro.Enabled = false;
            }
        }

        private void frmBuscarTareas_Load(object sender, EventArgs e)
        {
            Controles();
            ObjBusqueda.CargarCategorias(cmbCategorias);
            ObjBusqueda.CargarPrioridades(cmbPrioridades);
        }

        private void cmbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategorias.SelectedIndex = -1;
            cmbPrioridades.SelectedIndex = -1;
            optVencimiento.Checked = false;
            if (cmbTipoFiltro.SelectedIndex == 0)
            {
                cmbCategorias.Enabled = true;
                cmbPrioridades.Enabled = false;
                optVencimiento.Enabled = false;
                cmbPrioridades.Text = "";
            }else if (cmbTipoFiltro.SelectedIndex == 1)
            {
                cmbCategorias.Enabled = false;
                cmbPrioridades.Enabled = true;
                optVencimiento.Enabled = false;
                cmbCategorias.Text = "";
            }else if (cmbTipoFiltro.SelectedIndex == 2)
            {
                cmbCategorias.Enabled = false;
                cmbPrioridades.Enabled = false;
                optVencimiento.Enabled = true;
                cmbCategorias.Text = "";
                cmbPrioridades.Text = "";
            }
        }

        private void optMisTareas_CheckedChanged(object sender, EventArgs e)
        {
            Controles();
            dgvTareas.DataSource = null;
            dgvTareas.Rows.Clear();
            cmbTipoFiltro.SelectedIndex = -1;
            cmbCategorias.SelectedIndex = -1;
            cmbPrioridades.SelectedIndex = -1;
            optVencimiento.Checked = false;
        }

        private void optTodas_CheckedChanged(object sender, EventArgs e)
        {
            Controles();
            dgvTareas.DataSource = null;
            dgvTareas.Rows.Clear();
            cmbTipoFiltro.SelectedIndex = -1;
            cmbCategorias.SelectedIndex = -1;
            cmbPrioridades.SelectedIndex = -1;
            optVencimiento.Checked = false;
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate = cmbCategorias.Text;
            if (optMisTareas.Checked)
            {
                ObjBusqueda.BuscarCategoriaUsuario(dgvTareas, cate);
            }
            if (optTodas.Checked)
            {
                ObjBusqueda.BuscarCategoria(dgvTareas, cate);
            }
        }

        private void cmbPrioridades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prioridad = cmbPrioridades.Text;
            if (optMisTareas.Checked)
            {
                ObjBusqueda.BuscarPrioridadUsuario(dgvTareas, prioridad);
            }
            if (optTodas.Checked)
            {
                ObjBusqueda.BuscarPrioridad(dgvTareas, prioridad);
            }
            
        }

        private void optVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (optMisTareas.Checked)
            {
                ObjBusqueda.BuscarFechaVencUsuario(dgvTareas);
            }
            if (optTodas.Checked)
            {
                ObjBusqueda.BuscarFechaVenc(dgvTareas);
            }
        }
    }
}
