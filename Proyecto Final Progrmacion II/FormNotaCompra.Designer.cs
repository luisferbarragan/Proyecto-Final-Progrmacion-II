namespace Proyecto_Final_Progrmacion_II
{
    partial class FormNotaCompra
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
            lblFechaHora = new Label();
            richTextBoxProductos = new RichTextBox();
            lblTotalConImpuesto = new Label();
            buttonFinalizarCompra = new Button();
            textBoxCorreo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFechaHora
            // 
            lblFechaHora.BackColor = Color.Chartreuse;
            lblFechaHora.Enabled = false;
            lblFechaHora.Location = new Point(184, 138);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(100, 51);
            lblFechaHora.TabIndex = 0;
            lblFechaHora.Text = " ";
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.BackColor = Color.Chartreuse;
            richTextBoxProductos.Location = new Point(127, 202);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(215, 182);
            richTextBoxProductos.TabIndex = 1;
            richTextBoxProductos.Text = " ";
            // 
            // lblTotalConImpuesto
            // 
            lblTotalConImpuesto.BackColor = Color.Chartreuse;
            lblTotalConImpuesto.Location = new Point(177, 397);
            lblTotalConImpuesto.Name = "lblTotalConImpuesto";
            lblTotalConImpuesto.Size = new Size(112, 42);
            lblTotalConImpuesto.TabIndex = 2;
            lblTotalConImpuesto.Text = " ";
            // 
            // buttonFinalizarCompra
            // 
            buttonFinalizarCompra.BackColor = Color.Chartreuse;
            buttonFinalizarCompra.Location = new Point(177, 539);
            buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            buttonFinalizarCompra.Size = new Size(111, 27);
            buttonFinalizarCompra.TabIndex = 3;
            buttonFinalizarCompra.Text = " Finalizar";
            buttonFinalizarCompra.UseVisualStyleBackColor = false;
            buttonFinalizarCompra.Click += buttonFinalizarCompra_Click;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.Chartreuse;
            textBoxCorreo.Location = new Point(184, 493);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "Correo";
            textBoxCorreo.Size = new Size(100, 23);
            textBoxCorreo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Chartreuse;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(131, 450);
            label1.Name = "label1";
            label1.Size = new Size(211, 30);
            label1.TabIndex = 5;
            label1.Text = "Si deseas recibir un correo con tu nota \r\nporfavor escribelo aqui debajo.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormNotaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nota_de_compra;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 681);
            Controls.Add(label1);
            Controls.Add(textBoxCorreo);
            Controls.Add(buttonFinalizarCompra);
            Controls.Add(lblTotalConImpuesto);
            Controls.Add(richTextBoxProductos);
            Controls.Add(lblFechaHora);
            DoubleBuffered = true;
            Name = "FormNotaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNotaCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaHora;
        private RichTextBox richTextBoxProductos;
        private Label lblTotalConImpuesto;
        private Button buttonFinalizarCompra;
        private TextBox textBoxCorreo;
        private Label label1;
    }
}