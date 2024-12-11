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
            // flowLayoutPanelImages
            // 
            flowLayoutPanelImages.AutoScroll = true;
            flowLayoutPanelImages.Location = new Point(11, 53);
            flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            flowLayoutPanelImages.Size = new Size(477, 550);
            flowLayoutPanelImages.TabIndex = 1;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(flowLayoutPanelImages);
            Controls.Add(btnCerrarSesionMenu);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesionMenu;
        private FlowLayoutPanel flowLayoutPanelImages;
    }
}