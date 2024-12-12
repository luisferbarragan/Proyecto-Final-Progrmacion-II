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
    public partial class FormMenu : Form
    {
        public FormMenu(Usuarios user)
        {
            InitializeComponent();
            Usuarios usuarioActual = user;
            label1.Text = usuarioActual.Nombre;
        }

        public void FormMenu_Load(object sender, EventArgs e)
        {
            List<Productos> listado;
            List<string> imagenes = new List<string>();
            DataBase obj = new DataBase();
            listado = obj.consulta();
            FormIngresoUsuario f1 = new FormIngresoUsuario();
            foreach (var p in listado)
            {
                imagenes.Add(p.NombreImg); // Add image paths to the list
            }
            LoadImagesAndTextToFlowLayoutPanel(listado);

        }

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
                        ForeColor = Color.White, // Set the text color for better visibility
                        Font = new Font("SugarPieW00-Regular", 10, FontStyle.Italic), // Optional: Customize the font
                        BackColor = Color.Transparent, // Set the background to transparent
                        Width = 220, // Match the width of the PictureBox
                        Height = 65, // Set a fixed height for the label
                        Dock = DockStyle.Bottom, // Position the label at the top
                    };

                    Button button = new Button
                    {
                        Text = "Info", // Change the label to "Info"
                        Size = new Size(50, 25), // Set the size of the button
                        Location = new Point(5, 5), // Position at the top-left corner of the panel
                        BackColor = Color.White, // Set the button color
                        ForeColor = Color.Black, // Set the text color
                        FlatStyle = FlatStyle.Flat, // Optional: Flat style for modern look
                    };
                    button.FlatAppearance.BorderSize = 0; // Remove the border

                    // Add a click event handler to the button
                    button.Click += (s, e) =>
                    {
                        Panel infoPanel = CreateProductInfoPanel(producto);
                        infoPanel.Location = new Point(130,280);
                        this.Controls.Add(infoPanel);
                        infoPanel.BringToFront();
                    };

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
                Font = new Font("Impact", 10, FontStyle.Italic),
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
        }
    }
}
