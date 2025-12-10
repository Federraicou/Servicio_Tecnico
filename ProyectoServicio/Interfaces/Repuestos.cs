using ProyectoServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio.Interfaces
{
    public partial class Repuestos : Form
    {
        private int selectedRepuestId = -1;
        public Repuestos()
        {
            InitializeComponent();
            cargarDataGrid();

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            selectedRepuestId = -1;
        }
        private void cargarDataGrid()
        {
            try
            {
                dataGridViewRepuestos.DataSource = null;
                modeloRepuestos m = new modeloRepuestos();
                var tabla = m.obtenerRepuestos();
                dataGridViewRepuestos.DataSource = tabla;
                dataGridViewRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridViewRepuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewRepuestos.MultiSelect = false;
                dataGridViewRepuestos.ReadOnly = true;
                if (dataGridViewRepuestos.Columns.Contains("id_repuesto"))
                {
                    var col = dataGridViewRepuestos.Columns["id_repuesto"];
                    col.Visible = true;
                    col.HeaderText = "Id";
                    col.DisplayIndex = 0;
                    col.Width = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando repuestos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Repuestos_Load(object sender, EventArgs e)
        {
        }
        private void dataGridViewRepuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dataGridViewRepuestos.Rows[e.RowIndex];

            if (dataGridViewRepuestos.Columns.Contains("id_repuesto"))
            {
                int.TryParse(fila.Cells["id_repuesto"].Value?.ToString(), out selectedRepuestId);
            }
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
            txtPrecio.Text = fila.Cells["Precio"].Value?.ToString() ?? "";
            txtCantidad.Text = fila.Cells["Cantidad"].Value?.ToString() ?? "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int precio = 0;
            int cantidad = 0;
            int.TryParse(txtPrecio.Text, out precio);
            int.TryParse(txtCantidad.Text, out cantidad);
            modeloRepuestos m = new modeloRepuestos();
            bool ok = m.registrarRepuesto(nombre, precio, cantidad);
            if (ok)
            {
                MessageBox.Show("Repuesto guardado correctamente.");
                cargarDataGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el repuesto.");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedRepuestId <= 0)
            {
                MessageBox.Show("Seleccione un repuesto haciendo doble clic.");
                return;
            }
            string nombre = txtNombre.Text;
            int precio = 0;
            int cantidad = 0;
            int.TryParse(txtPrecio.Text, out precio);
            int.TryParse(txtCantidad.Text, out cantidad);
            modeloRepuestos m = new modeloRepuestos();
            bool ok = m.actualizarRepuesto(selectedRepuestId, nombre, precio, cantidad);
            if (ok)
            {
                MessageBox.Show("Repuesto actualizado correctamente.");
                cargarDataGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el repuesto.");
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (selectedRepuestId <= 0)
            {
                MessageBox.Show("Seleccione un repuesto para eliminar.");
                return;
            }
            modeloRepuestos m = new modeloRepuestos();
            if (m.eliminarRepuestoPorId(selectedRepuestId))
            {
                MessageBox.Show("Repuesto eliminado correctamente.");
                cargarDataGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el repuesto.");
            }
        }
    }
}

