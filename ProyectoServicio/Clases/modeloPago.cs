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
            sql = "SELECT id_pago, id_cliente, fecha_pago, tipo_pago, precio_servicio, precio_repuesto, precio_total FROM pago";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            MySqlDataAdapter adapter = new MySqlDataAdapter { SelectCommand = comando };
            DataTable tabla = new DataTable();
            tabla.Locale = CultureInfo.InvariantCulture;
            adapter.Fill(tabla);
            conectar.Close();
            return tabla;
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
        internal bool registrarPago(Pago p)
        {
            if (p == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO pago (precio_total, fecha_pago, precio_servicio, id_cliente, precio_repuesto, tipo_pago) " +
                  "VALUES (@precio_total, @fecha_pago, @precio_servicio, @id_cliente, @precio_repuesto, @tipo_pago)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@precio_total", p.PrecioTotal);
            comando.Parameters.AddWithValue("@fecha_pago", p.FechaPago);
            comando.Parameters.AddWithValue("@precio_servicio", p.PrecioServicio);
            comando.Parameters.AddWithValue("@id_cliente", p.IdCliente);
            comando.Parameters.AddWithValue("@precio_repuesto", p.PrecioRepuesto);
            comando.Parameters.AddWithValue("@tipo_pago", p.TipoPago ?? string.Empty);
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
                  "precio_repuesto = @precio_repuesto WHERE id_pago = @id_pago";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@precio_total", p.PrecioTotal);
            comando.Parameters.AddWithValue("@fecha_pago", p.FechaPago);
            comando.Parameters.AddWithValue("@tipo_pago", p.TipoPago ?? string.Empty);
            comando.Parameters.AddWithValue("@precio_servicio", p.PrecioServicio);
            comando.Parameters.AddWithValue("@id_cliente", p.IdCliente);
            comando.Parameters.AddWithValue("@precio_repuesto", p.PrecioRepuesto);
            comando.Parameters.AddWithValue("@id_pago", p.IdPago);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
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
