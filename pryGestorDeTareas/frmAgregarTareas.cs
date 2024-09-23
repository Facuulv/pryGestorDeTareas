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
    public partial class frmAgregarTareas : Form
    {
        public frmAgregarTareas()
        {
            InitializeComponent();         
        }
        clsConexionBD ObjAgregar = new clsConexionBD();
        private void frmAgregarTareas_Load(object sender, EventArgs e)
        {
            ObjAgregar.CargarUsuarios(cmbUsuarios);
            ObjAgregar.CargarPrioridades(cmbPrioridades);
            ObjAgregar.CargarCategorias(cmbCategorias);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text != "" && txtTitulo.Text != "" && rtxtDescripcion.Text != ""
                && cmbCategorias.Text != "" && cmbPrioridades.Text != "" && dtFechaVenc.Text != "")
            {
                int usuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
                string titulo = txtTitulo.Text;
                string descripcion = rtxtDescripcion.Text;
                int cate = Convert.ToInt32(cmbCategorias.SelectedValue);
                int prioridades = Convert.ToInt32(cmbPrioridades.SelectedValue);
                DateTime fechaVenc = dtFechaVenc.Value.Date;

                ObjAgregar.AgregarTarea(titulo, descripcion, prioridades, fechaVenc, "Hacer", cate, usuario);
                Limpiar();
            }else
            {
                MessageBox.Show("Error, no se pudo agregar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            cmbUsuarios.Text = "";
            txtTitulo.Text = "";
            rtxtDescripcion.Text = "";
            cmbCategorias.Text = "";
            cmbPrioridades.Text = "";
            dtFechaVenc.Text = "";
        }
    }
}
