using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Progrmacion_II
{
    public class Usuarios
    {
        private int id;
        private string nombre;
        private string cuenta;
        private string contra;
        private int monto;

        public Usuarios()
        {

        }

        public Usuarios(int id, string nombre, string cuenta, string contra, int monto)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
