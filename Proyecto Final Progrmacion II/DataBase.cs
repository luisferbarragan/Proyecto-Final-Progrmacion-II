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

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public List<Productos> consulta()
        {
            List<Productos> data = new List<Productos>();
            try
            {
                string query = "SELECT id, nombreimg, descripcion, precio, existencias FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Mapear los datos de la consulta a la clase Productos
                    int id = Convert.ToInt32(reader["id"]);
                    string nombreImg = Convert.ToString(reader["nombreimg"]) ?? "";
                    string descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    double precio = Convert.ToDouble(reader["precio"]);
                    int exist = Convert.ToInt32(reader["existencias"]);

                    Productos item = new Productos(id, nombreImg, descripcion, precio, exist);
                    data.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
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

        public void insertar(int idp, string img, string des, double price, int ex)
        {
            string query = "INSERT INTO productos (id, nombreimg, descripcion, precio, existencias) VALUES (@id, @img, @des, @price, @ex)";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@id", idp);
                    cmd.Parameters.AddWithValue("@img", img);
                    cmd.Parameters.AddWithValue("@des", des);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@ex", ex);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Agregado");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
                this.Disconnect();
            }
        }

        public void eliminar(int idp)
        {
            string query = "";
            try
            {
                // Verificar la cantidad de productos en la base de datos
                string countQuery = "SELECT COUNT(*) FROM productos";
                MySqlCommand countCmd = new MySqlCommand(countQuery, connection);
                int totalProductos = Convert.ToInt32(countCmd.ExecuteScalar());

                if (totalProductos <= 6)
                {
                    MessageBox.Show("No se puede eliminar el producto. Debe haber al menos 6 productos en la base de datos.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si hay más de 6 productos, proceder a eliminar
                query = "DELETE FROM productos WHERE id=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }

        public bool ActualizarMontoUsuario(int idUsuario, double monto)
        {
            try
            {
                string query = "UPDATE usuarios SET monto = monto + @Monto WHERE id = @IdUsuario";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Monto", monto);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el monto del usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ReducirExistenciasProducto(int idProducto, int cantidad)
        {
            try
            {
                string query = "UPDATE productos SET existencias = existencias - @Cantidad WHERE id = @IdProducto AND existencias >= @Cantidad";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@IdProducto", idProducto);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reducir existencias del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RegistrarVenta(int idUsuario, double total, int totalPlayeras)
        {
            try
            {
                string query = "INSERT INTO ventas (idUsuario, total, cantidadPlayeras, fecha) VALUES (@IdUsuario, @Total, @CantidadPlayeras, NOW())";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@Total", total);
                command.Parameters.AddWithValue("@CantidadPlayeras", totalPlayeras);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public double ObtenerTotalVentas()
        {
            double totalVentas = 0;

            try
            {
                string query = "SELECT SUM(total) AS TotalVentas FROM ventas";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read() && !reader.IsDBNull(0))
                {
                    totalVentas = reader.GetDouble("TotalVentas");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el total de ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalVentas;
        }
    }
}

