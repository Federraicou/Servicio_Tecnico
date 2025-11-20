using System;
using System.Windows.Forms;

namespace ProyectoServicio
{
    public partial class Clientes : Form
    {
        private int selectedClientId = -1;
        public Clientes()
        {
            InitializeComponent();
            cargarDataGrid();
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
        }
        private void LimpiarCampos()
        {
            textBox_NombreYApellido.Text = "";
            textBox_Telefono.Text = "";
            selectedClientId = -1;
        }
        private void cargarDataGrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                modeloClientes m = new modeloClientes();
                var tabla = m.obtenerClientes();
                dataGridView1.DataSource = tabla;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.ReadOnly = true;
                if (dataGridView1.Columns.Contains("id_cliente"))
                {
                    var col = dataGridView1.Columns["id_cliente"];
                    col.Visible = true;
                    col.HeaderText = "Id";
                    col.DisplayIndex = 0;
                    col.Width = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var grid = dataGridView1;
            var row = grid.Rows[e.RowIndex];
            selectedClientId = -1;
            if (grid.Columns.Contains("id_cliente"))
            {
                var idObj = row.Cells["id_cliente"].Value;
                int.TryParse(idObj?.ToString(), out selectedClientId);
            }
            var nombre = row.Cells["Nombre"].Value?.ToString() ?? "";
            string telefono = "";
            if (grid.Columns.Contains("Telefono"))
            {
                telefono = row.Cells["Telefono"].Value?.ToString() ?? "";
            }
            else if (grid.Columns.Contains("Teléfono"))
            {
                telefono = row.Cells["Teléfono"].Value?.ToString() ?? "";
            }
            textBox_NombreYApellido.Text = nombre;
            textBox_Telefono.Text = telefono;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox_NombreYApellido.Text.Trim();
                string telefono = textBox_Telefono.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Ingrese nombre (nombre + apellido si corresponde).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_NombreYApellido.Focus();
                    return;
                }
                modeloClientes m = new modeloClientes();
                Cliente cli = new Cliente(nombre, telefono);
                bool ok = m.registrarCliente(cli);
                if (ok)
                {
                    MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedClientId <= 0)
                {
                    MessageBox.Show("Haga doble click en la fila del cliente que quiere modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string nombre = textBox_NombreYApellido.Text.Trim();
                string telefono = textBox_Telefono.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Ingrese nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_NombreYApellido.Focus();
                    return;
                }
                modeloClientes m = new modeloClientes();
                Cliente cli = new Cliente(nombre, telefono) { IdCliente = selectedClientId };
                bool ok = m.actualizarCliente(cli);
                if (ok)
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDataGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedClientId > 0)
                {
                    var confirm = MessageBox.Show("¿Eliminar el cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm != DialogResult.Yes) return;
                    modeloClientes m = new modeloClientes();
                    bool ok = m.eliminarClientePorId(selectedClientId);
                    if (ok)
                    {
                        MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDataGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error borrando cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_NombreYApellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
