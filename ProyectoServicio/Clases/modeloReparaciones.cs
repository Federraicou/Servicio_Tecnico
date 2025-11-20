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
    internal class modeloReparaciones
    {
        private Conexion miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        public DataTable obtenerReparaciones()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = @"SELECT r.id_reparacion,
                   r.id_equipo,
                   rep.nombre AS repuesto,
                   r.diagnostico,
                   r.fecha_estimada
            FROM reparaciones r
            LEFT JOIN repuestos rep ON r.id_repuesto = rep.id_repuesto";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            tabla.Locale = CultureInfo.InvariantCulture;
            adapter.Fill(tabla);
            conectar.Close();
            return tabla;
        }
        internal bool registrarReparacion (Reparacion r)
        {
            if (r == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO reparaciones (diagnostico, fecha_estimada, id_repuesto, id_equipo) VALUES (@diagnostico, @fecha_estimada, @id_repuesto, @id_equipo)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@diagnostico", r.Diagnostico ?? string.Empty);
            comando.Parameters.AddWithValue("@fecha_estimada", r.FechaEstimada);
            if (r.Idrepuesto <= 0)
            {
                comando.Parameters.AddWithValue("@id_repuesto", DBNull.Value); // SIN repuesto
            }
            else
            {
                comando.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto); // Con repuesto
            }
            comando.Parameters.AddWithValue("@id_equipo", r.IdEquipo);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool actualizarReparacion(Reparacion r)
        {
            if (r == null || r.IdReparacion <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "UPDATE reparaciones SET diagnostico = @diagnostico, fecha_estimada = @fecha_estimada, id_repuesto = @id_repuesto, id_equipo = @id_equipo WHERE id_reparacion = @id_reparacion";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_reparacion", r.IdReparacion);
            comando.Parameters.AddWithValue("@diagnostico", r.Diagnostico ?? string.Empty);
            comando.Parameters.AddWithValue("@fecha_estimada", r.FechaEstimada);
            comando.Parameters.AddWithValue("@id_equipo", r.IdEquipo);
            if (r.Idrepuesto <= 0)
            {
                comando.Parameters.AddWithValue("@id_repuesto", DBNull.Value); // SIN repuesto
            }
            else
            {
                comando.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto); // Con repuesto
            }
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool eliminarReparacionPorId(int idReparacion)
        {
            if (idReparacion <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "DELETE FROM reparaciones WHERE id_reparacion = @id_reparacion";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_reparacion", idReparacion);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}
