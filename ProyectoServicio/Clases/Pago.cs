using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Pago
    {
        public int IdPago { get; set; }
        public int PrecioServicio { get; set; }
        public DateTime FechaPago { get; set; }
        public int IdCliente { get; set; }
        public string TipoPago { get; set; }
        public int PrecioTotal { get; set; }
        public int PrecioRepuesto { get; set; }
    }
}
