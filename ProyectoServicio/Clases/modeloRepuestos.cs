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
    public class modeloRepuestos
    {

        private Conexion miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        public DataTable obtenerRepuestos()
        {
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT id_repuesto, nombre AS `Nombre`, precio AS `precio`, cantidad AS `Cantidad`  FROM repuestos";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            tabla.Locale = CultureInfo.InvariantCulture;
            adapter.Fill(tabla);
            conectar.Close();
            return tabla;
        }

        
        internal bool registrarRepuesto(string nombre, int precio, int cantidad)
        {
            var r = new Repuesto(nombre, precio, cantidad);
            return registrarRepuesto(r);
        }

        
        internal bool actualizarRepuesto(int idRepuesto, string nombre, int precio, int cantidad)
        {
            var r = new Repuesto(nombre, precio, cantidad) { Idrepuesto = idRepuesto };
            return actualizarRepuesto(r);
        }

        internal bool registrarRepuesto(Repuesto r)
        {
            if (r == null) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO repuestos (nombre, precio, cantidad) VALUES (@nombre, @precio, @cantidad)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@nombre", r.Nombre ?? string.Empty);
            comando.Parameters.AddWithValue("@precio", r.Precio);
            comando.Parameters.AddWithValue("@cantidad", r.Cantidad);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool actualizarRepuesto(Repuesto r)
        {
            if (r == null || r.Idrepuesto <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "UPDATE repuestos SET nombre = @nombre, cantidad = @cantidad, precio = @precio WHERE id_repuesto = @id_repuesto";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@nombre", r.Nombre ?? string.Empty);
            comando.Parameters.AddWithValue("@precio", r.Precio);
            comando.Parameters.AddWithValue("@cantidad", r.Cantidad);
            comando.Parameters.AddWithValue("@id_repuesto", r.Idrepuesto);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
        internal bool eliminarRepuestoPorId(int idRepuesto)
        {
            if (idRepuesto <= 0) return false;
            miConexion = new Conexion();
            conectar = miConexion.getConexion();
            conectar.Open();

            sql = "DELETE FROM repuestos WHERE id_repuesto = @id_repuesto";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_repuesto", idRepuesto);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }
    }
}
