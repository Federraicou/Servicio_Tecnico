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
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Contraseña = new System.Windows.Forms.TextBox();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Cancelar.Location = new System.Drawing.Point(16, 191);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(132, 36);
            this.button_Cancelar.TabIndex = 0;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Login.Location = new System.Drawing.Point(292, 137);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(132, 36);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Salir.Location = new System.Drawing.Point(154, 137);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(132, 36);
            this.button_Salir.TabIndex = 2;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.Location = new System.Drawing.Point(12, 64);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(73, 20);
            this.label_Usuario.TabIndex = 3;
            this.label_Usuario.Text = "Usuario";
            this.label_Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label_Contraseña.Location = new System.Drawing.Point(12, 98);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(104, 20);
            this.label_Contraseña.TabIndex = 4;
            this.label_Contraseña.Text = "Contraseña";
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(154, 96);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.PasswordChar = '*';
            this.textBox_Usuario.Size = new System.Drawing.Size(270, 22);
            this.textBox_Usuario.TabIndex = 5;
            this.textBox_Usuario.TextChanged += new System.EventHandler(this.textBox_Usuario_TextChanged);
            // 
            // textBox_Contraseña
            // 
            this.textBox_Contraseña.Location = new System.Drawing.Point(154, 62);
            this.textBox_Contraseña.Name = "textBox_Contraseña";
            this.textBox_Contraseña.Size = new System.Drawing.Size(270, 22);
            this.textBox_Contraseña.TabIndex = 6;
            this.textBox_Contraseña.TextChanged += new System.EventHandler(this.textBox_Contraseña_TextChanged);
            // 
            // button_Registrar
            // 
            this.button_Registrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.button_Registrar.Location = new System.Drawing.Point(16, 138);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(132, 36);
            this.button_Registrar.TabIndex = 7;
            this.button_Registrar.Text = "Registrar";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 239);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.textBox_Contraseña);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Usuario);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button_Cancelar);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Contraseña;
        private System.Windows.Forms.Button button_Registrar;
    }
}

