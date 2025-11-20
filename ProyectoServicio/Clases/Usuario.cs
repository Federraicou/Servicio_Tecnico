using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    internal class Usuario
    {
        private int id;
        private string user;
        private string password;
        private string passwordConfirma;
        private string nombre;
        private int idTipo;
        public Usuario()
        {
        }
        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string PasswordConfirma { get => passwordConfirma; set => passwordConfirma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
