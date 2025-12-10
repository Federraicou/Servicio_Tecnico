using MySql.Data.MySqlClient;
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
        private bool cargandoEquipos = false;

        public Pagos()
        {
            InitializeComponent();
            CargarComboClientes();
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            if (this.Controls.ContainsKey("comboBoxEquipo"))
            {
                var cbEquipo = this.Controls["comboBoxEquipo"] as ComboBox;
                if (cbEquipo != null)
                    cbEquipo.SelectedIndexChanged += comboBoxEquipo_SelectedIndexChanged;
            }
            CargarDataGridPago();
        }

        private void LimpiarCampos()
        {
            comboBoxCliente.SelectedIndex = -1;
            if (this.Controls.ContainsKey("comboBoxEquipo"))
                (this.Controls["comboBoxEquipo"] as ComboBox).SelectedIndex = -1;
            txtPrecioServicio.Text = "";
            dateTimePickerPago.Value = DateTime.Now;
            radioButtonEfectivo.Checked = false;
            radioButtonTarjeta.Checked = false;
            selectedPagoId = -1;
            precioRepuestoOriginal = 0;
        }

        private void CargarComboClientes()
        {
            try
            {
                modeloPago mp = new modeloPago();
                var tabla = mp.ObtenerClientesParaCombo();
                if (tabla != null)
                {
                    comboBoxCliente.DataSource = tabla;
                    comboBoxCliente.ValueMember = "id_cliente";
                    comboBoxCliente.DisplayMember = "Display";
                    comboBoxCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando clientes en combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.ContainsKey("comboBoxEquipo")) return;
                var cbEquipo = this.Controls["comboBoxEquipo"] as ComboBox;

                if (comboBoxCliente.SelectedIndex < 0)
                {
                    cargandoEquipos = true;
                    try
                    {
                        cbEquipo.DataSource = null;
                    }
                    finally
                    {
                        cargandoEquipos = false;
                    }
                    return;
                }

                int idCliente;
                if (int.TryParse(comboBoxCliente.SelectedValue?.ToString(), out idCliente))
                {
                    modeloPago mp = new modeloPago();
                    var tabla = mp.ObtenerEquiposPorCliente(idCliente);
                    cargandoEquipos = true;
                    try
                    {
                        cbEquipo.DataSource = tabla;
                        cbEquipo.ValueMember = "id_equipo";
                        cbEquipo.DisplayMember = "Display";
                        cbEquipo.SelectedIndex = -1;
                    }
                    finally
                    {
                        cargandoEquipos = false;
                    }
                }
                else
                {
                    cargandoEquipos = true;
                    try
                    {
                        (this.Controls["comboBoxEquipo"] as ComboBox).DataSource = null;
                    }
                    finally
                    {
                        cargandoEquipos = false;
                    }
                }
            }
            catch (Exception ex)
            {
                cargandoEquipos = false;
                MessageBox.Show("Error cargando equipos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cargandoEquipos) return;

                var cbEquipo = sender as ComboBox;
                if (cbEquipo == null || cbEquipo.SelectedIndex < 0)
                {
                    CargarDataGridPago();
                    return;
                }
                CargarDataGridPago();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (dataGridViewPago.Columns.Contains("Cliente"))
                {
                    var colClienteNombre = dataGridViewPago.Columns["Cliente"];
                    colClienteNombre.HeaderText = "Cliente";
                    colClienteNombre.DisplayIndex = 1;
                    colClienteNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    if (dataGridViewPago.Columns.Contains("id_cliente"))
                    {
                        var colCli = dataGridViewPago.Columns["id_cliente"];
                        colCli.Visible = false;
                    }
                }

                if (dataGridViewPago.Columns.Contains("Equipo"))
                {
                    var colEquipo = dataGridViewPago.Columns["Equipo"];
                    colEquipo.HeaderText = "Equipo";
                    colEquipo.DisplayIndex = 2;
                    colEquipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    if (dataGridViewPago.Columns.Contains("id_reparacion"))
                    {
                        dataGridViewPago.Columns["id_reparacion"].Visible = false;
                    }
                }
                else
                {
                    if (dataGridViewPago.Columns.Contains("id_cliente"))
                    {
                        var colCli = dataGridViewPago.Columns["id_cliente"];
                        colCli.HeaderText = "Id Cliente";
                        colCli.DisplayIndex = 1;
                        colCli.Visible = true;
                        colCli.Width = 80;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCliente.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!this.Controls.ContainsKey("comboBoxEquipo"))
                {
                    MessageBox.Show("No existe control comboBoxEquipo en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var cbEquipo = this.Controls["comboBoxEquipo"] as ComboBox;
                if (cbEquipo.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCliente = Convert.ToInt32(comboBoxCliente.SelectedValue);
                int idEquipo = Convert.ToInt32(cbEquipo.SelectedValue);

                int precioServicio = 0;
                int.TryParse(txtPrecioServicio.Text.Trim(), out precioServicio);

                string tipoPago = radioButtonEfectivo.Checked ? "Efectivo" :
                                  radioButtonTarjeta.Checked ? "Tarjeta" : string.Empty;

                modeloPago mp = new modeloPago();
                int idReparacion;
                string msg;
                bool okPago = mp.RegistrarPagoConEquipo(idCliente, idEquipo, precioServicio, dateTimePickerPago.Value, tipoPago, out idReparacion, out msg);
                if (!okPago)
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Pago guardado y reparación marcada como PAGADA.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDataGridPago();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando pago y actualizando reparación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int idCliente = comboBoxCliente.SelectedIndex >= 0 ? Convert.ToInt32(comboBoxCliente.SelectedValue) : 0;
                string tipoPago = radioButtonEfectivo.Checked ? "Efectivo" :
                                  radioButtonTarjeta.Checked ? "Tarjeta" : string.Empty;

                modeloPago mp = new modeloPago();

                bool ok = mp.actualizarPago(selectedPagoId, precioServicio, idCliente, dateTimePickerPago.Value, tipoPago, precioRepuestoOriginal);
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
        }
    }
}
