using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Repuesto
    {
        private int idrepuesto;
        private string nombre;
        private int precio;
        private int cantidad;

        public Repuesto(string nombre, int precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
        public int Idrepuesto { get => idrepuesto; set => idrepuesto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
