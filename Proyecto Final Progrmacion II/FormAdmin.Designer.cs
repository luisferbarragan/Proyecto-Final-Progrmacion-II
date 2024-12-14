namespace Proyecto_Final_Progrmacion_II
{
    partial class FormAdmin
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
            btnEliminar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtEliminar = new TextBox();
            tabPage2 = new TabPage();
            txtAgregarId = new TextBox();
            txtAgregarNombreImg = new TextBox();
            txtAgregarDescripcion = new TextBox();
            txtAgregarPrecio = new TextBox();
            txtAgregarExist = new TextBox();
            btnAgregar = new Button();
            tabPage3 = new TabPage();
            btnCargar = new Button();
            richTextBoxListado = new RichTextBox();
            tabPage4 = new TabPage();
            btnCargarRichTxt2 = new Button();
            richTextBoxOrdenadaPorExist = new RichTextBox();
            tabPage5 = new TabPage();
            buttonMostrarTotalVentas = new Button();
            textBoxTotalVentas = new TextBox();
            btnCerrarSesionAdmin = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Chartreuse;
            btnEliminar.Location = new Point(156, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(38, 135);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(390, 447);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.color2oscuro;
            tabPage1.Controls.Add(txtEliminar);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(382, 419);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Chartreuse;
            txtEliminar.Location = new Point(144, 103);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.PlaceholderText = "id";
            txtEliminar.Size = new Size(100, 23);
            txtEliminar.TabIndex = 1;
            txtEliminar.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.color2oscuro;
            tabPage2.Controls.Add(txtAgregarId);
            tabPage2.Controls.Add(txtAgregarNombreImg);
            tabPage2.Controls.Add(txtAgregarDescripcion);
            tabPage2.Controls.Add(txtAgregarPrecio);
            tabPage2.Controls.Add(txtAgregarExist);
            tabPage2.Controls.Add(btnAgregar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(382, 419);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAgregarId
            // 
            txtAgregarId.BackColor = Color.Chartreuse;
            txtAgregarId.Location = new Point(153, 45);
            txtAgregarId.Name = "txtAgregarId";
            txtAgregarId.PlaceholderText = "ID";
            txtAgregarId.Size = new Size(100, 23);
            txtAgregarId.TabIndex = 2;
            // 
            // txtAgregarNombreImg
            // 
            txtAgregarNombreImg.BackColor = Color.Chartreuse;
            txtAgregarNombreImg.Location = new Point(153, 86);
            txtAgregarNombreImg.Name = "txtAgregarNombreImg";
            txtAgregarNombreImg.PlaceholderText = "Nombre Imagen";
            txtAgregarNombreImg.Size = new Size(100, 23);
            txtAgregarNombreImg.TabIndex = 3;
            // 
            // txtAgregarDescripcion
            // 
            txtAgregarDescripcion.BackColor = Color.Chartreuse;
            txtAgregarDescripcion.Location = new Point(151, 126);
            txtAgregarDescripcion.Multiline = true;
            txtAgregarDescripcion.Name = "txtAgregarDescripcion";
            txtAgregarDescripcion.PlaceholderText = "Descripcion";
            txtAgregarDescripcion.Size = new Size(100, 95);
            txtAgregarDescripcion.TabIndex = 2;
            // 
            // txtAgregarPrecio
            // 
            txtAgregarPrecio.BackColor = Color.Chartreuse;
            txtAgregarPrecio.Location = new Point(151, 236);
            txtAgregarPrecio.Name = "txtAgregarPrecio";
            txtAgregarPrecio.PlaceholderText = "Precio";
            txtAgregarPrecio.Size = new Size(100, 23);
            txtAgregarPrecio.TabIndex = 2;
            // 
            // txtAgregarExist
            // 
            txtAgregarExist.BackColor = Color.Chartreuse;
            txtAgregarExist.Location = new Point(151, 274);
            txtAgregarExist.Name = "txtAgregarExist";
            txtAgregarExist.PlaceholderText = "Existencias";
            txtAgregarExist.Size = new Size(100, 23);
            txtAgregarExist.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Chartreuse;
            btnAgregar.Location = new Point(165, 310);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.color2oscuro;
            tabPage3.Controls.Add(btnCargar);
            tabPage3.Controls.Add(richTextBoxListado);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(382, 419);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.Chartreuse;
            btnCargar.Location = new Point(165, 337);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // richTextBoxListado
            // 
            richTextBoxListado.BackColor = Color.Chartreuse;
            richTextBoxListado.Location = new Point(117, 12);
            richTextBoxListado.Name = "richTextBoxListado";
            richTextBoxListado.Size = new Size(169, 316);
            richTextBoxListado.TabIndex = 0;
            richTextBoxListado.Text = "";
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.color2oscuro;
            tabPage4.Controls.Add(btnCargarRichTxt2);
            tabPage4.Controls.Add(richTextBoxOrdenadaPorExist);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(382, 419);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCargarRichTxt2
            // 
            btnCargarRichTxt2.BackColor = Color.Chartreuse;
            btnCargarRichTxt2.Location = new Point(160, 336);
            btnCargarRichTxt2.Name = "btnCargarRichTxt2";
            btnCargarRichTxt2.Size = new Size(75, 23);
            btnCargarRichTxt2.TabIndex = 2;
            btnCargarRichTxt2.Text = "Cargar";
            btnCargarRichTxt2.UseVisualStyleBackColor = false;
            btnCargarRichTxt2.Click += btnCargarRichTxt2_Click;
            // 
            // richTextBoxOrdenadaPorExist
            // 
            richTextBoxOrdenadaPorExist.BackColor = Color.Chartreuse;
            richTextBoxOrdenadaPorExist.Location = new Point(113, 14);
            richTextBoxOrdenadaPorExist.Name = "richTextBoxOrdenadaPorExist";
            richTextBoxOrdenadaPorExist.Size = new Size(169, 316);
            richTextBoxOrdenadaPorExist.TabIndex = 1;
            richTextBoxOrdenadaPorExist.Text = "";
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = Properties.Resources.color2oscuro;
            tabPage5.Controls.Add(buttonMostrarTotalVentas);
            tabPage5.Controls.Add(textBoxTotalVentas);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(382, 419);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarTotalVentas
            // 
            buttonMostrarTotalVentas.BackColor = Color.Chartreuse;
            buttonMostrarTotalVentas.Location = new Point(161, 127);
            buttonMostrarTotalVentas.Name = "buttonMostrarTotalVentas";
            buttonMostrarTotalVentas.Size = new Size(75, 23);
            buttonMostrarTotalVentas.TabIndex = 1;
            buttonMostrarTotalVentas.Text = "Mostrar";
            buttonMostrarTotalVentas.UseVisualStyleBackColor = false;
            buttonMostrarTotalVentas.Click += buttonMostrarTotalVentas_Click;
            // 
            // textBoxTotalVentas
            // 
            textBoxTotalVentas.BackColor = Color.Chartreuse;
            textBoxTotalVentas.Location = new Point(145, 98);
            textBoxTotalVentas.Name = "textBoxTotalVentas";
            textBoxTotalVentas.Size = new Size(101, 23);
            textBoxTotalVentas.TabIndex = 0;
            textBoxTotalVentas.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCerrarSesionAdmin
            // 
            btnCerrarSesionAdmin.BackColor = Color.Chartreuse;
            btnCerrarSesionAdmin.Location = new Point(355, 636);
            btnCerrarSesionAdmin.Name = "btnCerrarSesionAdmin";
            btnCerrarSesionAdmin.Size = new Size(91, 23);
            btnCerrarSesionAdmin.TabIndex = 2;
            btnCerrarSesionAdmin.Text = "Cerrar Sesion";
            btnCerrarSesionAdmin.UseVisualStyleBackColor = false;
            btnCerrarSesionAdmin.Click += btnCerrarSesionAdmin_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 681);
            Controls.Add(btnCerrarSesionAdmin);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtEliminar;
        private TextBox txtAgregarPrecio;
        private TextBox txtAgregarExist;
        private Button btnAgregar;
        private TextBox txtAgregarDescripcion;
        private TextBox txtAgregarId;
        private TextBox txtAgregarNombreImg;
        private TabPage tabPage3;
        private RichTextBox richTextBoxListado;
        private Button btnCargar;
        private Button btnCerrarSesionAdmin;
        private TabPage tabPage4;
        private Button btnCargarRichTxt2;
        private RichTextBox richTextBoxOrdenadaPorExist;
        private TabPage tabPage5;
        private Button buttonMostrarTotalVentas;
        private TextBox textBoxTotalVentas;
    }
}