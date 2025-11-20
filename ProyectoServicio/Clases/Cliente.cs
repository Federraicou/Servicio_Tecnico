using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Cliente
    {
        public Cliente(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
