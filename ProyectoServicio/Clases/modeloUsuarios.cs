using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProyectoServicio
{
    public class modeloUsuarios
    {

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

        public DataTable obtenerUsuarios()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT idUser, Nombre AS `Nombre Completo`, User AS `Nombre de Usuario` FROM usuarios";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(tabla);
            conectar.Close();
            return tabla;
        }
        internal bool actualizarUsuarioPorId(Usuario user, bool actualizarPassword)
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            if (actualizarPassword)
            {
                sql = "UPDATE usuarios SET User = @User, Password = @Password, Nombre = @Nombre, idTipoUser = @idTipoUser WHERE idUser = @idUser";
            }
            else
            {
                sql = "UPDATE usuarios SET User = @User, Nombre = @Nombre, idTipoUser = @idTipoUser WHERE idUser = @idUser";
            }
            MySqlCommand cmd = new MySqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@User", user.User);
            if (actualizarPassword)
                cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Nombre", user.Nombre);
            cmd.Parameters.AddWithValue("@idTipoUser", user.IdTipo);
            cmd.Parameters.AddWithValue("@idUser", user.Id);

            int tuplas = cmd.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool eliminarUsuarioPorId(int idUser)
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "DELETE FROM usuarios WHERE idUser = @idUser";
            MySqlCommand cmd = new MySqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@idUser", idUser);
            int tuplas = cmd.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}
