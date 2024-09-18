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
    }
}
