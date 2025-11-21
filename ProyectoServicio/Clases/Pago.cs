using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Pago
    {
        private int idPago;
        private int precioServicio;
        private DateTime fechaPago;
        private int idCliente;
        private string tipoPago;
        private int precioTotal;
        private int precioRepuesto;
        private Cliente cliente;
        private Reparacion reparacion;
        public Pago()
        {
        }
        public int IdPago { get => idPago; set => idPago = value; }
        public int PrecioServicio { get => precioServicio; set => precioServicio = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public int PrecioRepuesto { get => precioRepuesto; set => precioRepuesto = value; }
        public Cliente Cliente { get; set; }
        public Reparacion Reparacion { get; set; }
    }
}
