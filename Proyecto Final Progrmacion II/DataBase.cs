using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Progrmacion_II
{
    public class DataBase
    {
        private MySqlConnection connection;

        public DataBase()
        {
            this.Connect();
        }
        public void Connect()
        {
            string cadena = "Server=localhost;Port=33065;Database=overcatbd;User=root;Password=;SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Usuarios consultarUsuarioContra(string cuenta, string contrasena)
        {
            Usuarios aux = null;
            int id;
            string nombre;
            int monto;
            try
            {
                string query = "SELECT id, nombre, monto FROM usuarios WHERE cuenta = @cuenta AND contrasena = @contrasena;";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@cuenta", cuenta);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32("id");
                    nombre = reader.GetString("nombre");
                    monto = reader.GetInt32("monto");

                    aux = new Usuarios
                    {
                        Id = id,
                        Nombre = nombre,
                        Monto = monto
                    };
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la base de datos: {ex.Message}");
            }
            return aux;
        }
    }
}

