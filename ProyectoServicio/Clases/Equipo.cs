using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Equipo
    {
        private int idEquipo;
        private int idCliente;
        private DateTime fechaIngreso;
        private string tipo;
        private string procesador;
        private string ram;
        private string fuente;
        private string gpu;
        private string almacenamiento;
        private Cliente cliente;
        public Equipo()
        {
        }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Fuente { get => fuente; set => fuente = value; }
        public string Gpu { get => gpu; set => gpu = value; }
        public string Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public Cliente Cliente { get; set; }
    }
}
