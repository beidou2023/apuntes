using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    internal class Producto
    {
        public string nombre;
        public double precio;
        public string detalles;

        public Producto(string nombre, double precio, string detalles)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.detalles = detalles;
        }
        public Producto()
        {

        }
    }
}
