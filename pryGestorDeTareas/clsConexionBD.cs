﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
                comando.CommandText = @"
            SELECT 
                t.id_Tarea,
                t.Titulo, 
                t.Descripcion, 
                u.Nombre AS Usuario, 
                c.Categoria, 
                p.Prioridad, 
                t.Fecha_Vencimiento, 
                t.Estado
            FROM 
                ((Tareas t
                INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario)
                INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad WHERE t.Estado = ?";
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
                comando.CommandText = @"
            SELECT 
                t.id_Tarea,
                t.Titulo, 
                t.Descripcion, 
                u.Nombre AS Usuario, 
                c.Categoria, 
                p.Prioridad, 
                t.Fecha_Vencimiento, 
                t.Estado
            FROM 
                ((Tareas t
                INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario)
                INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad WHERE Usuario = ? AND t.Estado = ?";

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
        public int IdUsuario()
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
        public void ModificarTarea(int idTarea, string titulo, string descripcion, int prioridad, DateTime fechaVen, string estado, int cate, int usuario)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Tareas SET Titulo = ?, Descripcion = ?," +
                    " Prioridad = ?, Fecha_Vencimiento = ?, Estado = ?, Categoria = ?," +
                    " Usuario = ? WHERE id_Tarea = ?";

                comando.Parameters.AddWithValue("@Titulo", titulo);
                comando.Parameters.AddWithValue("@Descripcion", descripcion);
                comando.Parameters.AddWithValue("@Prioridad", prioridad);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVen);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@Categoria", cate);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@id_Tarea", idTarea);


                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha modificado la tarea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la tarea: " + ex.Message, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public void EliminarTarea(int idTarea)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM Tareas WHERE id_Tarea = ?";
                comando.Parameters.AddWithValue("@id_Tarea", idTarea);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado la tarea", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la tarea: " + ex.Message, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        public void CargarUsuarios(DataGridView dgvUsuarios)
        {
            try
            {
                try
                {
                    conexion = new OleDbConnection(cadena);
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = @"
                    SELECT 
                        u.id_Usuario,
                        u.Nombre, 
                        u.Contraseña, 
                        u.Fecha_Creacion, 
                        c.Cargo, 
                        e.Estado
                    FROM 
                        ((Usuarios u
                        INNER JOIN Cargos c ON u.Cargo = c.id_Cargo)
                        INNER JOIN Estados e ON u.Estado = e.id_Estado)";
                    conexion.Open();
                    DataTable tablaUsuarios = new DataTable();

                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(tablaUsuarios);

                    dgvUsuarios.DataSource = tablaUsuarios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        public void EstadosUsuarios(ComboBox cmbEstados)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT id_Estado, Estado FROM Estados";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbEstados.DataSource = dt;
                            cmbEstados.DisplayMember = "Estado";
                            cmbEstados.ValueMember = "id_Estado";
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
        public void CargosUsuarios(ComboBox cmbCargos)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    using (OleDbCommand comando = new OleDbCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT id_Cargo, Cargo FROM Cargos";
                        conexion.Open();

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbCargos.DataSource = dt;
                            cmbCargos.DisplayMember = "Cargo";
                            cmbCargos.ValueMember = "id_Cargo";
                            cmbCargos.SelectedIndex = -1;
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
        public DataTable CargarTareas()
        {
            DataTable datosTareas = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"
            SELECT 
                t.id_Tarea,
                t.Titulo, 
                t.Descripcion, 
                u.Nombre AS Usuario, 
                c.Categoria, 
                p.Prioridad, 
                t.Fecha_Vencimiento, 
                t.Estado
            FROM 
                ((Tareas t
                INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario)
                INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad";

                conexion.Open();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(datosTareas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            return datosTareas;
        }
        public DataTable CargarTareasUsuario()
        {
            DataTable datosTareas = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"
            SELECT 
                t.id_Tarea,
                t.Titulo, 
                t.Descripcion, 
                u.Nombre AS Usuario, 
                c.Categoria, 
                p.Prioridad, 
                t.Fecha_Vencimiento, 
                t.Estado
            FROM 
                ((Tareas t
                INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario)
                INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad WHERE t.Usuario = ?";

                int idUsuario = IdUsuario();
                comando.Parameters.AddWithValue("@Usuario", idUsuario);
                conexion.Open();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(datosTareas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las tareas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datosTareas;
        }
        public DataTable DatosUsuarios(int idUsuario)
        {
            DataTable datosUsuarios = new DataTable();
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = @"
                SELECT 
                    u.id_Usuario,
                    u.Nombre, 
                    u.Contraseña, 
                    u.Fecha_Creacion, 
                    c.Cargo, 
                    e.Estado
                FROM 
                    ((Usuarios u
                    INNER JOIN Cargos c ON u.Cargo = c.id_Cargo)
                    INNER JOIN Estados e ON u.Estado = e.id_Estado) WHERE u.id_Usuario = ?";
                comando.Parameters.AddWithValue("@id_Usuario", idUsuario);
                conexion.Open();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(datosUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            return datosUsuarios;
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
        public void AgregarUsuario(string nombre, string contraseña, DateTime fechaCreacion, int cargo, int estado)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Usuarios (Nombre, Contraseña, Fecha_Creacion, Cargo, Estado) VALUES (?, ?, ?, ?, ?)";
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@Fecha_Creacion", fechaCreacion);
                comando.Parameters.AddWithValue("@Cargo", cargo);
                comando.Parameters.AddWithValue("@Estado", estado);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha agregado el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ModificarUsuario(string nombre, string contraseña, DateTime fechaCreacion, int cargo, int estado, int idUsuario)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Usuarios SET Nombre = ?, Contraseña = ?, Fecha_Creacion = ?, Cargo = ?, Estado = ? WHERE id_Usuario = ?";
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);
                comando.Parameters.AddWithValue("@Fecha_Creacion", fechaCreacion);
                comando.Parameters.AddWithValue("@Cargo", cargo);
                comando.Parameters.AddWithValue("@Estado", estado);
                comando.Parameters.AddWithValue("@id_Usuario", idUsuario);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha modificado el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool VerificarUsuario(string nombre)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = ?";
                comando.Parameters.AddWithValue("@Nombre", nombre);

                conexion.Open();
                int contador = (int)comando.ExecuteScalar();
                return contador > 0;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM Usuarios WHERE id_Usuario = ?";
                comando.Parameters.AddWithValue("@id_Usuario", idUsuario);

                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BuscarCategoria(DataGridView dgvTareas, string cate, string estado)
        {
            try
            {
                try
                {
                    conexion = new OleDbConnection(cadena);
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = @"
                    SELECT 
                        t.id_Tarea,
                        t.Titulo, 
                        t.Descripcion, 
                        p.Prioridad, 
                        t.Fecha_Vencimiento, 
                        t.Estado,
                        c.Categoria,
                        u.Nombre
                    FROM 
                        ((Tareas t
                        INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad)
                        INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                        INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario WHERE c.Categoria = ? AND t.Estado = ?";

                    comando.Parameters.AddWithValue("@Categoria", cate);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    conexion.Open();
                    DataTable tablaTareas = new DataTable();

                    adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(tablaTareas);

                    dgvTareas.DataSource = tablaTareas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BuscarCategoriaUsuario(DataGridView dgvTareas, string cate, string estado)
        {
            try
            {
                try
                {
                    conexion = new OleDbConnection(cadena);
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = @"
                    SELECT 
                        t.id_Tarea,
                        t.Titulo, 
                        t.Descripcion, 
                        p.Prioridad, 
                        t.Fecha_Vencimiento, 
                        t.Estado,
                        c.Categoria,
                        u.Nombre
                    FROM 
                        ((Tareas t
                        INNER JOIN Prioridades p ON t.Prioridad = p.id_Prioridad)
                        INNER JOIN Categorias c ON t.Categoria = c.id_Categoria)
                        INNER JOIN Usuarios u ON t.Usuario = u.id_Usuario WHERE c.Categoria = ? AND t.Estado = ? AND t.Usuario = ?";

                    comando.Parameters.AddWithValue("@Categoria", cate);
                    comando.Parameters.AddWithValue("@Estado", estado);
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
                    MessageBox.Show("Error: " + ex.Message, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
