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
    internal class modeloPago
    {
        private Conexion miConexion;
        private MySqlConnection conectar;
        private string sql = "";

        public DataTable obtenerPago()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            sql = @"
                SELECT
                    p.id_pago,
                    p.id_cliente,
                    CONCAT(p.id_cliente, ' - ', IFNULL(c.nombre, '')) AS Cliente,
                    p.id_reparacion,
                    CONCAT(IFNULL(e.id_equipo,''), ' - ', IFNULL(e.tipo,'')) AS Equipo,
                    p.fecha_pago,
                    p.tipo_pago,
                    p.precio_servicio,
                    p.precio_repuesto,
                    p.precio_total
                FROM pago p
                LEFT JOIN cliente c ON p.id_cliente = c.id_cliente
                LEFT JOIN reparaciones r ON p.id_reparacion = r.id_reparacion
                LEFT JOIN equipo e ON r.id_equipo = e.id_equipo
                ORDER BY p.id_pago DESC
            ";

            using (MySqlCommand comando = new MySqlCommand(sql, conectar))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
            {
                DataTable tabla = new DataTable();
                tabla.Locale = CultureInfo.InvariantCulture;
                adapter.Fill(tabla);
                conectar.Close();
                return tabla;
            }
        }
        public DataTable ObtenerClientesParaCombo()
        {
            modeloClientes mc = new modeloClientes();
            var tabla = mc.obtenerClientes();
            if (tabla != null)
            {
                if (!tabla.Columns.Contains("Display"))
                    tabla.Columns.Add("Display", typeof(string));
                foreach (DataRow r in tabla.Rows)
                {
                    var id = r["id_cliente"]?.ToString() ?? "";
                    var nombre = r["Nombre"]?.ToString() ?? "";
                    r["Display"] = id + " - " + nombre;
                }
            }
            return tabla;
        }
        public DataTable ObtenerEquiposPorCliente(int idCliente)
        {
            DataTable tabla = new DataTable();
            try
            {
                miConexion = new Conexion();
                conectar = miConexion.getConexion();
                conectar.Open();
                string sql = "SELECT id_equipo, tipo FROM equipo WHERE id_cliente = @id_cliente";
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                {
                    comando.Parameters.AddWithValue("@id_cliente", idCliente);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            finally
            {
                if (conectar != null && conectar.State == ConnectionState.Open) conectar.Close();
            }
            if (!tabla.Columns.Contains("Display"))
                tabla.Columns.Add("Display", typeof(string));
            foreach (DataRow r in tabla.Rows)
            {
                var id = r["id_equipo"]?.ToString() ?? "";
                var tipo = r["tipo"]?.ToString() ?? "";
                r["Display"] = id + " - " + tipo;
            }
            return tabla;
        }

        public int ObtenerReparacionPendientePorEquipo(int idEquipo)
        {
            int idReparacion = 0;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            string sql = "SELECT id_reparacion FROM reparaciones WHERE id_equipo = @idEquipo AND estado = @estado LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(sql, conectar))
            {
                cmd.Parameters.AddWithValue("@idEquipo", idEquipo);
                cmd.Parameters.AddWithValue("@estado", "PENDIENTE");
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    idReparacion = Convert.ToInt32(result);
            }
            conectar.Close();
            return idReparacion;
        }

        public int ObtenerTotalRepuestosPorReparacion(int idReparacion)
        {
            int total = 0;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            string sql = @"
                SELECT COALESCE(SUM(rp.precio), 0)
                FROM reparaciones r
                INNER JOIN repuestos rp ON r.id_repuesto = rp.id_repuesto
                WHERE r.id_reparacion = @idReparacion
            ";
            using (MySqlCommand cmd = new MySqlCommand(sql, conectar))
            {
                cmd.Parameters.AddWithValue("@idReparacion", idReparacion);
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    total = Convert.ToInt32(result);
            }
            conectar.Close();
            return total;
        }

        public int ObtenerTotalRepuestosPorCliente(int idCliente)
        {
            int total = 0;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            string sql = @"
             SELECT SUM(r2.precio)
              FROM reparaciones r
              INNER JOIN equipo e ON r.id_equipo = e.id_equipo
              INNER JOIN repuestos r2 ON r.id_repuesto = r2.id_repuesto
              WHERE e.id_cliente = @idCliente;
               ";
            MySqlCommand cmd = new MySqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            var result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
                total = Convert.ToInt32(result);
            conectar.Close();
            return total;
        }

        public DataTable ObtenerPreviewPagoPorReparacion(int idReparacion, int precioServicio)
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = @"
                SELECT 'Precio Servicio' AS Concepto, @precioServicio AS Monto
                UNION ALL
                SELECT 'Precio Repuestos' AS Concepto, COALESCE((
                    SELECT SUM(rp.precio)
                    FROM reparaciones r
                    INNER JOIN repuestos rp ON r.id_repuesto = rp.id_repuesto
                    WHERE r.id_reparacion = @idReparacion
                ),0) AS Monto
                UNION ALL
                SELECT 'TOTAL' AS Concepto, (@precioServicio + COALESCE((
                    SELECT SUM(rp2.precio)
                    FROM reparaciones r2
                    INNER JOIN repuestos rp2 ON r2.id_repuesto = rp2.id_repuesto
                    WHERE r2.id_reparacion = @idReparacion
                ),0)) AS Monto
            ";
            using (MySqlCommand cmd = new MySqlCommand(sql, conectar))
            {
                cmd.Parameters.AddWithValue("@idReparacion", idReparacion);
                cmd.Parameters.AddWithValue("@precioServicio", precioServicio);
                MySqlDataAdapter adapter = new MySqlDataAdapter { SelectCommand = cmd };
                DataTable tabla = new DataTable();
                tabla.Locale = CultureInfo.InvariantCulture;
                adapter.Fill(tabla);
                conectar.Close();
                return tabla;
            }
        }

        internal bool registrarPago(int precioServicio, int idCliente, DateTime fechaPago, string tipoPago)
        {
            if (idCliente <= 0) return false;
            int precioRepuesto = ObtenerTotalRepuestosPorCliente(idCliente);
            var p = new Pago
            {
                PrecioServicio = precioServicio,
                IdCliente = idCliente,
                FechaPago = fechaPago,
                TipoPago = tipoPago ?? string.Empty,
                PrecioRepuesto = precioRepuesto,
                PrecioTotal = precioServicio + precioRepuesto
            };
            return registrarPago(p);
        }

        internal bool actualizarPago(int idPago, int precioServicio, int idCliente, DateTime fechaPago, string tipoPago, int precioRepuesto)
        {
            if (idPago <= 0) return false;
            var p = new Pago
            {
                IdPago = idPago,
                PrecioServicio = precioServicio,
                IdCliente = idCliente,
                FechaPago = fechaPago,
                TipoPago = tipoPago ?? string.Empty,
                PrecioRepuesto = precioRepuesto,
                PrecioTotal = precioServicio + precioRepuesto
            };
            return actualizarPago(p);
        }

        internal bool registrarPago(Pago p)
        {
            if (p == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO pago (precio_total, fecha_pago, precio_servicio, id_cliente, precio_repuesto, tipo_pago, id_reparacion) " +
                  "VALUES (@precio_total, @fecha_pago, @precio_servicio, @id_cliente, @precio_repuesto, @tipo_pago, @id_reparacion)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@precio_total", p.PrecioTotal);
            comando.Parameters.AddWithValue("@fecha_pago", p.FechaPago);
            comando.Parameters.AddWithValue("@precio_servicio", p.PrecioServicio);
            comando.Parameters.AddWithValue("@id_cliente", p.IdCliente);
            comando.Parameters.AddWithValue("@precio_repuesto", p.PrecioRepuesto);
            comando.Parameters.AddWithValue("@tipo_pago", p.TipoPago ?? string.Empty);
            if (p.Reparacion != null && p.Reparacion.IdReparacion > 0)
                comando.Parameters.AddWithValue("@id_reparacion", p.Reparacion.IdReparacion);
            else
                comando.Parameters.AddWithValue("@id_reparacion", DBNull.Value);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }

        internal bool actualizarPago(Pago p)
        {
            if (p == null || p.IdPago <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "UPDATE pago SET precio_total = @precio_total, fecha_pago = @fecha_pago, tipo_pago = @tipo_pago, id_cliente = @id_cliente, precio_servicio = @precio_servicio, " +
                  "precio_repuesto = @precio_repuesto, id_reparacion = @id_reparacion WHERE id_pago = @id_pago";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@precio_total", p.PrecioTotal);
            comando.Parameters.AddWithValue("@fecha_pago", p.FechaPago);
            comando.Parameters.AddWithValue("@tipo_pago", p.TipoPago ?? string.Empty);
            comando.Parameters.AddWithValue("@precio_servicio", p.PrecioServicio);
            comando.Parameters.AddWithValue("@id_cliente", p.IdCliente);
            comando.Parameters.AddWithValue("@precio_repuesto", p.PrecioRepuesto);
            if (p.Reparacion != null && p.Reparacion.IdReparacion > 0)
                comando.Parameters.AddWithValue("@id_reparacion", p.Reparacion.IdReparacion);
            else
                comando.Parameters.AddWithValue("@id_reparacion", DBNull.Value);
            comando.Parameters.AddWithValue("@id_pago", p.IdPago);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        public bool RegistrarPagoConEquipo(int idCliente, int idEquipo, int precioServicio, DateTime fechaPago, string tipoPago, out int idReparacion, out string mensaje)
        {
            idReparacion = 0;
            mensaje = string.Empty;
            if (idCliente <= 0)
            {
                mensaje = "Id de cliente inválido.";
                return false;
            }
            if (idEquipo <= 0)
            {
                mensaje = "Id de equipo inválido.";
                return false;
            }
            idReparacion = ObtenerReparacionPendientePorEquipo(idEquipo);
            if (idReparacion <= 0)
            {
                mensaje = "No hay reparaciones pendientes para el equipo seleccionado.";
                return false;
            }
            int precioRepuestos = ObtenerTotalRepuestosPorReparacion(idReparacion);
            int precioTotal = precioServicio + precioRepuestos;

            var pago = new Pago
            {
                PrecioServicio = precioServicio,
                IdCliente = idCliente,
                FechaPago = fechaPago,
                TipoPago = tipoPago ?? string.Empty,
                PrecioRepuesto = precioRepuestos,
                PrecioTotal = precioTotal,
                Reparacion = new Reparacion { IdReparacion = idReparacion }
            };

            bool ok = registrarPago(pago);
            if (!ok)
            {
                mensaje = "No se pudo guardar el pago en la base de datos.";
                return false;
            }
            try
            {
                modeloReparaciones mr = new modeloReparaciones();
                mr.MarcarReparacionPagada(idReparacion);
            }
            catch
            {
                mensaje = "Pago guardado, pero no se pudo marcar la reparación como PAGADA.";
            }
            return true;
        }

        internal bool eliminarPagoPorId(int IdPago)
        {
            if (IdPago <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "DELETE FROM pago WHERE id_pago = @id_pago";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_pago", IdPago);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}
