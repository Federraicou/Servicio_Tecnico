using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Cliente
    {
        private int idCliente;
        private string nombre;
        private string telefono;
        public Cliente(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
