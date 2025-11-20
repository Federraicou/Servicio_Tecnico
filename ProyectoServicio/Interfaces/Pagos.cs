using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ProyectoServicio
{
    public partial class Pagos : Form
    {
        private int selectedPagoId = -1;
        private int precioRepuestoOriginal = 0;

        public Pagos()
        {
            InitializeComponent();
            CargarComboClientes();
            CargarDataGridPago();

        }
        private void LimpiarCampos()
        {
            comboBoxCliente.SelectedIndex = -1;
            txtPrecioServicio.Text = "";
            dateTimePickerPago.Value = DateTime.Now;
            radioButtonEfectivo.Checked = false;
            radioButtonTarjeta.Checked = false;
            selectedPagoId = -1;
        }
        private void CargarComboClientes()
        {
            try
            {
                modeloClientes mc = new modeloClientes();
                var tabla = mc.obtenerClientes(); // devuelve id_cliente, Nombre, Telefono
                if (tabla != null)
                {
                    comboBoxCliente.DataSource = tabla;
                    comboBoxCliente.ValueMember = "id_cliente";
                    comboBoxCliente.DisplayMember = "id_cliente"; // el usuario pidió ver los ids
                    comboBoxCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando clientes en combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDataGridPago()
        {
            try
            {
                dataGridViewPago.DataSource = null;
                modeloPago mp = new modeloPago();
                var tabla = mp.obtenerPago();
                dataGridViewPago.DataSource = tabla;
                dataGridViewPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridViewPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewPago.MultiSelect = false;
                dataGridViewPago.ReadOnly = true;
                if (dataGridViewPago.Columns.Contains("id_pago"))
                {
                    var col = dataGridViewPago.Columns["id_pago"];
                    col.Visible = true;
                    col.HeaderText = "Id pago";
                    col.DisplayIndex = 0;
                    col.Width = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0) return;
            var row = dataGridViewPago.Rows[e.RowIndex];
            selectedPagoId = -1;
            if (dataGridViewPago.Columns.Contains("id_pago"))
            {
                var idObj = row.Cells["id_pago"].Value;
                int.TryParse(idObj?.ToString(), out selectedPagoId);
            }
            if (dataGridViewPago.Columns.Contains("precio_repuesto"))
            {
                var pr = row.Cells["precio_repuesto"].Value?.ToString() ?? "0";
                int.TryParse(pr, out precioRepuestoOriginal);
            }
            DateTime fecha;
            if (DateTime.TryParse(row.Cells["fecha_pago"].Value?.ToString(), out fecha))
                dateTimePickerPago.Value = fecha;
            else
                dateTimePickerPago.Value = DateTime.Now;
            var precioServStr = row.Cells["precio_servicio"].Value?.ToString() ?? "0";
            txtPrecioServicio.Text = precioServStr;
            var tipo = row.Cells["tipo_pago"].Value?.ToString() ?? "";
            radioButtonEfectivo.Checked = string.Equals(tipo, "Efectivo", StringComparison.OrdinalIgnoreCase);
            radioButtonTarjeta.Checked = string.Equals(tipo, "Tarjeta", StringComparison.OrdinalIgnoreCase);
            if (dataGridViewPago.Columns.Contains("id_cliente"))
            {
                var idc = row.Cells["id_cliente"].Value;
                int idCliente;
                if (int.TryParse(idc?.ToString(), out idCliente))
                    comboBoxCliente.SelectedValue = idCliente;
                else
                    comboBoxCliente.SelectedIndex = -1;
            }
            if (dataGridViewPago.Columns.Contains("precio_repuesto"))
            {
                var pr = row.Cells["precio_repuesto"].Value?.ToString() ?? "0";
                int.TryParse(pr, out precioRepuestoOriginal);
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCliente.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un Id de cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int precioServicio = 0;
                int.TryParse(txtPrecioServicio.Text.Trim(), out precioServicio);
                int idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                modeloPago mp = new modeloPago();
                int precioRepuesto = mp.ObtenerTotalRepuestosPorCliente(idCliente);
                var pago = new ProyectoServicio.Pago
                {
                    PrecioServicio = precioServicio,
                    IdCliente = idCliente,
                    FechaPago = dateTimePickerPago.Value,
                    TipoPago = radioButtonEfectivo.Checked ? "Efectivo" :
                    radioButtonTarjeta.Checked ? "Tarjeta" : string.Empty,
                    PrecioRepuesto = precioRepuesto,
                    PrecioTotal = precioServicio + precioRepuesto
                };
                bool ok = mp.registrarPago(pago);
                if (ok)
                {
                    MessageBox.Show("Pago guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGridPago();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedPagoId <= 0)
                {
                    MessageBox.Show("Seleccione un pago (doble click en la fila) para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int precioServicio = 0;
                int.TryParse(txtPrecioServicio.Text.Trim(), out precioServicio);
                var pago = new Pago
                {
                    IdPago = selectedPagoId,
                    PrecioServicio = precioServicio,
                    IdCliente = comboBoxCliente.SelectedIndex >= 0? Convert.ToInt32(comboBoxCliente.SelectedValue): 0,
                    FechaPago = dateTimePickerPago.Value,
                    TipoPago = radioButtonEfectivo.Checked ? "Efectivo" :
                    radioButtonTarjeta.Checked ? "Tarjeta" : string.Empty,
                    PrecioRepuesto = precioRepuestoOriginal
                };
                pago.PrecioTotal = pago.PrecioServicio + pago.PrecioRepuesto;
                modeloPago mp = new modeloPago();
                bool ok = mp.actualizarPago(pago);
                if (ok)
                {
                    MessageBox.Show("Pago actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGridPago();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedPagoId <= 0)
                {
                    MessageBox.Show("Seleccione un pago (doble click en la fila) para borrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirm = MessageBox.Show("¿Eliminar el pago seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                modeloPago mp = new modeloPago();
                bool ok = mp.eliminarPagoPorId(selectedPagoId);
                if (ok)
                {
                    MessageBox.Show("Pago eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDataGridPago();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error borrando pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Pagos_Load(object sender, EventArgs e)
        { 
        }
        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
