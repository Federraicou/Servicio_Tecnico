using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio
{
    public partial class Reparaciones : Form
    {
        private int selectedReparacionId = -1;
        public Reparaciones()
        {
            InitializeComponent();
            CargarComboClientes();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            CargarComboRepuestos();
            cargarDataGridReparaciones();
        }

        private void LimpiarCampos()
        {
            comboBoxIdEquipo.SelectedIndex = -1;
            comboBoxRepuesto.SelectedIndex = -1;
            textBoxDiagnostico.Text = "";
            selectedReparacionId = -1;
            dateTimePickerFechaEstimada.Value = DateTime.Now;
        }

       
        private void CargarComboClientes()
        {
            try
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

                    comboBox1.DataSource = tabla;
                    comboBox1.ValueMember = "id_cliente";
                    comboBox1.DisplayMember = "Display";
                    comboBox1.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando clientes en combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    comboBoxIdEquipo.DataSource = null;
                    return;
                }

                int idCliente;
                if (int.TryParse(comboBox1.SelectedValue?.ToString(), out idCliente))
                {
                    CargarEquiposPorCliente(idCliente);
                }
                else
                {
                    comboBoxIdEquipo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEquiposPorCliente(int idCliente)
        {
            try
            {
                Conexion miConexion = new Conexion();
                using (MySqlConnection conectar = miConexion.getConexion())
                {
                    conectar.Open();
                    string sql = "SELECT id_equipo, tipo FROM equipo WHERE id_cliente = @id_cliente";
                    using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                    {
                        comando.Parameters.AddWithValue("@id_cliente", idCliente);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            adapter.Fill(tabla);
                            if (!tabla.Columns.Contains("Display"))
                                tabla.Columns.Add("Display", typeof(string));
                            foreach (DataRow r in tabla.Rows)
                            {
                                var id = r["id_equipo"]?.ToString() ?? "";
                                var tipo = r["tipo"]?.ToString() ?? "";
                                r["Display"] = id + " - " + tipo;
                            }

                            comboBoxIdEquipo.DataSource = tabla;
                            comboBoxIdEquipo.ValueMember = "id_equipo";   
                            comboBoxIdEquipo.DisplayMember = "Display";   
                            comboBoxIdEquipo.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando equipos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboRepuestos()
        {
            try
            {
                modeloRepuestos mr = new modeloRepuestos();
                var tabla = mr.obtenerRepuestos();
                if (tabla != null)
                {
                    comboBoxRepuesto.DataSource = tabla;
                    comboBoxRepuesto.ValueMember = "id_repuesto";
                    comboBoxRepuesto.DisplayMember = "nombre";
                    comboBoxRepuesto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando repuestos en combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDataGridReparaciones()
        {
            try
            {
                dataGridViewReparaciones.DataSource = null;
                modeloReparaciones mr = new modeloReparaciones();
                var tabla = mr.obtenerReparaciones();
                dataGridViewReparaciones.DataSource = tabla;
                dataGridViewReparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridViewReparaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewReparaciones.MultiSelect = false;
                dataGridViewReparaciones.ReadOnly = true;
                if (dataGridViewReparaciones.Columns.Contains("id_reparacion"))
                {
                    var col = dataGridViewReparaciones.Columns["id_reparacion"];
                    col.Visible = true;
                    col.HeaderText = "Id reparacion";
                    col.DisplayIndex = 0;
                    col.Width = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando reparacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewReparaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var grid = dataGridViewReparaciones;
            var row = grid.Rows[e.RowIndex];
            DateTime fecha;
            if (DateTime.TryParse(row.Cells["fecha_estimada"].Value?.ToString(), out fecha))
                dateTimePickerFechaEstimada.Value = fecha;
            selectedReparacionId = -1;
            if (grid.Columns.Contains("id_reparacion"))
            {
                var idObj = row.Cells["id_reparacion"].Value;
                int.TryParse(idObj?.ToString(), out selectedReparacionId);
            }
            if (dataGridViewReparaciones.Columns.Contains("id_repuesto"))
            {
                var idc = row.Cells["id_repuesto"].Value;
                int idRepuesto;
                if (int.TryParse(idc?.ToString(), out idRepuesto))
                    comboBoxRepuesto.SelectedValue = idRepuesto;
            }
            if (dataGridViewReparaciones.Columns.Contains("id_equipo"))
            {
                var idc = row.Cells["id_equipo"].Value;
                int idEquipo;
                if (int.TryParse(idc?.ToString(), out idEquipo))
                    comboBoxIdEquipo.SelectedValue = idEquipo;
            }
            var diagnostico = row.Cells["diagnostico"].Value?.ToString() ?? "";
            textBoxDiagnostico.Text = diagnostico;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxIdEquipo.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un Id de Equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string diagnostico = textBoxDiagnostico.Text.Trim();
                int idEquipo = Convert.ToInt32(comboBoxIdEquipo.SelectedValue);
                DateTime fechaEstimada = dateTimePickerFechaEstimada.Value;
                int idRepuesto = comboBoxRepuesto.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxRepuesto.SelectedValue) : 0;

                modeloReparaciones mr = new modeloReparaciones();
                bool ok = mr.registrarReparacion(diagnostico, idEquipo, fechaEstimada, idRepuesto);
                if (ok)
                {
                    MessageBox.Show("Reparación guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridReparaciones();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la reparación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando reparación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReparacionId <= 0)
                {
                    MessageBox.Show("Seleccione una reparacion (doble click en la fila) para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string diagnostico = textBoxDiagnostico.Text.Trim();
                int idEquipo = comboBoxIdEquipo.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxIdEquipo.SelectedValue) : 0;
                DateTime fechaEstimada = dateTimePickerFechaEstimada.Value;
                int idRepuesto = comboBoxRepuesto.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxRepuesto.SelectedValue) : 0;

                modeloReparaciones mr = new modeloReparaciones();
                bool ok = mr.actualizarReparacion(selectedReparacionId, diagnostico, idEquipo, fechaEstimada, idRepuesto);
                if (ok)
                {
                    MessageBox.Show("Reparación actualizada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridReparaciones();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la reparación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando reparación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReparacionId <= 0)
                {
                    MessageBox.Show("Seleccione un equipo (doble click en la fila) para borrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirm = MessageBox.Show("¿Eliminar el equipo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
                modeloReparaciones mr = new modeloReparaciones();
                bool ok = mr.eliminarReparacionPorId(selectedReparacionId);
                if (ok)
                {
                    MessageBox.Show("Reparación eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridReparaciones();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la reparación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error borrando reparación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reparaciones_Load(object sender, EventArgs e)
        {
        }
    }
}
