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
            SuspendLayout();
            // 
            // txtAccederUsuario
            // 
            txtAccederUsuario.Location = new Point(161, 482);
            txtAccederUsuario.Name = "txtAccederUsuario";
            txtAccederUsuario.PlaceholderText = "usuario";
            txtAccederUsuario.Size = new Size(100, 23);
            txtAccederUsuario.TabIndex = 1;
            // 
            // txtAccederContrasena
            // 
            txtAccederContrasena.Location = new Point(161, 511);
            txtAccederContrasena.Name = "txtAccederContrasena";
            txtAccederContrasena.PlaceholderText = "contraseña";
            txtAccederContrasena.Size = new Size(100, 23);
            txtAccederContrasena.TabIndex = 1;
            txtAccederContrasena.UseSystemPasswordChar = true;
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(175, 540);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(75, 23);
            buttonIngresar.TabIndex = 0;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // FormIngresoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(buttonIngresar);
            Controls.Add(txtAccederContrasena);
            Controls.Add(txtAccederUsuario);
            Name = "FormIngresoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccederUsuario;
        private TextBox txtAccederContrasena;
        private Button buttonIngresar;
    }
}