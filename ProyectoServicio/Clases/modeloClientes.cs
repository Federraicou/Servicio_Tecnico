using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;

namespace ProyectoServicio
{
    public class modeloClientes
    {
        private Conexion miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        public DataTable obtenerClientes()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT id_cliente, nombre AS `Nombre`, telefono AS `Telefono` FROM cliente";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            tabla.Locale = CultureInfo.InvariantCulture;
            adapter.Fill(tabla);
            conectar.Close();
            return tabla;
        }
        internal bool registrarCliente(Cliente c)
        {
            if (c == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            sql = "INSERT INTO cliente (nombre, telefono) VALUES (@nombre, @telefono)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@nombre", c.Nombre ?? string.Empty);
            comando.Parameters.AddWithValue("@telefono", c.Telefono ?? string.Empty);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        } 
        internal bool actualizarCliente(Cliente c)
        {
            if (c == null || c.IdCliente <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            sql = "UPDATE cliente SET nombre = @nombre, telefono = @telefono WHERE id_cliente = @id_cliente";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@nombre", c.Nombre ?? string.Empty);
            comando.Parameters.AddWithValue("@telefono", c.Telefono ?? string.Empty);
            comando.Parameters.AddWithValue("@id_cliente", c.IdCliente);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool eliminarClientePorId(int idCliente)
        {
            if (idCliente <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            sql = "DELETE FROM cliente WHERE id_cliente = @id_cliente";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_cliente", idCliente);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}