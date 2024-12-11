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
        public FormMenu()
        {
            InitializeComponent();
        }

        public void FormMenu_Load(object sender, EventArgs e)
        {
            List<Productos> listado;
            List<string> imagenes = new List<string>();
            DataBase obj = new DataBase();
            listado = obj.consulta();
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
                        ForeColor = Color.Black, // Set the text color for better visibility
                        Font = new Font("Arial", 10, FontStyle.Bold), // Optional: Customize the font
                        BackColor = Color.Transparent, // Set the background to transparent
                        Width = 220, // Match the width of the PictureBox
                        Height = 50, // Set a fixed height for the label
                        Dock = DockStyle.Bottom, // Position the label at the top
                    };

                    Button button = new Button
                    {
                        Text = "X", // Add a simple label for the button
                        Size = new Size(25, 25), // Set the size of the button
                        Location = new Point(5, 5), // Position at the top-left corner of the panel
                        BackColor = Color.Red, // Set the button color
                        ForeColor = Color.White, // Set the text color
                        FlatStyle = FlatStyle.Flat, // Optional: Flat style for modern look
                    };
                    button.FlatAppearance.BorderSize = 0; // Remove the border

                    // Add a click event handler to the button
                    button.Click += (s, e) =>
                    {
                        // Remove the panel from the FlowLayoutPanel
                        flowLayoutPanelImages.Controls.Remove(panel);
                        MessageBox.Show($"Removed: {producto.Descripcion}");
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresoUsuario f1 = new FormIngresoUsuario();
            f1.ShowDialog();
            this.Close();
        }
    }
}
