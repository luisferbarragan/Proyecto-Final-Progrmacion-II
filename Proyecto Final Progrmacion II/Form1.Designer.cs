namespace Proyecto_Final_Progrmacion_II
{
    partial class FormPortadaUAA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortadaUAA));
            pictureBoxPortadaUAA = new PictureBox();
            btnContinuarPortadaUAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortadaUAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPortadaUAA
            // 
            pictureBoxPortadaUAA.Dock = DockStyle.Fill;
            pictureBoxPortadaUAA.Image = (Image)resources.GetObject("pictureBoxPortadaUAA.Image");
            pictureBoxPortadaUAA.Location = new Point(0, 0);
            pictureBoxPortadaUAA.Name = "pictureBoxPortadaUAA";
            pictureBoxPortadaUAA.Size = new Size(464, 681);
            pictureBoxPortadaUAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPortadaUAA.TabIndex = 0;
            pictureBoxPortadaUAA.TabStop = false;
            // 
            // btnContinuarPortadaUAA
            // 
            btnContinuarPortadaUAA.BackColor = Color.FromArgb(32, 44, 84);
            btnContinuarPortadaUAA.FlatStyle = FlatStyle.Flat;
            btnContinuarPortadaUAA.ForeColor = SystemColors.ButtonHighlight;
            btnContinuarPortadaUAA.Location = new Point(168, 593);
            btnContinuarPortadaUAA.Name = "btnContinuarPortadaUAA";
            btnContinuarPortadaUAA.Size = new Size(129, 34);
            btnContinuarPortadaUAA.TabIndex = 1;
            btnContinuarPortadaUAA.Text = "Continuar";
            btnContinuarPortadaUAA.UseVisualStyleBackColor = false;
            btnContinuarPortadaUAA.Click += btnContinuarPortadaUAA_Click;
            // 
            // FormPortadaUAA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(btnContinuarPortadaUAA);
            Controls.Add(pictureBoxPortadaUAA);
            Name = "FormPortadaUAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PortadaUAA";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortadaUAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPortadaUAA;
        private Button btnContinuarPortadaUAA;
    }
}
