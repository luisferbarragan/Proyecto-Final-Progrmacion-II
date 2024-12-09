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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(59, 101);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(133, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 400);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtEliminar);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(45, 42);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.PlaceholderText = "id";
            txtEliminar.Size = new Size(100, 23);
            txtEliminar.TabIndex = 1;
            txtEliminar.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtAgregarId);
            tabPage2.Controls.Add(txtAgregarNombreImg);
            tabPage2.Controls.Add(txtAgregarDescripcion);
            tabPage2.Controls.Add(txtAgregarPrecio);
            tabPage2.Controls.Add(txtAgregarExist);
            tabPage2.Controls.Add(btnAgregar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAgregarId
            // 
            txtAgregarId.Location = new Point(45, 42);
            txtAgregarId.Name = "txtAgregarId";
            txtAgregarId.PlaceholderText = "ID";
            txtAgregarId.Size = new Size(100, 23);
            txtAgregarId.TabIndex = 2;
            // 
            // txtAgregarNombreImg
            // 
            txtAgregarNombreImg.Location = new Point(45, 83);
            txtAgregarNombreImg.Name = "txtAgregarNombreImg";
            txtAgregarNombreImg.PlaceholderText = "Nombre Imagen";
            txtAgregarNombreImg.Size = new Size(100, 23);
            txtAgregarNombreImg.TabIndex = 3;
            // 
            // txtAgregarDescripcion
            // 
            txtAgregarDescripcion.Location = new Point(43, 123);
            txtAgregarDescripcion.Multiline = true;
            txtAgregarDescripcion.Name = "txtAgregarDescripcion";
            txtAgregarDescripcion.PlaceholderText = "Descripcion";
            txtAgregarDescripcion.Size = new Size(100, 95);
            txtAgregarDescripcion.TabIndex = 2;
            // 
            // txtAgregarPrecio
            // 
            txtAgregarPrecio.Location = new Point(43, 233);
            txtAgregarPrecio.Name = "txtAgregarPrecio";
            txtAgregarPrecio.PlaceholderText = "Precio";
            txtAgregarPrecio.Size = new Size(100, 23);
            txtAgregarPrecio.TabIndex = 2;
            // 
            // txtAgregarExist
            // 
            txtAgregarExist.Location = new Point(43, 271);
            txtAgregarExist.Name = "txtAgregarExist";
            txtAgregarExist.PlaceholderText = "Existencias";
            txtAgregarExist.Size = new Size(100, 23);
            txtAgregarExist.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(57, 307);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnCargar);
            tabPage3.Controls.Add(richTextBoxListado);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(192, 372);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(58, 337);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // richTextBoxListado
            // 
            richTextBoxListado.Location = new Point(10, 12);
            richTextBoxListado.Name = "richTextBoxListado";
            richTextBoxListado.Size = new Size(169, 316);
            richTextBoxListado.TabIndex = 0;
            richTextBoxListado.Text = "";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(tabControl1);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
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
    }
}