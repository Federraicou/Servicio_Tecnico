using System;
using MySql.Data.MySqlClient;

namespace ProyectoServicio
{
    internal class modeloSesion
    {
        public Usuario miUsuario(string usuario)
        {
            Usuario miUser = null;
            Conexion c1 = new Conexion(); // Instancia de la clase conexión
            var miConexion = c1.getConexion();
            miConexion.Open();
            string sql = "Select * from usuarios where User Like @user";
            var comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@user", usuario);
            var reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    miUser = new Usuario();
                    miUser.Id = int.Parse(reader["idUser"].ToString());
                    miUser.User = reader["User"].ToString();
                    miUser.Password = reader["Password"].ToString();
                    miUser.Nombre = reader["Nombre"].ToString();
                    miUser.IdTipo = int.Parse(reader["idTipoUser"].ToString());
                }
            }
            miConexion.Close();
            return miUser;
        }
    }
}
