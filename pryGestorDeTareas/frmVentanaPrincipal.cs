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
        }

        private void optTodas_CheckedChanged(object sender, EventArgs e)
        {
            ObjPrincipal.ListarTareas(dgvHacer, "Hacer");
            ObjPrincipal.ListarTareas(dgvHaciendo, "Haciendo");
            ObjPrincipal.ListarTareas(dgvHecha, "Hecha");
        }
    }
}
