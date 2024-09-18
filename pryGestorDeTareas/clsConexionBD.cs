using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace pryGestorDeTareas
{
    internal class clsConexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Tareas.accdb;";
        }
        public bool ValidarUsuario(string usuario, string contraseña)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";
                comando.Parameters.AddWithValue("@Nombre", usuario);
                comando.Parameters.AddWithValue("@Apellido", contraseña);

                conexion.Open();
                int contador = (int)comando.ExecuteScalar();
                if (contador > 0)
                {
                    // encuentra el usuario, guarda el nombre en la sesión
                    Sesion.UsuarioActual = usuario;
                    return true;  // usuario valido
                }
                else
                {
                    return false;  // usuario/contra incorrecto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación: " + ex.Message);
                return false;
            }
        }
        public static class Sesion
        {
            public static string UsuarioActual { get; set; }  // es para guardar el usuario para despues filtrar x usuario q ingreso o  por todos
        }
        public void ListarTareas(DataGridView dgvTareas, string estado)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Tareas WHERE Estado = @Estado";
                comando.Parameters.AddWithValue("@Estado", estado);
                conexion.Open();

                //Ejecuta la consulta y devuelve el datareader con los resultados
                DataTable tablaTareas = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaTareas);

                dgvTareas.DataSource = tablaTareas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListarTareasUsuario(DataGridView dgvTareas, string estado)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Tareas WHERE Usuario = @Usuario AND Estado = @Estado";

                int idUsuario = IdUsuario();
                comando.Parameters.AddWithValue("@Usuario", idUsuario);
                comando.Parameters.AddWithValue("@Estado", estado);
                conexion.Open();

                //Ejecuta la consulta y devuelve el datareader con los resultados
                DataTable tablaContactos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaContactos);

                dgvTareas.DataSource = tablaContactos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int IdUsuario()
        {
            int idUsuario = -1;
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string consulta = "SELECT id_Usuario FROM Usuarios WHERE Nombre = @Nombre";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", Sesion.UsuarioActual);
                        conexion.Open();
                        object resultado = comando.ExecuteScalar();
                        if (resultado != null)
                        {
                            idUsuario = Convert.ToInt32(resultado);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del usuario: " + ex.Message);
            }
            return idUsuario;
        }
    }
}
