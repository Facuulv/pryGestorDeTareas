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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        clsConexionBD ObjCategorias = new clsConexionBD();
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            ObjCategorias.ListarCategorias(dgvCategorias);
            dgvCategorias.Columns[0].HeaderText = "ID Categoria";
            dgvCategorias.Columns[1].Width = 165;
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text != "")
            {
                string categoria =  txtCategoria.Text;
                ObjCategorias.AgregarCategoria(categoria);
                txtCategoria.Text = "";
                ObjCategorias.ListarCategorias(dgvCategorias);
            }
            else
            {
                MessageBox.Show("Debe rellenar el campo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCategorias.Rows.Count > 0)
                {
                    lblCategoria.Text = dgvCategorias.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lblCategoria.Text != "")
            {
                string categoria = lblCategoria.Text;
                DialogResult resultado = MessageBox.Show(
                $"¿Seguro que quieres eliminar la categoría {categoria}?",
                "Eliminar Categoría",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    ObjCategorias.EliminarCategoria(categoria);
                    ObjCategorias.ListarCategorias(dgvCategorias);
                }
                else
                {
                    MessageBox.Show("La categoría no se ha eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
