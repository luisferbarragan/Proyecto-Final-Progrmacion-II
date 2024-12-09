using MySql.Data.MySqlClient;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormPortadaUAA : Form
    {
        public FormPortadaUAA()
        {
            InitializeComponent();
        }

        private void btnContinuarPortadaUAA_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIngresoUsuario f2 = new FormIngresoUsuario();
            f2.ShowDialog();
            this.Close();
        }
    }
}
