using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Progrmacion_II
{
    public class Productos
    {
        private int id;
        private string nombreImg;
        private string descripcion;
        private double precio;
        private int exist;

        public Productos()
        {

        }
        public Productos(int id, string nombreImg, string descripcion, double precio, int exist)
        {
            this.id = id;
            this.nombreImg = nombreImg;
            this.descripcion = descripcion;
            this.precio = precio;
            this.exist = exist;
        }

        public int Id { get => id; set => id = value; }
        public string NombreImg { get => nombreImg; set => nombreImg = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Exist { get => exist; set => exist = value; }
    }
}
