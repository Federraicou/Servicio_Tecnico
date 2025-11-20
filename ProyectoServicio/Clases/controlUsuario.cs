using System;
using System.Text;
using System.Security.Cryptography;

namespace ProyectoServicio
{
    internal class controlUsuario
    {
        public string ctrlRegistroUsuarios(Usuario user)
        {
            modeloUsuarios modelo = new modeloUsuarios();
            string rta = "";
            if ((string.IsNullOrEmpty(user.User)) ||
                (string.IsNullOrEmpty(user.Password)) ||
                (string.IsNullOrEmpty(user.PasswordConfirma)) ||
                (user.IdTipo < 0) ||
                (string.IsNullOrEmpty(user.Nombre)))
            {
                rta = "Datos incompletos";
            }
            else
            {
                if (user.Password == user.PasswordConfirma)
                {
                    if (modelo.existeUsuario(user))
                        rta = "¡El nombre de usuario " + user.User + " no está disponible!";
                    else
                    {
                        user.Password = generarSHA1(user.Password);

                        if (modelo.registrarUsuario(user))
                            rta = "¡Alta exitosa!";
                        else
                            rta = "¡Error inesperado!";
                    }
                }
                else
                    rta = "¡Las contraseñas no coinciden!";
            }
            return rta;
        }
        public string ctrlActualizarUsuarioPorId(int idUser, Usuario user)
        {
            modeloUsuarios modelo = new modeloUsuarios();
            string rta = "";

            bool cambiarPassword = !string.IsNullOrEmpty(user.Password) || !string.IsNullOrEmpty(user.PasswordConfirma);

            if ((string.IsNullOrEmpty(user.User)) ||
                (string.IsNullOrEmpty(user.Nombre)) ||
                (user.IdTipo < 0))
            {
                rta = "Datos incompletos para actualizar";
                return rta;
            } 
            modeloSesion ms = new modeloSesion();
            var existente = ms.miUsuario(user.User?.Trim());
            if (existente != null && existente.Id != idUser)
            {
                return "¡El nombre de usuario ya está en uso por otro registro!";
            }

            if (cambiarPassword)
            {
                if (user.Password != user.PasswordConfirma)
                    return "¡Las contraseñas no coinciden!";
                user.Password = generarSHA1(user.Password);
            }

            user.Id = idUser;
            if (modelo.actualizarUsuarioPorId(user, cambiarPassword))
                rta = "¡Actualización exitosa!";
            else
                rta = "No se pudo actualizar (verifique que el usuario exista)";

            return rta;
        }
        public string ctrlBorrarUsuarioPorId(int idUser)
        {
            modeloUsuarios modelo = new modeloUsuarios();
            string rta = "";
            if (idUser <= 0)
            {
                rta = "Usuario inválido";
            }
            else
            {
                if (modelo.eliminarUsuarioPorId(idUser))
                    rta = "¡Usuario eliminado!";
                else
                    rta = "No se pudo eliminar el usuario.";
            }
            return rta;
        }
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
