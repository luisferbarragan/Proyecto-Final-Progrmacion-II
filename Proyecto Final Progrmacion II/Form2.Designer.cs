namespace Proyecto_Final_Progrmacion_II
{
    partial class FormIngresoUsuario
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
            txtAccederUsuario = new TextBox();
            txtAccederContrasena = new TextBox();
            buttonIngresar = new Button();
            pictureBox1 = new PictureBox();
            buttonSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAccederUsuario
            // 
            txtAccederUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAccederUsuario.BackColor = SystemColors.ButtonHighlight;
            txtAccederUsuario.ForeColor = Color.Black;
            txtAccederUsuario.Location = new Point(146, 466);
            txtAccederUsuario.Name = "txtAccederUsuario";
            txtAccederUsuario.PlaceholderText = "usuario";
            txtAccederUsuario.Size = new Size(180, 23);
            txtAccederUsuario.TabIndex = 1;
            // 
            // txtAccederContrasena
            // 
            txtAccederContrasena.BackColor = SystemColors.ButtonHighlight;
            txtAccederContrasena.Location = new Point(146, 495);
            txtAccederContrasena.Name = "txtAccederContrasena";
            txtAccederContrasena.PlaceholderText = "contraseña";
            txtAccederContrasena.Size = new Size(180, 23);
            txtAccederContrasena.TabIndex = 1;
            txtAccederContrasena.UseSystemPasswordChar = true;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.Chartreuse;
            buttonIngresar.FlatAppearance.BorderSize = 0;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Location = new Point(146, 524);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(180, 29);
            buttonIngresar.TabIndex = 2;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.overcat;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 681);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Chartreuse;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Location = new Point(358, 647);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(95, 24);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // FormIngresoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(buttonSalir);
            Controls.Add(buttonIngresar);
            Controls.Add(txtAccederUsuario);
            Controls.Add(txtAccederContrasena);
            Controls.Add(pictureBox1);
            Name = "FormIngresoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccederUsuario;
        private TextBox txtAccederContrasena;
        private Button buttonIngresar;
        private PictureBox pictureBox1;
        private Button buttonSalir;
    }
}