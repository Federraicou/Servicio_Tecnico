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
        public frmUsuarios()
        {
            InitializeComponent();
        }

  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.User = txtUsuario.Text;
                user.Password = txtPass.Text;
                user.PasswordConfirma = txtConfirma.Text;
                user.Nombre = txtNombre.Text;
                user.IdTipo = int.Parse(comboTipos.SelectedValue.ToString());
                controlUsuario control = new controlUsuario();
                MessageBox.Show(control.ctrlRegistroUsuarios(user),
                "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
