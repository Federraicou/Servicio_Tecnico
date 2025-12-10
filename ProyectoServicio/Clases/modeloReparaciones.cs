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
        private int _repuestoCheckId = 0; 

        public DataTable obtenerReparaciones()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = @"
                SELECT
                    r.id_reparacion,
                    CONCAT(e.id_equipo, ' - ', IFNULL(e.tipo, '')) AS Equipo,
                    e.id_cliente,
                    IFNULL(c.nombre, '') AS Cliente,
                    rep.nombre AS repuesto,
                    r.diagnostico,
                    r.fecha_estimada,
                    IFNULL(r.estado, '') AS estado
                FROM reparaciones r
                INNER JOIN equipo e ON r.id_equipo = e.id_equipo
                INNER JOIN cliente c ON e.id_cliente = c.id_cliente
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

        internal bool MarcarReparacionPagada(int idReparacion)
        {
            if (idReparacion <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            string sql = "UPDATE reparaciones SET estado = @estado WHERE id_reparacion = @id_reparacion";
            using (MySqlCommand cmd = new MySqlCommand(sql, conectar))
            {
                cmd.Parameters.AddWithValue("@estado", "PAGADA");
                cmd.Parameters.AddWithValue("@id_reparacion", idReparacion);
                int rows = cmd.ExecuteNonQuery();
                conectar.Close();
                return rows > 0;
            }
        }

        internal bool registrarReparacion(string diagnostico, int idEquipo, DateTime fechaEstimada, int idRepuesto)
        {
            var r = new Reparacion
            {
                Diagnostico = diagnostico ?? string.Empty,
                IdEquipo = idEquipo,
                FechaEstimada = fechaEstimada,
                Idrepuesto = idRepuesto
            };
            return registrarReparacion(r);
        }

        internal bool actualizarReparacion(int idReparacion, string diagnostico, int idEquipo, DateTime fechaEstimada, int idRepuesto)
        {
            var r = new Reparacion
            {
                IdReparacion = idReparacion,
                Diagnostico = diagnostico ?? string.Empty,
                IdEquipo = idEquipo,
                FechaEstimada = fechaEstimada,
                Idrepuesto = idRepuesto
            };
            return actualizarReparacion(r);
        }

        private bool RepuestoDisponible()
        {
            string sqlCheck = "SELECT cantidad FROM repuestos WHERE id_repuesto = @id_repuesto";
            using (MySqlCommand cmd = new MySqlCommand(sqlCheck, conectar))
            {
                cmd.Parameters.AddWithValue("@id_repuesto", _repuestoCheckId);
                var result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return false;
                int cantidad = Convert.ToInt32(result);
                return cantidad > 0;
            }
        }

        internal bool registrarReparacion(Reparacion r)
        {
            if (r == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            if (r.Idrepuesto > 0)
            {
                _repuestoCheckId = r.Idrepuesto;
                bool disponible = RepuestoDisponible();
                _repuestoCheckId = 0;
                if (!disponible)
                {
                    conectar.Close();
                    return false;
                }
            }

            sql = "INSERT INTO reparaciones (diagnostico, fecha_estimada, id_repuesto, id_equipo) VALUES (@diagnostico, @fecha_estimada, @id_repuesto, @id_equipo)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@diagnostico", r.Diagnostico ?? string.Empty);
            comando.Parameters.AddWithValue("@fecha_estimada", r.FechaEstimada);
            if (r.Idrepuesto <= 0)
            {
                comando.Parameters.AddWithValue("@id_repuesto", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto);
            }
            comando.Parameters.AddWithValue("@id_equipo", r.IdEquipo);
            int tuplas = comando.ExecuteNonQuery();
            if (tuplas > 0 && r.Idrepuesto > 0)
            {
                try
                {
                    string sqlUpdate = "UPDATE repuestos SET cantidad = cantidad - 1 WHERE id_repuesto = @id_repuesto AND cantidad > 0";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conectar))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                catch
                {
                }
            }

            conectar.Close();
            return tuplas > 0;
        }

        internal bool actualizarReparacion(Reparacion r)
        {
            if (r == null || r.IdReparacion <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            if (r.Idrepuesto > 0)
            {
                _repuestoCheckId = r.Idrepuesto;
                bool disponible = RepuestoDisponible();
                _repuestoCheckId = 0;
                if (!disponible)
                {
                    conectar.Close();
                    return false;
                }
            }

            sql = "UPDATE reparaciones SET diagnostico = @diagnostico, fecha_estimada = @fecha_estimada, id_repuesto = @id_repuesto, id_equipo = @id_equipo WHERE id_reparacion = @id_reparacion";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_reparacion", r.IdReparacion);
            comando.Parameters.AddWithValue("@diagnostico", r.Diagnostico ?? string.Empty);
            comando.Parameters.AddWithValue("@fecha_estimada", r.FechaEstimada);
            comando.Parameters.AddWithValue("@id_equipo", r.IdEquipo);
            if (r.Idrepuesto <= 0)
            {
                comando.Parameters.AddWithValue("@id_repuesto", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto);
            }
            int tuplas = comando.ExecuteNonQuery();
            if (tuplas > 0 && r.Idrepuesto > 0)
            {
                try
                {
                    string sqlUpdate = "UPDATE repuestos SET cantidad = cantidad - 1 WHERE id_repuesto = @id_repuesto AND cantidad > 0";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conectar))
                    {
                        cmdUpdate.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                catch
                {
                }
            }

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
