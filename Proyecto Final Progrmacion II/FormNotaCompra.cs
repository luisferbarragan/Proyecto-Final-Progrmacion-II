using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MimeKit;
using MailKit.Net.Smtp;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormNotaCompra : Form
    {
        public FormNotaCompra(DateTime fechaHora, List<(Productos producto, int cantidad)> productos, double totalConImpuesto)
        {
            InitializeComponent();
            lblFechaHora.Text = fechaHora.ToString("dd/MM/yyyy HH:mm:ss");

 
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("nota.pdf", FileMode.Create));
            doc.Open();
            try
            {
                string logoPath = "arriba.png";
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleToFit(530f, 200f);
                doc.Add(logo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la imagen: " + ex.Message);
            }
            doc.Add(new Paragraph(fechaHora.ToString("dd/MM/yyyy HH:mm:ss")));
            doc.Add(new Paragraph("Reporte de Compra"));
            doc.Add(new Paragraph("Datos de la compra:"));
            doc.Add(new Paragraph("\n"));

            foreach (var item in productos)
            {
                richTextBoxProductos.AppendText(
                    $"Producto: {item.producto.Descripcion}\n" +
                    $"Cantidad: {item.cantidad}\n" +
                    $"Precio Unitario: {item.producto.Precio:C}\n" +
                    $"Subtotal: {(item.producto.Precio * item.cantidad):C}\n\n"
                );
                try
                {
                    doc.Add(new Paragraph("Producto: " + item.producto.Descripcion));
                    doc.Add(new Paragraph("Cantidad: " + item.cantidad));
                    doc.Add(new Paragraph("Precio: " + item.producto.Precio * item.cantidad));
                    doc.Add(new Paragraph("\n"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            doc.Add(new Paragraph("Total (IVA incluido): " + totalConImpuesto));
            try
            {
                string logoPath = "abajo.png";
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleToFit(530f, 200f);
                doc.Add(logo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la imagen: " + ex.Message);
            }
            lblTotalConImpuesto.Text = $"Total con IVA: {totalConImpuesto:C}";
            doc.Close();
            //MessageBox.Show("PDF generado correctamente.");
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCorreo.Text))
            {
                this.Close();
            }
            else
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("OverCat", "luisfer1918650@gmail.com"));
                message.To.Add(new MailboxAddress("Arturop", textBoxCorreo.Text));
                message.Subject = "NOTA DE COMPRA";
                message.Body = new TextPart("plain")
                {
                    Text = "Por favor, encuentra adjunta la nota de compra."
                };

                // Adjuntar archivo
                var attachment = new MimePart("application", "pdf")
                {
                    Content = new MimeContent(File.OpenRead("nota.pdf")),
                    ContentDisposition = new MimeKit.ContentDisposition(MimeKit.ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = "nota.pdf"
                };
                var multipart = new MimeKit.Multipart("mixed") { message.Body, attachment };
                message.Body = multipart;

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Authenticate("luisfer1918650@gmail.com", "wjgg xnwa isyj oozw");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            this.Close();
        }
    }
}
