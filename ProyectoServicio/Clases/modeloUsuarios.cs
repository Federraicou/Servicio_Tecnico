using MySql.Data.MySqlClient;
using System;

namespace ProyectoServicio
{
    public class modeloUsuarios
    {
        // ATRIBUTOS DE INSTANCIA
        private Conexion miConexion;
        private MySqlConnection conectar;
        private String sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        internal bool existeUsuario(Usuario user)
        {
            bool rta = false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT * FROM usuarios WHERE User LIKE @user";
            comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@user", user.User);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            conectar.Close();
            return rta;
        }

        internal bool registrarUsuario(Usuario user)
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO usuarios (idUser, User, Password, Nombre, idTipoUser) " +
                  "VALUES (@idUser, @User, @Password, @Nombre, @idTipoUser)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@idUser", null);
            comando.Parameters.AddWithValue("@User", user.User);
            comando.Parameters.AddWithValue("@Password", user.Password);
            comando.Parameters.AddWithValue("@Nombre", user.Nombre);
            comando.Parameters.AddWithValue("@idTipoUser", user.IdTipo);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}
