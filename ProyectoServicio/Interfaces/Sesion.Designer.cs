namespace ProyectoServicio
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.textBox_Contraseña = new System.Windows.Forms.TextBox();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Login.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Login.Location = new System.Drawing.Point(218, 307);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(231, 48);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Salir.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Salir.Location = new System.Drawing.Point(97, 412);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(115, 48);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Usuario
            // 
            this.label_Usuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.ForeColor = System.Drawing.Color.Transparent;
            this.label_Usuario.Location = new System.Drawing.Point(97, 177);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(125, 22);
            this.label_Usuario.TabIndex = 3;
            this.label_Usuario.Text = "Usuario";
            this.label_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Contraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contraseña.ForeColor = System.Drawing.Color.Transparent;
            this.label_Contraseña.Location = new System.Drawing.Point(97, 241);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(125, 22);
            this.label_Contraseña.TabIndex = 4;
            this.label_Contraseña.Text = "Contraseña";
            this.label_Contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Contraseña
            // 
            this.textBox_Contraseña.Location = new System.Drawing.Point(97, 266);
            this.textBox_Contraseña.Name = "textBox_Contraseña";
            this.textBox_Contraseña.PasswordChar = '*';
            this.textBox_Contraseña.Size = new System.Drawing.Size(352, 22);
            this.textBox_Contraseña.TabIndex = 5;
            this.textBox_Contraseña.TextChanged += new System.EventHandler(this.textBox_Usuario_TextChanged);
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(97, 202);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(352, 22);
            this.textBox_Usuario.TabIndex = 6;
            this.textBox_Usuario.TextChanged += new System.EventHandler(this.textBox_Contraseña_TextChanged);
            // 
            // button_Registrar
            // 
            this.button_Registrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Registrar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Registrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Registrar.Location = new System.Drawing.Point(218, 412);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(231, 48);
            this.button_Registrar.TabIndex = 7;
            this.button_Registrar.Text = "Registrar";
            this.button_Registrar.UseVisualStyleBackColor = false;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button1.Location = new System.Drawing.Point(97, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ProyectoServicio.Properties.Resources._561245788_17882792607391828_2463019645797791582_n;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(155, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 129);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.pngtree_digital_program_boxes_in_computer_world_future_internet_web_photo_image_26635096;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.textBox_Contraseña);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.TextBox textBox_Contraseña;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

