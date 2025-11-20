using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Equipo
    {
        public int IdEquipo { get; set; }
        public string Procesador { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Tipo { get; set; }
        public int IdCliente { get; set; }
        public string Ram { get; set; }
        public string Fuente { get; set; }
        public string Almacenamiento { get; set; }
        public string Gpu { get; set; }
    }
}
