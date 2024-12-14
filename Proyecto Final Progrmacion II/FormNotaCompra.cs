using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormNotaCompra : Form
    {
        public FormNotaCompra(DateTime fechaHora, List<(Productos producto, int cantidad)> productos, double totalConImpuesto)
        {
            InitializeComponent();

            // Mostrar la fecha y hora
            lblFechaHora.Text = fechaHora.ToString("dd/MM/yyyy HH:mm:ss");

            // Mostrar los datos de los productos en el RichTextBox
            foreach (var item in productos)
            {
                richTextBoxProductos.AppendText(
                    $"Producto: {item.producto.Descripcion}\n" +
                    $"Cantidad: {item.cantidad}\n" +
                    $"Precio Unitario: {item.producto.Precio:C}\n" +
                    $"Subtotal: {(item.producto.Precio * item.cantidad):C}\n\n"
                );
            }

            // Mostrar el total con el aumento del 6%
            lblTotalConImpuesto.Text = $"Total con IVA: {totalConImpuesto:C}";
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
