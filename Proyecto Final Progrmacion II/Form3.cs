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
            List<Productos> listado;
            List<string> imagenes = new List<string>();
            DataBase obj = new DataBase();
            listado = obj.consulta();
            FormIngresoUsuario f1 = new FormIngresoUsuario();
            lblHoraFecha.Text = DateTime.Now.ToString("dd/MM/yyyy\n HH:mm:ss");
            foreach (var p in listado)
            {
                imagenes.Add(p.NombreImg); // Add image paths to the list
            }
            LoadImagesAndTextToFlowLayoutPanel(listado);

        }

        private List<(Productos producto, int cantidad)> cart = new List<(Productos producto, int cantidad)>();

        private void LoadImagesAndTextToFlowLayoutPanel(List<Productos> productos)
        {
            // Define the relative folder containing the images
            string imagesFolder = "imagenes"; // Replace with the folder name that contains the images
            string imagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagesFolder);

            foreach (var producto in productos)
            {
                try
                {
                    // Create a Panel to hold the image and text
                    Panel panel = new Panel
                    {
                        Width = 220, // Set width
                        Height = 225, // Set height
                        Margin = new Padding(0), // Add some spacing
                        //BorderStyle = BorderStyle.FixedSingle // Optional: Add a border for better visual separation
                    };

                    // Create a PictureBox for the image
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(Path.Combine(imagesPath, producto.NombreImg)), // Load image from the constructed path
                        SizeMode = PictureBoxSizeMode.StretchImage, // Adjust image scaling
                        Width = 220, // Set desired width
                        Height = 225, // Set desired height
                        Dock = DockStyle.Fill, // Fill the panel with the image
                    };

                    // Create a Label for the text
                    Label label = new Label
                    {
                        Text = producto.Descripcion, // Use the text from the database
                        AutoSize = false, // Allow custom width/height
                        TextAlign = ContentAlignment.MiddleCenter, // Center align the text
                        ForeColor = Color.Black, // Set the text color for better visibility
                        Font = new Font("SugarPieW00-Regular", 10, FontStyle.Italic), // Optional: Customize the font
                        BackColor = Color.Transparent, // Set the background to transparent
                        Width = 220, // Match the width of the PictureBox
                        Height = 65, // Set a fixed height for the label
                        Dock = DockStyle.Bottom, // Position the label at the top
                    };

                    Button button = new Button
                    {
                        Text = "", // Change the label to "Info"
                        Size = new Size(25, 25), // Set the size of the button
                        Location = new Point(20, 5), // Position at the top-left corner of the panel
                        BackColor = Color.White, // Set the button color
                        ForeColor = Color.Black, // Set the text color
                        FlatStyle = FlatStyle.Flat, // Optional: Flat style for modern look
                        BackgroundImage = Image.FromFile(Path.Combine(imagesPath, "info.png")),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    button.FlatAppearance.BorderSize = 0; // Remove the border

                    // Add a click event handler to the button
                    button.Click += (s, e) =>
                    {
                        Panel infoPanel = CreateProductInfoPanel(producto);
                        infoPanel.Location = new Point(130, 280);
                        this.Controls.Add(infoPanel);
                        infoPanel.BringToFront();
                    };

                    Button addToCartButton = new Button
                    {
                        Text = "",
                        Size = new Size(25, 25),
                        Location = new Point(170, 5),
                        BackColor = Color.Green,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = Image.FromFile(Path.Combine(imagesPath, "carrito.png")),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    addToCartButton.FlatAppearance.BorderSize = 0;
                    addToCartButton.Click += (s, e) => AddToCart(producto);

                    panel.Controls.Add(addToCartButton);
                    // Add the Label and Button to the PictureBox
                    pictureBox.Controls.Add(label);

                    // Add the Button to the Panel
                    panel.Controls.Add(button);

                    // Add the PictureBox to the Panel
                    panel.Controls.Add(pictureBox);

                    // Add the Panel to the FlowLayoutPanel
                    flowLayoutPanelImages.Controls.Add(panel);
                }
                catch (Exception ex)
                {
                    // Handle any errors (e.g., file not found)
                    MessageBox.Show($"Error loading image or text for: {producto.Descripcion}\n{ex.Message}");
                }
            }
        }

        private void AddToCart(Productos producto)
        {
            // Check if the product is already in the cart
            var existingProductIndex = cart.FindIndex(p => p.producto.Descripcion == producto.Descripcion);

            if (existingProductIndex >= 0)
            {
                // Increase the quantity if the product already exists in the cart
                //existingProduct.cantidad++;
                cart[existingProductIndex] = (cart[existingProductIndex].producto, cart[existingProductIndex].cantidad + 1);
            }
            else
            {
                // Add a new product to the cart with an initial quantity of 1
                cart.Add((producto, 1));
            }

            // Optionally, update the cart view immediately
            mostrarProductoFlowLayoutCarrito(cart);
            ActualizarTotal();
        }

        private Panel CreateProductInfoPanel(Productos producto)
        {
            Panel infoPanel = new Panel
            {
                Width = 220,
                Height = 100,
                Margin = new Padding(0),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label priceLabel = new Label
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

            Label stockLabel = new Label
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

            Button closeButton = new Button
            {
                Text = "Cerrar",
                Size = new Size(60, 30),
                Location = new Point(80, 60),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            closeButton.FlatAppearance.BorderSize = 1;
            closeButton.Click += (s, e) => infoPanel.Visible = false;

            infoPanel.Controls.Add(priceLabel);
            infoPanel.Controls.Add(stockLabel);
            infoPanel.Controls.Add(closeButton);

            return infoPanel;
        }

        private void mostrarProductoFlowLayoutCarrito(List<(Productos producto, int cantidad)> productosEnCarrito)
        {
            flowLayoutPanelCarrito.Controls.Clear(); // Clear existing controls to avoid duplicates
            string imagesFolder = "imagenes"; // Replace with the folder name that contains the images
            string imagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagesFolder);

            foreach (var item in productosEnCarrito)
            {
                try
                {
                    string nombreImgCarrito = "1" + item.producto.NombreImg;
                    // Create a Panel to hold the product info
                    Panel panel = new Panel
                    {
                        Width = 450, // Set width
                        Height = 75, // Set height
                        Margin = new Padding(0), // Add some spacing
                        BackgroundImage = Image.FromFile(Path.Combine(imagesPath, nombreImgCarrito)), // Set the background image
                        BackgroundImageLayout = ImageLayout.Stretch // Stretch the image to fit the 
                    };

                    // Create a Label for the product name
                    Label nameLabel = new Label
                    {
                        Text = item.producto.Descripcion, // Use the product name
                        AutoSize = false, // Allow custom width/height
                        TextAlign = ContentAlignment.MiddleCenter, // Center align the text
                        ForeColor = Color.White, // Set the text color
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Italic), // Customize the font
                        Width = 200, // Match the width of the panel
                        Height = 20, // Set a fixed height for the label
                        Dock = DockStyle.Top // Position the label at the top
                    };

                    // Create a Label for the product price
                    Label priceLabel = new Label
                    {
                        Text = $"Precio: {(item.producto.Precio * item.cantidad):C}", // Use the product price
                        AutoSize = false, // Allow custom width/height
                        TextAlign = ContentAlignment.MiddleCenter, // Center align the text
                        ForeColor = Color.White, // Set the text color
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Italic), // Customize the font
                        Width = 200, // Match the width of the panel
                        Height = 20, // Set a fixed height for the label
                        Dock = DockStyle.Top // Position the label below the name
                    };

                    // Create a Label for the product quantity
                    Label quantityLabel = new Label
                    {
                        Text = $"Cantidad: {item.cantidad}", // Use the product stock
                        AutoSize = false, // Allow custom width/height
                        TextAlign = ContentAlignment.BottomCenter, // Center align the text
                        ForeColor = Color.White, // Set the text color
                        BackColor = Color.Transparent,
                        Font = new Font("Arial", 10, FontStyle.Italic), // Customize the font
                        Width = 200, // Match the width of the panel
                        Height = 25, // Set a fixed height for the label
                        Dock = DockStyle.Top // Position the label below the price
                    };

                    // Create a Button to remove the product from the cart
                    Button removeButton = new Button
                    {
                        Text = "Eliminar",
                        Size = new Size(80, 30),
                        Location = new Point(350, 20), // Position within the panel
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };
                    removeButton.FlatAppearance.BorderSize = 0;

                    // Add a click event handler to remove the product from the cart
                    removeButton.Click += (s, e) =>
                    {
                        cart.Remove(item); // Remove the product from the list
                        mostrarProductoFlowLayoutCarrito(cart); // Refresh the cart view
                        ActualizarTotal();
                    };

                    // Add the controls to the panel
                    panel.Controls.Add(removeButton);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(priceLabel);
                    panel.Controls.Add(quantityLabel);
                    flowLayoutPanelCarrito.Controls.Add(panel);
                }
                catch (Exception ex)
                {
                    // Handle any errors (e.g., missing data)
                    MessageBox.Show($"Error loading cart item: {item.producto.Descripcion}\n{ex.Message}");
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
            }
            else
            {
                flowLayoutPanelCarrito.Visible = false;
                flowLayoutPanelImages.Visible = true;
                textBoxTotal.Visible = false;
                buttonComprar.Visible = false;
                pictureBoxCarrito.BorderStyle = BorderStyle.None;
            }
        }
        private void ActualizarTotal()
        {
            double total = cart.Sum(item => item.producto.Precio * item.cantidad);
            textBoxTotal.Text = total.ToString("C");
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cart.Count == 0)
                {
                    MessageBox.Show("El carrito está vacío. Agregue productos antes de realizar una compra.", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                // Sumar el monto total
                double total = cart.Sum(item => item.producto.Precio * item.cantidad);
                double totalConImpuesto = total + (total * 0.06);
                int totalPlayeras = cart.Sum(item => item.cantidad);

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
                foreach (var item in cart)
                {
                    bool productoActualizado = db.ReducirExistenciasProducto(item.producto.Id, item.cantidad);

                    if (!productoActualizado)
                    {
                        MessageBox.Show($"Hubo un problema al actualizar las existencias del producto: {item.producto.Descripcion}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                FormNotaCompra resumenCompra = new FormNotaCompra(DateTime.Now, cart, totalConImpuesto);
                resumenCompra.ShowDialog();

                // Limpiar el carrito después de la compra
                cart.Clear();
                mostrarProductoFlowLayoutCarrito(cart);
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
                LoadImagesAndTextToFlowLayoutPanel(productosActualizados);

                // Opcional: Recargar el total del carrito si es necesario
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
