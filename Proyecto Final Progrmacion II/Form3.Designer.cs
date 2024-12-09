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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesionMenu
            // 
            btnCerrarSesionMenu.Location = new Point(359, 646);
            btnCerrarSesionMenu.Name = "btnCerrarSesionMenu";
            btnCerrarSesionMenu.Size = new Size(93, 23);
            btnCerrarSesionMenu.TabIndex = 0;
            btnCerrarSesionMenu.Text = "Cerrar Sesión";
            btnCerrarSesionMenu.UseVisualStyleBackColor = true;
            btnCerrarSesionMenu.Click += btnCerrarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(pictureBox1);
            Controls.Add(btnCerrarSesionMenu);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesionMenu;
        private PictureBox pictureBox1;
    }
}