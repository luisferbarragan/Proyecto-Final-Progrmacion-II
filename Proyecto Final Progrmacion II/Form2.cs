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
            Usuarios aux = obj.consultarUsuarioContra(this.txtAccederUsuario.Text, this.txtAccederContrasena.Text);
            if (aux != null)
            {
                if (aux.Nombre == "administrador")
                {
                    this.Hide();
                    FormAdmin f1 = new FormAdmin();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    FormMenu f2 = new FormMenu(aux);
                    f2.ShowDialog();
                    //this.Close();
                }
            }
        }
    }
}
