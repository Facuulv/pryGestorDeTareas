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

                // Aca se llama a la funcion para pasarle el id del usuario
                int idUsuario = IdUsuario();
                comando.Parameters.AddWithValue("@Usuario", idUsuario);
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
        public void ListarTareas(DataGridView dgvTareas)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Tareas WHERE Usuario = @Usuario ORDER BY id_Tarea";

                // Aca se llama a la funcion para pasarle el id del usuario
                int idUsuario = IdUsuario();
                comando.Parameters.AddWithValue("@Usuario", idUsuario);
                conexion.Open();

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
        public void ListarTareas2(DataGridView dgvTareas)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Tareas";
                conexion.Open();

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
        
        public void AgregarTarea(string titulo, string descripcion, int prioridad, DateTime fechaVen, string estado, int cate, int usuario)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Tareas (Titulo, Descripcion, Prioridad, Fecha_Vencimiento, Estado, Categoria, Usuario) VALUES (?, ?, ?, ?, ?, ?, ?)";

                comando.Parameters.AddWithValue("@Titulo", titulo);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Prioridad", prioridad);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVen);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@Categoria", cate);
                comando.Parameters.AddWithValue("@Usuario", usuario);


                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha agregado la tarea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarUsuarios(ComboBox cmbUsuarios)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT id_Usuario, Nombre FROM Usuarios";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbUsuarios.DataSource = dt;
                            cmbUsuarios.DisplayMember = "Nombre";
                            cmbUsuarios.ValueMember = "id_Usuario";
                            cmbUsuarios.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarPrioridades(ComboBox cmbPrioridades)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT id_Prioridad, Prioridad FROM Prioridades";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbPrioridades.DataSource = dt;
                            cmbPrioridades.DisplayMember = "Prioridad";
                            cmbPrioridades.ValueMember = "id_Prioridad";
                            cmbPrioridades.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarCategorias(ComboBox cmbCategorias)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT id_Categoria, Categoria FROM Categorias";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbCategorias.DataSource = dt;
                            cmbCategorias.DisplayMember = "Categoria";
                            cmbCategorias.ValueMember = "id_Categoria";
                            cmbCategorias.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CargarEstados(ComboBox cmbEstados)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT DISTINCT Estado FROM Tareas";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbEstados.DataSource = dt;
                            cmbEstados.DisplayMember = "Estado";
                            cmbEstados.ValueMember = "Estado";
                            cmbEstados.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable CargarDatosTarea(int idTarea)
        {
            DataTable datosTarea = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                // Agregué parentesis pq sino no tomaba los inner join
                comando.CommandText = @"
                    SELECT t.Titulo, t.Descripcion, p.Prioridad, t.Fecha_Vencimiento, t.Estado, c.Categoria, u.Nombre 
                    FROM ((Tareas t INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario) INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                    INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad WHERE t.id_Tarea = ?";                   
                comando.Parameters.AddWithValue("@id_Tarea", idTarea);
                conexion.Open();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(datosTarea);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datosTarea;
        }
        public void ConfirmarTarea(int idTarea, string estado)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Tareas SET Estado = @Estado WHERE id_Tarea = @id_Tarea";

                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@id_Tarea", idTarea);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado de la tarea: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
