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
            CargarComboEquipos();
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
        private void CargarComboEquipos()
        {
            try
            {
                modeloEquipos me = new modeloEquipos();
                var tabla = me.obtenerEquipos();
                if (tabla != null)
                {
                    comboBoxIdEquipo.DataSource = tabla;
                    comboBoxIdEquipo.ValueMember = "id_equipo";
                    comboBoxIdEquipo.DisplayMember = "id_equipo";
                    comboBoxIdEquipo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando equipos en combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var reparacion = new ProyectoServicio.Reparacion
                {
                    Diagnostico = textBoxDiagnostico.Text.Trim(),
                    IdEquipo = Convert.ToInt32(comboBoxIdEquipo.SelectedValue),
                    FechaEstimada = dateTimePickerFechaEstimada.Value,
                    Idrepuesto = Convert.ToInt32(comboBoxRepuesto.SelectedValue),
                };
                modeloReparaciones mr = new modeloReparaciones();
                bool ok = mr.registrarReparacion(reparacion);
                if (ok)
                {
                    MessageBox.Show("Equipo guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridReparaciones();
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReparacionId <= 0)
                {
                    MessageBox.Show("Seleccione una reparacion (doble click en la fila) para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var reparacion = new Reparacion
                {
                    IdReparacion = selectedReparacionId,
                    Diagnostico = textBoxDiagnostico.Text.Trim(),
                    FechaEstimada = dateTimePickerFechaEstimada.Value,
                    IdEquipo = comboBoxIdEquipo.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxIdEquipo.SelectedValue) : 0,
                    Idrepuesto = comboBoxRepuesto.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxRepuesto.SelectedValue) : 0,
                };
                modeloReparaciones mr = new modeloReparaciones();
                bool ok = mr.actualizarReparacion(reparacion);
                if (ok)
                {
                    MessageBox.Show("Reparacion actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridReparaciones();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la reparacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando Reparacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Equipo eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGridReparaciones();
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
        private void Reparaciones_Load(object sender, EventArgs e)
        {
        }
    }
}
