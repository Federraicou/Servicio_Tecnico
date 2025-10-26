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
