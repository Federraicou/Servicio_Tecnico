using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoServicio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Cerrar sistema, ¿confirma?", "Servicio Tecnico",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox_Contraseña_TextChanged(object sender, EventArgs e)
        {
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = textBox_Usuario.Text.Trim();
                String pass = textBox_Contraseña.Text;
                controlSesion control = new controlSesion();
                String respuestaControlador = control.ctrlLogin(usuario, pass);
                if (respuestaControlador == "¡Bienvenido!")
                {
                    MessageBox.Show(respuestaControlador, "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPrincipal p = new frmPrincipal();
                    this.Visible = false; 
                    p.Show();
                }
                else
                {
                    MessageBox.Show(respuestaControlador, "Control de usuarios",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (string.IsNullOrEmpty(textBox_Usuario.Text))
                        textBox_Usuario.Focus();
                    else
                        textBox_Contraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBox_Usuario_TextChanged(object sender, EventArgs e)
        {
        }
        private void button_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new frmUsuarios())
                {
                    form.ShowDialog(this);
                }
                textBox_Usuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_Contraseña.Text = "";
            textBox_Usuario.Text = "";
        }
    }
}
