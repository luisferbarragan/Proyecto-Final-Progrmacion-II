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
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormAdmin : Form
    {
        List<Productos> listado;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void cargarGrafica(object sender, EventArgs e)
        {
            DataBase obj = new DataBase();
            listado = obj.consulta();

            var plotView1 = new PlotView
            {
                Dock = DockStyle.Fill,
            };
            var model = new PlotModel { Title = "Inventario", Padding = new OxyThickness(100, 100, 100, 100) };
            var pieSeries = new PieSeries
            {
                StrokeThickness = 1.0,
                AngleSpan = 360,
                StartAngle = 0,
                InsideLabelPosition = 1,
                OutsideLabelFormat = "{1}: {0} %",
                InsideLabelFormat = string.Empty,
                FontSize = 12,
            };

            var random = new Random();

            listado.ForEach(p =>
            {
                var color = OxyColor.FromRgb(
                (byte)random.Next(0, 256),
                (byte)random.Next(0, 256),
                (byte)random.Next(0, 256)
                );
                pieSeries.Slices.Add(new PieSlice(p.NombreImg.Remove(p.NombreImg.Length - 4, 4), p.Exist) { Fill = color });
            });

            // Añadir la serie al modelo
            model.Series.Add(pieSeries);
            // Asignar el modelo al PlotView
            plotView1.Model = model;
            tabPage6.Controls.Add(plotView1);
            obj.Disconnect();
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
            this.panelConfirmarBaja.Visible = true;
            Productos aux = obj.consultaPorId(Convert.ToInt32(this.txtEliminar.Text));
            if (aux != null)
            {
                richTextBoxBaja.AppendText($"ID: {aux.Id}\n");
                richTextBoxBaja.AppendText($"Nombre Imagen: {aux.NombreImg}\n");
                richTextBoxBaja.AppendText($"Descripción: {aux.Descripcion}\n");
                richTextBoxBaja.AppendText($"Precio: {aux.Precio}\n");
                richTextBoxBaja.AppendText($"Existencias: {aux.Exist}\n\n");
            }
            else
            {
                richTextBoxBaja.AppendText("Producto no encontrado.\n\n");
            }
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

        private void btnCargar_Click(object sender, EventArgs e)//Listado Normal
        {
            DataBase obj = new DataBase();
            listado = obj.consulta();
            this.richTextBoxListado.Clear();
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

        private void btnCargarRichTxt2_Click(object sender, EventArgs e)//Lista Ordenada por Existencias
        {
            DataBase obj = new DataBase();
            listado = obj.consulta();
            var listaOrdenada = listado.OrderBy(p => p.Exist).ToList();
            this.richTextBoxOrdenadaPorExist.Clear();

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

            obj.Disconnect();
        }

        private void buttonMostrarTotalVentas_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            try
            {
                double totalVentas = db.ObtenerTotalVentas();
                textBoxTotalVentas.Text = totalVentas.ToString("C");
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.richTextBoxBaja.Clear();
            this.panelConfirmarBaja.Visible = false;
            this.txtEliminar.Text = "";
            this.txtEliminar.PlaceholderText = "id eliminar";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            DataBase obj = new DataBase();
            listado = obj.consulta();
            obj.eliminar(Convert.ToInt32(this.txtEliminar.Text));
            this.txtEliminar.PlaceholderText = "id eliminar";
            this.panelConfirmarBaja.Visible = false;
            obj.Disconnect();
        }
    }
}
