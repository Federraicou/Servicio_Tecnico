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
    public partial class Equipos : Form
    {
        private int selectedEquipoId = -1;
        public Equipos()
        {
            InitializeComponent();
            CargarComboClientes();
            CargarDataGridEquipos();
        }
        private void CargarComboClientes()
        {
            try
            {
                modeloClientes mc = new modeloClientes();
                var tabla = mc.obtenerClientes(); // devuelve id_cliente, Nombre, Telefono
                if (tabla != null)
                {
                    comboBox_IdCliente.DataSource = tabla;
                    comboBox_IdCliente.ValueMember = "id_cliente";
                    comboBox_IdCliente.DisplayMember = "id_cliente"; // el usuario pidió ver los ids
                    comboBox_IdCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando clientes en combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDataGridEquipos()
        {
            try
            {
                modeloEquipos me = new modeloEquipos();
                var tabla = me.obtenerEquipos();
                dataGridView1.DataSource = tabla;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando equipos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            comboBox_IdCliente.SelectedIndex = -1;
            comboBox_TipoPC.SelectedIndex = -1;
            dateTimePicker_FechaIngreso.Value = DateTime.Now;
            textBox_Procesador.Text = "";
            textBox_Ram.Text = "";
            textBox_Gpu.Text = "";
            textBox_Fuente.Text = "";
            textBox_Almacenamiento.Text = "";
            selectedEquipoId = -1;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            selectedEquipoId = -1;
            if (dataGridView1.Columns.Contains("id_equipo"))
            {
                var idObj = row.Cells["id_equipo"].Value;
                int.TryParse(idObj?.ToString(), out selectedEquipoId);
            }
            textBox_Procesador.Text = row.Cells["procesador"].Value?.ToString() ?? "";
            DateTime fecha;
            if (DateTime.TryParse(row.Cells["fecha_ingreso"].Value?.ToString(), out fecha))
                dateTimePicker_FechaIngreso.Value = fecha;
            comboBox_TipoPC.Text = row.Cells["tipo"].Value?.ToString() ?? "";
            if (dataGridView1.Columns.Contains("id_cliente"))
            {
                var idc = row.Cells["id_cliente"].Value;
                int idCliente;
                if (int.TryParse(idc?.ToString(), out idCliente))
                    comboBox_IdCliente.SelectedValue = idCliente;
            }
            textBox_Ram.Text = row.Cells["ram"].Value?.ToString() ?? "";
            textBox_Fuente.Text = row.Cells["fuente"].Value?.ToString() ?? "";
            textBox_Almacenamiento.Text = row.Cells["almacenamiento"].Value?.ToString() ?? "";
            textBox_Gpu.Text = row.Cells["gpu"].Value?.ToString() ?? "";
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_IdCliente.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un Id de cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var equipo = new ProyectoServicio.Equipo
                {
                    Procesador = textBox_Procesador.Text.Trim(),
                    FechaIngreso = dateTimePicker_FechaIngreso.Value,
                    Tipo = comboBox_TipoPC.Text.Trim(),
                    IdCliente = Convert.ToInt32(comboBox_IdCliente.SelectedValue),
                    Ram = textBox_Ram.Text.Trim(),
                    Fuente = textBox_Fuente.Text.Trim(),
                    Almacenamiento = textBox_Almacenamiento.Text.Trim(),
                    Gpu = textBox_Gpu.Text.Trim()
                };
                modeloEquipos me = new modeloEquipos();
                bool ok = me.registrarEquipo(equipo);
                if (ok)
                {
                    MessageBox.Show("Equipo guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGridEquipos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedEquipoId <= 0)
                {
                    MessageBox.Show("Seleccione un equipo (doble click en la fila) para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var equipo = new Equipo
                {
                    IdEquipo = selectedEquipoId,
                    Procesador = textBox_Procesador.Text.Trim(),
                    FechaIngreso = dateTimePicker_FechaIngreso.Value,
                    Tipo = comboBox_TipoPC.Text.Trim(),
                    IdCliente = comboBox_IdCliente.SelectedIndex >= 0 ? Convert.ToInt32(comboBox_IdCliente.SelectedValue) : 0,
                    Ram = textBox_Ram.Text.Trim(),
                    Fuente = textBox_Fuente.Text.Trim(),
                    Almacenamiento = textBox_Almacenamiento.Text.Trim(),
                    Gpu = textBox_Gpu.Text.Trim()
                };
                modeloEquipos me = new modeloEquipos();
                bool ok = me.actualizarEquipo(equipo);
                if (ok)
                {
                    MessageBox.Show("Equipo actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGridEquipos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedEquipoId <= 0)
                {
                    MessageBox.Show("Seleccione un equipo (doble click en la fila) para borrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("¿Eliminar el equipo seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                modeloEquipos me = new modeloEquipos();
                bool ok = me.eliminarEquipoPorId(selectedEquipoId);
                if (ok)
                {
                    MessageBox.Show("Equipo eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGridEquipos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el equipo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error borrando equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Equipos_Load(object sender, EventArgs e)
        {

        }
    }
}

