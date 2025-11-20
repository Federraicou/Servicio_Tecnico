using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Repuesto
    {
        public Repuesto(string nombre, int precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
        public int Idrepuesto { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
