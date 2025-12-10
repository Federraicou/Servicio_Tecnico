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
    public partial class frmUsuarios : Form
    {
        private int selectedUserId = -1;
        public frmUsuarios()
        {
            InitializeComponent();
            cargarDataGrid();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.User = txtNombre.Text;         
                user.Nombre = txtUsuario.Text;     
                user.Password = txtPass.Text;
                user.PasswordConfirma = txtConfirma.Text;
                controlUsuario control = new controlUsuario();
                MessageBox.Show(control.ctrlRegistroUsuarios(user),
                "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtConfirma.Text = "";
            txtNombre.Text = "";
            selectedUserId = -1;
        }
        private void cargarDataGrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                modeloUsuarios m = new modeloUsuarios();
                var tabla = m.obtenerUsuarios();
                dataGridView1.DataSource = tabla;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                if (dataGridView1.Columns.Contains("idUser"))
                    dataGridView1.Columns["idUser"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Columns.Contains("idUser"))
            {
                var idObj = row.Cells["idUser"].Value;
                int.TryParse(idObj?.ToString(), out selectedUserId);
            }
            else
            {
                selectedUserId = -1;
            }
            txtNombre.Text = row.Cells["Nombre de Usuario"].Value?.ToString() ?? "";
            txtUsuario.Text = row.Cells["Nombre Completo"].Value?.ToString() ?? "";
            txtPass.Text = "";
            txtConfirma.Text = "";
        }
        private void button_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId <= 0)
                {
                    MessageBox.Show("Haga doble click en la fila del usuario que quiere modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Usuario user = new Usuario();
                user.User = txtNombre.Text;
                user.Nombre = txtUsuario.Text;
                user.Password = txtPass.Text;
                user.PasswordConfirma = txtConfirma.Text;
                controlUsuario control = new controlUsuario();
                MessageBox.Show(control.ctrlActualizarUsuarioPorId(selectedUserId, user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId <= 0)
                {
                    MessageBox.Show("Haga doble click en la fila del usuario que quiere borrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirm = MessageBox.Show("¿Eliminar el usuario seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
                controlUsuario control = new controlUsuario();
                MessageBox.Show(control.ctrlBorrarUsuarioPorId(selectedUserId), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

