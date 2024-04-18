using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasyObjetos
{
    internal class Jugador
    {
        public string nombre;
        public int camiseta;
        public string posicion;

        public Jugador(string nombre, int camiseta, string posicion)
        {
            this.nombre = nombre;
            this.camiseta = camiseta;
            this.posicion = posicion;
        }
    }
}
