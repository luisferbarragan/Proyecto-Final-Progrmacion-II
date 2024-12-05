using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Progrmacion_II
{
    public partial class FormIngresoUsuario : Form
    {
        public FormIngresoUsuario()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            DataBase obj = new DataBase();
            Usuarios aux = obj.consultarUsuarioContra("luis", "luis123");
            if (aux != null )
            {
                MessageBox.Show("Usuario encontrado.");
            }
        }
    }
}
