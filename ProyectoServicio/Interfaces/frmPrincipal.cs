using ProyectoServicio.Interfaces;
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
    public partial class frmPrincipal : Form
    {
        private static Form formularioActivo = null;
        public void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(formularioHijo);
            Contenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Cerrar sistema, ¿confirma?", "Servicio Técnico", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Login sesion = new Login();
                sesion.Show();
                this.Close();
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AbrirFormulario(new Clientes());
        }
        private void equipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Equipos());
        }
        private void repuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Repuestos());
        }
        private void reparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Reparaciones());
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Pagos());
        }
        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
    }
}
