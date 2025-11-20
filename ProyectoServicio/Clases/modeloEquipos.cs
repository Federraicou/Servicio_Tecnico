using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServicio
{
    public class modeloEquipos
    {
        private Conexion miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        public DataTable obtenerEquipos()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT id_equipo, id_cliente, fecha_ingreso," +
                " tipo , procesador , ram , fuente , almacenamiento , gpu  FROM equipo";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            MySqlDataAdapter adapter = new MySqlDataAdapter { SelectCommand = comando };
            DataTable tabla = new DataTable();
            tabla.Locale = CultureInfo.InvariantCulture;
            adapter.Fill(tabla);
            conectar.Close();
            return tabla;
        }
        internal bool registrarEquipo(Equipo e)
        {
            if (e == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO equipo (procesador, fecha_ingreso, tipo, id_cliente, ram, fuente, almacenamiento, gpu) " +
                  "VALUES (@procesador, @fecha_ingreso, @tipo, @id_cliente, @ram, @fuente, @almacenamiento, @gpu)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@procesador", e.Procesador ?? string.Empty);
            comando.Parameters.AddWithValue("@fecha_ingreso", e.FechaIngreso);
            comando.Parameters.AddWithValue("@tipo", e.Tipo ?? string.Empty);
            comando.Parameters.AddWithValue("@id_cliente", e.IdCliente);
            comando.Parameters.AddWithValue("@ram", e.Ram ?? string.Empty);
            comando.Parameters.AddWithValue("@fuente", e.Fuente ?? string.Empty);
            comando.Parameters.AddWithValue("@almacenamiento", e.Almacenamiento ?? string.Empty);
            comando.Parameters.AddWithValue("@gpu", e.Gpu ?? string.Empty);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool actualizarEquipo(Equipo e)
        {
            if (e == null || e.IdEquipo <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "UPDATE equipo SET procesador = @procesador, fecha_ingreso = @fecha_ingreso, tipo = @tipo, id_cliente = @id_cliente, " +
                  "ram = @ram, fuente = @fuente, almacenamiento = @almacenamiento, gpu = @gpu WHERE id_equipo = @id_equipo";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@procesador", e.Procesador ?? string.Empty);
            comando.Parameters.AddWithValue("@fecha_ingreso", e.FechaIngreso);
            comando.Parameters.AddWithValue("@tipo", e.Tipo ?? string.Empty);
            comando.Parameters.AddWithValue("@id_cliente", e.IdCliente);
            comando.Parameters.AddWithValue("@ram", e.Ram ?? string.Empty);
            comando.Parameters.AddWithValue("@fuente", e.Fuente ?? string.Empty);
            comando.Parameters.AddWithValue("@almacenamiento", e.Almacenamiento ?? string.Empty);
            comando.Parameters.AddWithValue("@gpu", e.Gpu ?? string.Empty);
            comando.Parameters.AddWithValue("@id_equipo", e.IdEquipo);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool eliminarEquipoPorId(int idEquipo)
        {
            if (idEquipo <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "DELETE FROM equipo WHERE id_equipo = @id_equipo";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_equipo", idEquipo);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}

