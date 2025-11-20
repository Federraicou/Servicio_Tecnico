using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Reparacion
    {
        public int IdReparacion { get; set; }
        public string Diagnostico { get; set; }
        public DateTime FechaEstimada { get; set; }
        public int Idrepuesto { get; set; }
        public int IdEquipo { get; set; }

    }
}
