namespace Proyecto_Final_Progrmacion_II
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrarSesionMenu = new Button();
            flowLayoutPanelImages = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanelCarrito = new FlowLayoutPanel();
            pictureBoxCarrito = new PictureBox();
            textBoxTotal = new TextBox();
            buttonComprar = new Button();
            lblHoraFecha = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarrito).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesionMenu
            // 
            btnCerrarSesionMenu.BackColor = Color.MediumSlateBlue;
            btnCerrarSesionMenu.BackgroundImageLayout = ImageLayout.None;
            btnCerrarSesionMenu.FlatAppearance.BorderSize = 0;
            btnCerrarSesionMenu.FlatStyle = FlatStyle.Flat;
            btnCerrarSesionMenu.ForeColor = Color.WhiteSmoke;
            btnCerrarSesionMenu.Location = new Point(13, 31);
            btnCerrarSesionMenu.Name = "btnCerrarSesionMenu";
            btnCerrarSesionMenu.Size = new Size(91, 23);
            btnCerrarSesionMenu.TabIndex = 0;
            btnCerrarSesionMenu.Text = "Cerrar Sesión";
            btnCerrarSesionMenu.UseVisualStyleBackColor = false;
            btnCerrarSesionMenu.Click += btnCerrarSesion_Click;
            // 
            // flowLayoutPanelImages
            // 
            flowLayoutPanelImages.AutoScroll = true;
            flowLayoutPanelImages.BackgroundImage = Properties.Resources.color1;
            flowLayoutPanelImages.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanelImages.Location = new Point(11, 92);
            flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            flowLayoutPanelImages.Size = new Size(477, 530);
            flowLayoutPanelImages.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chartreuse;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesionMenu);
            panel1.Location = new Point(338, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 61);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Profile1;
            pictureBox1.Location = new Point(413, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanelCarrito
            // 
            flowLayoutPanelCarrito.AutoScroll = true;
            flowLayoutPanelCarrito.BackgroundImage = Properties.Resources.color2;
            flowLayoutPanelCarrito.Location = new Point(11, 92);
            flowLayoutPanelCarrito.Name = "flowLayoutPanelCarrito";
            flowLayoutPanelCarrito.Size = new Size(477, 482);
            flowLayoutPanelCarrito.TabIndex = 4;
            flowLayoutPanelCarrito.Visible = false;
            // 
            // pictureBoxCarrito
            // 
            pictureBoxCarrito.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxCarrito.Image = Properties.Resources.carrito;
            pictureBoxCarrito.Location = new Point(412, 628);
            pictureBoxCarrito.Name = "pictureBoxCarrito";
            pictureBoxCarrito.Size = new Size(40, 40);
            pictureBoxCarrito.TabIndex = 5;
            pictureBoxCarrito.TabStop = false;
            pictureBoxCarrito.Click += pictureBoxCarrito_Click;
            // 
            // textBoxTotal
            // 
            textBoxTotal.BackColor = Color.Chartreuse;
            textBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotal.Enabled = false;
            textBoxTotal.ForeColor = Color.Black;
            textBoxTotal.Location = new Point(338, 583);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(112, 23);
            textBoxTotal.TabIndex = 6;
            textBoxTotal.TextAlign = HorizontalAlignment.Right;
            textBoxTotal.Visible = false;
            // 
            // buttonComprar
            // 
            buttonComprar.BackColor = Color.Chartreuse;
            buttonComprar.FlatStyle = FlatStyle.Flat;
            buttonComprar.Location = new Point(223, 581);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(104, 29);
            buttonComprar.TabIndex = 7;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = false;
            buttonComprar.Visible = false;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // lblHoraFecha
            // 
            lblHoraFecha.AutoSize = true;
            lblHoraFecha.BackColor = Color.Chartreuse;
            lblHoraFecha.BorderStyle = BorderStyle.FixedSingle;
            lblHoraFecha.Location = new Point(16, 634);
            lblHoraFecha.Name = "lblHoraFecha";
            lblHoraFecha.Size = new Size(78, 17);
            lblHoraFecha.TabIndex = 8;
            lblHoraFecha.Text = "Fecha y Hora";
            lblHoraFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pag_principal1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 681);
            Controls.Add(lblHoraFecha);
            Controls.Add(buttonComprar);
            Controls.Add(textBoxTotal);
            Controls.Add(pictureBoxCarrito);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanelCarrito);
            Controls.Add(flowLayoutPanelImages);
            DoubleBuffered = true;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarSesionMenu;
        private FlowLayoutPanel flowLayoutPanelImages;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanelCarrito;
        private PictureBox pictureBoxCarrito;
        private TextBox textBoxTotal;
        private Button buttonComprar;
        private Label lblHoraFecha;
    }
}