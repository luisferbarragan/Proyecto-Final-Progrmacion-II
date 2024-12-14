using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormAdmin : Form
    {
        List<Productos> listado;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            this.txtAgregarId.PlaceholderText = "ID";
            this.txtAgregarNombreImg.PlaceholderText = "Nombre Imagen";
            this.txtAgregarDescripcion.PlaceholderText = "Descripcion";
            this.txtAgregarPrecio.PlaceholderText = "Precio";
            this.txtAgregarExist.PlaceholderText = "Existencias";

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataBase obj = new DataBase();
            obj.eliminar(Convert.ToInt32(this.txtEliminar.Text));
            this.txtEliminar.PlaceholderText = "id eliminar";
            obj.Disconnect();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id;
            string nombreImg;
            string descripcion;
            double precio;
            int exist;

            id = Convert.ToInt32(this.txtAgregarId.Text);
            nombreImg = this.txtAgregarNombreImg.Text;
            descripcion = this.txtAgregarDescripcion.Text;
            precio = Convert.ToDouble(this.txtAgregarPrecio.Text);
            exist = Convert.ToInt32(this.txtAgregarExist.Text);
            DataBase obj = new DataBase();
            obj.insertar(id, nombreImg, descripcion, precio, exist);
            limpiar();
            obj.Disconnect();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataBase obj = new DataBase();
            listado = obj.consulta();

            listado.ForEach(p =>
            {
                this.richTextBoxListado.AppendText("ID: " + p.Id + "\nNombre Imagen: " + p.NombreImg + "\nDescripcion: " + p.Descripcion + "\nPrecio: " + p.Precio +
                    "\nExistencias: " + p.Exist + "\n\n");
            });

            obj.Disconnect();

        }

        private void btnCerrarSesionAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresoUsuario f1 = new FormIngresoUsuario();
            f1.ShowDialog();
            this.Close();
        }

        private void btnCargarRichTxt2_Click(object sender, EventArgs e)
        {
            DataBase obj = new DataBase();
            listado = obj.consulta(); // Obtener los datos de la base de datos

            // Ordenar la lista por existencias de menor a mayor
            var listaOrdenada = listado.OrderBy(p => p.Exist).ToList();

            // Limpiar el RichTextBox antes de mostrar los registros
            this.richTextBoxOrdenadaPorExist.Clear();

            // Mostrar los registros ordenados en el RichTextBox
            listaOrdenada.ForEach(p =>
            {
                this.richTextBoxOrdenadaPorExist.AppendText(
                    $"ID: {p.Id}\n" +
                    $"Nombre Imagen: {p.NombreImg}\n" +
                    $"Descripción: {p.Descripcion}\n" +
                    $"Precio: {p.Precio}\n" +
                    $"Existencias: {p.Exist}\n\n"
                );
            });

            obj.Disconnect(); // Cerrar la conexión con la base de datos
        }

        private void buttonMostrarTotalVentas_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            try
            {
                double totalVentas = db.ObtenerTotalVentas();

                // Mostrar el total en un TextBox (asegúrate de tener un TextBox, por ejemplo, llamado txtTotalVentas)
                textBoxTotalVentas.Text = totalVentas.ToString("C"); // Formato de moneda
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar el total de ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Disconnect();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
