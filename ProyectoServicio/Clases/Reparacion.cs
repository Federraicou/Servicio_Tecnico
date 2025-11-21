using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Reparacion
    {
        private int idReparacion;
        private string diagnostico;
        private DateTime fechaEstimada;
        private int idrepuesto;
        private int idEquipo;
        private Equipo equipo;
        private Repuesto repuesto;
        private Usuario usuario;

        public Reparacion()
        {
        }

        public int IdReparacion { get => idReparacion; set => idReparacion = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public DateTime FechaEstimada { get => fechaEstimada; set => fechaEstimada = value; }
        public int Idrepuesto { get => idrepuesto; set => idrepuesto = value; }
        public int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public Equipo Equipo { get; set; }
        public Repuesto Repuesto { get; set; }
        public Usuario Usuario { get; set; }
    }
}
