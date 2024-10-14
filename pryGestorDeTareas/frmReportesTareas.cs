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
    public partial class frmReportesTareas : Form
    {
        public frmReportesTareas()
        {
            InitializeComponent();
        }
        clsConexionBD ObjReportes = new clsConexionBD();
        private void frmReportesTareas_Load(object sender, EventArgs e)
        {

        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            ObjReportes.TareasPendientes(txtPendientes);
        }

        private void btnCompletadas_Click(object sender, EventArgs e)
        {
            ObjReportes.TareasCompletadas(txtCompletadas);
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            txtCompletadas.Clear();
            txtPendientes.Clear();
        }
    }
}
