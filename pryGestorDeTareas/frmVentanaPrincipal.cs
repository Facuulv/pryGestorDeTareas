﻿using System;
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

            //AjustarCol();
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
    }
}
