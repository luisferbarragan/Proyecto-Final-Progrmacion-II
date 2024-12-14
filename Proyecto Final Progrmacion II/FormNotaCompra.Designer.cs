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
            SuspendLayout();
            // 
            // lblFechaHora
            // 
            lblFechaHora.BackColor = Color.Chartreuse;
            lblFechaHora.Enabled = false;
            lblFechaHora.Location = new Point(184, 137);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(100, 51);
            lblFechaHora.TabIndex = 0;
            lblFechaHora.Text = " ";
            // 
            // richTextBoxProductos
            // 
            richTextBoxProductos.BackColor = Color.Chartreuse;
            richTextBoxProductos.Location = new Point(161, 214);
            richTextBoxProductos.Name = "richTextBoxProductos";
            richTextBoxProductos.Size = new Size(142, 116);
            richTextBoxProductos.TabIndex = 1;
            richTextBoxProductos.Text = " ";
            // 
            // lblTotalConImpuesto
            // 
            lblTotalConImpuesto.BackColor = Color.Chartreuse;
            lblTotalConImpuesto.Location = new Point(178, 349);
            lblTotalConImpuesto.Name = "lblTotalConImpuesto";
            lblTotalConImpuesto.Size = new Size(112, 42);
            lblTotalConImpuesto.TabIndex = 2;
            lblTotalConImpuesto.Text = " ";
            // 
            // buttonFinalizarCompra
            // 
            buttonFinalizarCompra.BackColor = Color.Chartreuse;
            buttonFinalizarCompra.Location = new Point(178, 407);
            buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            buttonFinalizarCompra.Size = new Size(111, 27);
            buttonFinalizarCompra.TabIndex = 3;
            buttonFinalizarCompra.Text = " Finalizar";
            buttonFinalizarCompra.UseVisualStyleBackColor = false;
            buttonFinalizarCompra.Click += buttonFinalizarCompra_Click;
            // 
            // FormNotaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(buttonFinalizarCompra);
            Controls.Add(lblTotalConImpuesto);
            Controls.Add(richTextBoxProductos);
            Controls.Add(lblFechaHora);
            Name = "FormNotaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNotaCompra";
            ResumeLayout(false);
        }

        #endregion

        private Label lblFechaHora;
        private RichTextBox richTextBoxProductos;
        private Label lblTotalConImpuesto;
        private Button buttonFinalizarCompra;
    }
}