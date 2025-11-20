namespace ProyectoServicio
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Modificar = new System.Windows.Forms.Button();
            this.button_Borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(657, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancelar.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Cancelar.Location = new System.Drawing.Point(98, 363);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(244, 30);
            this.button_Cancelar.TabIndex = 1;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(95, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre y Apellido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(92, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(95, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(98, 95);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(244, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(95, 208);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(244, 22);
            this.txtPass.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(95, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirme contraseña";
            // 
            // txtConfirma
            // 
            this.txtConfirma.Location = new System.Drawing.Point(95, 261);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.PasswordChar = '*';
            this.txtConfirma.Size = new System.Drawing.Size(244, 22);
            this.txtConfirma.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(372, 326);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cargarDataGrid_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Modificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Modificar.Location = new System.Drawing.Point(535, 363);
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.Size = new System.Drawing.Size(106, 30);
            this.button_Modificar.TabIndex = 14;
            this.button_Modificar.Text = "Modificar";
            this.button_Modificar.UseVisualStyleBackColor = true;
            this.button_Modificar.Click += new System.EventHandler(this.button_Modificar_Click);
            // 
            // button_Borrar
            // 
            this.button_Borrar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.button_Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Borrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_Borrar.Location = new System.Drawing.Point(391, 363);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(106, 30);
            this.button_Borrar.TabIndex = 15;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Modificar;
        private System.Windows.Forms.Button button_Borrar;
    }
}