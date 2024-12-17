using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormMenu : Form
    {
        private Usuarios usuarioActual;
        public FormMenu(Usuarios user)
        {
            InitializeComponent();
            usuarioActual = user;
            label1.Text = usuarioActual.Nombre;
        }

        public void FormMenu_Load(object sender, EventArgs e)
        {
            List<Productos> listaProductos;
            List<string> listaImagenes = new List<string>();
            DataBase baseDatos = new DataBase();
            listaProductos = baseDatos.consulta();
            lblHoraFecha.Text = DateTime.Now.ToString("dd/MM/yyyy\n HH:mm:ss");
            foreach (var producto in listaProductos)
            {
                listaImagenes.Add(producto.NombreImg);
            }
            CargarImagenesYTextoFlowLayoutPanel(listaProductos);
        }

        private List<(Productos producto, int cantidad)> carrito = new List<(Productos producto, int cantidad)>();

        private void CargarImagenesYTextoFlowLayoutPanel(List<Productos> listaProductos)
        {
            string carpetaImagenes = "imagenes";
            string rutaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, carpetaImagenes);

            foreach (var producto in listaProductos)
            {
                try
                {
                    Panel panelProducto = new Panel
                    {
                        Width = 220,
                        Height = 225,
                        Margin = new Padding(0),
                    };

                    PictureBox cuadroImagen = new PictureBox
                    {
                        Image = System.Drawing.Image.FromFile(Path.Combine(rutaImagenes, producto.NombreImg)),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 220,
                        Height = 225,
                        Dock = DockStyle.Fill,
                    };

                    Label etiquetaDescripcion = new Label
                    {
                        Text = producto.Descripcion,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.Black,
                        Font = new Font("SugarPieW00-Regular", 10, FontStyle.Italic),
                        BackColor = Color.Transparent,
                        Width = 220,
                        Height = 65,
                        Dock = DockStyle.Bottom,
                    };

                    Button botonInformacion = new Button
                    {
                        Text = "",
                        Size = new Size(25, 25),
                        Location = new Point(20, 5),
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = System.Drawing.Image.FromFile(Path.Combine(rutaImagenes, "info.png")),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    botonInformacion.FlatAppearance.BorderSize = 0;

                    botonInformacion.Click += (s, e) =>
                    {
                        Panel panelInfo = CrearPanelInformacionProducto(producto);
                        panelInfo.Location = new Point(130, 280);
                        this.Controls.Add(panelInfo);
                        panelInfo.BringToFront();
                    };

                    Button botonAgregarCarrito = new Button
                    {
                        Text = "",
                        Size = new Size(25, 25),
                        Location = new Point(170, 5),
                        BackColor = Color.Green,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = System.Drawing.Image.FromFile(Path.Combine(rutaImagenes, "carrito.png")),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    botonAgregarCarrito.FlatAppearance.BorderSize = 0;

                    int cantidadExistente = producto.Exist;
                    botonAgregarCarrito.Click += (s, e) =>
                    {
                        if (producto.Exist > 0 && cantidadExistente > 0)//Revisa si hay unidades del producto
                        {
                            cantidadExistente--;
                            AgregarAlCarrito(producto);
                        }
                        else MessageBox.Show("Los sentimos, no puedes agregar este producto a tu compra.");
                    };

                    panelProducto.Controls.Add(botonAgregarCarrito);
                    cuadroImagen.Controls.Add(etiquetaDescripcion);
                    panelProducto.Controls.Add(botonInformacion);
                    panelProducto.Controls.Add(cuadroImagen);
                    flowLayoutPanelImages.Controls.Add(panelProducto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen o texto: {producto.Descripcion}\n{ex.Message}");
                }
            }
        }


        private void AgregarAlCarrito(Productos producto)
        {
            var indiceExistente = carrito.FindIndex(p => p.producto.Descripcion == producto.Descripcion);
            if (indiceExistente >= 0)
            {
                carrito[indiceExistente] = (carrito[indiceExistente].producto, carrito[indiceExistente].cantidad + 1);
            }
            else
            {
                carrito.Add((producto, 1));
            }
            MostrarCarrito(carrito);
            ActualizarTotal();
        }

        private Panel CrearPanelInformacionProducto(Productos producto)
        {
            Panel panelInfo = new Panel
            {
                Width = 220,
                Height = 100,
                Margin = new Padding(0),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Chartreuse,
            };

            Label etiquetaPrecio = new Label
            {
                Text = $"Precio: {producto.Precio:C}",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("Impact", 10, FontStyle.Italic),
                Width = 220,
                Height = 30,
                Dock = DockStyle.Top
            };

            Label etiquetaStock = new Label
            {
                Text = $"Unidades: {producto.Exist}",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black,
                Font = new Font("SugarPieW00-Regular", 10, FontStyle.Italic),
                Width = 220,
                Height = 30,
                Dock = DockStyle.Top
            };

            Button botonCerrar = new Button
            {
                Text = "Cerrar",
                Size = new Size(60, 30),
                Location = new Point(80, 60),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
            };
            botonCerrar.FlatAppearance.BorderSize = 0;
            botonCerrar.Click += (s, e) => panelInfo.Visible = false;

            panelInfo.Controls.Add(etiquetaPrecio);
            panelInfo.Controls.Add(etiquetaStock);
            panelInfo.Controls.Add(botonCerrar);
            return panelInfo;
        }

        private void MostrarCarrito(List<(Productos producto, int cantidad)> listaCarrito)
        {
            flowLayoutPanelCarrito.Controls.Clear();
            string carpetaImagenes = "imagenes";
            string rutaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, carpetaImagenes);

            foreach (var item in listaCarrito)
            {
                try
                {
                    string nombreImagenCarrito = "1" + item.producto.NombreImg;
                    Panel panel = new Panel
                    {
                        Width = 450,
                        Height = 75,
                        Margin = new Padding(0),
                        BackgroundImage = System.Drawing.Image.FromFile(Path.Combine(rutaImagenes, nombreImagenCarrito)),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    Label etiquetaNombre = new Label
                    {
                        Text = item.producto.Descripcion,
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White,
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Italic),
                        Width = 200,
                        Height = 20,
                        Dock = DockStyle.Top
                    };

                    Label etiquetaPrecio = new Label
                    {
                        Text = $"Precio: {(item.producto.Precio * item.cantidad):C}",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White,
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Italic),
                        Width = 200,
                        Height = 20,
                        Dock = DockStyle.Top
                    };

                    Label etiquetaCantidad = new Label
                    {
                        Text = $"Cantidad: {item.cantidad}",
                        AutoSize = false,
                        TextAlign = ContentAlignment.BottomCenter,
                        ForeColor = Color.White,
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Italic),
                        Width = 200,
                        Height = 25,
                        Dock = DockStyle.Top
                    };

                    Button botonEliminar = new Button
                    {
                        Text = "Eliminar",
                        Size = new Size(80, 30),
                        Location = new Point(350, 20),
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    botonEliminar.FlatAppearance.BorderSize = 0;
                    botonEliminar.Click += (s, e) =>
                    {
                        carrito.Remove(item);
                        MostrarCarrito(carrito);
                        ActualizarTotal();
                    };

                    panel.Controls.Add(botonEliminar);
                    panel.Controls.Add(etiquetaNombre);
                    panel.Controls.Add(etiquetaPrecio);
                    panel.Controls.Add(etiquetaCantidad);
                    flowLayoutPanelCarrito.Controls.Add(panel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el producto en el carrito: {item.producto.Descripcion}\n{ex.Message}");
                }
            }
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresoUsuario f1 = new FormIngresoUsuario();
            f1.ShowDialog();
            this.Close();
        }

        private void MostrarCuenta()
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarCuenta();
            panel1.BringToFront();
        }

        private void pictureBoxCarrito_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelCarrito.Visible == false)
            {
                flowLayoutPanelCarrito.Visible = true;
                flowLayoutPanelImages.Visible = false;
                textBoxTotal.Visible = true;
                buttonComprar.Visible = true;
                pictureBoxCarrito.BorderStyle = BorderStyle.Fixed3D;
                textBoxCupon.Visible = true;
                buttonAddCupon.Visible = true;
            }
            else
            {
                flowLayoutPanelCarrito.Visible = false;
                flowLayoutPanelImages.Visible = true;
                textBoxTotal.Visible = false;
                buttonComprar.Visible = false;
                pictureBoxCarrito.BorderStyle = BorderStyle.None;
                textBoxCupon.Visible = false;
                buttonAddCupon.Visible = false;
            }
        }
        private void ActualizarTotal()
        {
            double total = carrito.Sum(item => item.producto.Precio * item.cantidad);
            textBoxTotal.Text = total.ToString("C");
        }

        private double descuentoAplicado = 0.0;

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (carrito.Count == 0)
                {
                    MessageBox.Show("El carrito está vacío. Agregue productos antes de realizar una compra.", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                // Sumar el monto total
                double total = carrito.Sum(item => item.producto.Precio * item.cantidad);
                if (descuentoAplicado > 0)
                {
                    total -= total * descuentoAplicado;
                }
                double totalConImpuesto = total + (total * 0.06);
                int totalPlayeras = carrito.Sum(item => item.cantidad);



                // Instancia de la base de datos
                DataBase db = new DataBase();

                // Actualizar la base de datos del usuario
                bool usuarioActualizado = db.ActualizarMontoUsuario(usuarioActual.Id, total);

                if (!usuarioActualizado)
                {
                    MessageBox.Show("Hubo un problema al actualizar el monto del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool ventaRegistrada = db.RegistrarVenta(usuarioActual.Id, total, totalPlayeras);

                if (!ventaRegistrada)
                {
                    MessageBox.Show("Hubo un problema al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar las existencias de productos en la base de datos
                foreach (var item in carrito)
                {
                    bool productoActualizado = db.ReducirExistenciasProducto(item.producto.Id, item.cantidad);

                    if (!productoActualizado)
                    {
                        MessageBox.Show($"Hubo un problema al actualizar las existencias del producto: {item.producto.Descripcion}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                FormNotaCompra resumenCompra = new FormNotaCompra(DateTime.Now, carrito, totalConImpuesto);
                resumenCompra.ShowDialog();

                // Limpiar el carrito después de la compra
                carrito.Clear();
                MostrarCarrito(carrito);
                ActualizarTotal();
                RefrescarDatos();



                MessageBox.Show("Compra realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error durante la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarDatos()
        {
            try
            {
                // Recargar los productos desde la base de datos
                DataBase db = new DataBase();
                List<Productos> productosActualizados = db.consulta();

                // Actualizar la vista de productos
                flowLayoutPanelImages.Controls.Clear(); // Limpiar los datos actuales
                CargarImagenesYTextoFlowLayoutPanel(productosActualizados);

                // Opcional: Recargar el total del carrito si es necesario
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cuponIngresado = textBoxCupon.Text.Trim();

                if (string.IsNullOrEmpty(cuponIngresado))
                {
                    MessageBox.Show("Por favor, ingrese un código de cupón.", "Cupón vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lista de cupones válidos y sus descuentos (esto puede venir de una base de datos)
                Dictionary<string, double> cuponesValidos = new Dictionary<string, double>
                {
                    { "NAVIDAD", 0.30 },
                };

                if (cuponesValidos.TryGetValue(cuponIngresado.ToUpper(), out double descuento))
                {
                    descuentoAplicado = descuento;
                    // Aplicar el descuento
                    double total = carrito.Sum(item => item.producto.Precio * item.cantidad);
                    double totalConDescuento = total - (total * descuento);
                    total = totalConDescuento;

                    textBoxTotal.Text = totalConDescuento.ToString("C");

                    MessageBox.Show($"El cupón se aplicó correctamente. Descuento del {descuento * 100:F0}%.", "Cupón válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cupón ingresado no es válido. Intente nuevamente.", "Cupón inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al aplicar el cupón: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCerrarDescuento_Click(object sender, EventArgs e)
        {
            pictureBoxDescuento.Visible = false;
            buttonCerrarDescuento.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreQueja.Text.Trim();
            string apellido = textBoxApellidoQueja.Text.Trim();
            string texto = richTextBoxQueja.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insertar los datos en la base de datos
            DataBase db = new DataBase();
            db.InsertarQueja(nombre, apellido, texto);
            db.Disconnect();

            // Limpiar los campos después de la inserción
            
            textBoxNombreQueja.Clear();
            textBoxApellidoQueja.Clear();
            richTextBoxQueja.Clear();
        }

        private void pictureBoxQuejas_Click(object sender, EventArgs e)
        {
            if (panelQuejas.Visible == true)
            {
                panelQuejas.Visible = false;
            }
            else
            {
                panelQuejas.Visible=true;
            }
        }
    }
}
