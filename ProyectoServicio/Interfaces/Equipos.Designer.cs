namespace ProyectoServicio
{
    partial class Equipos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TipoPC = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.comboBox_IdCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Procesador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Ram = new System.Windows.Forms.TextBox();
            this.textBox_Gpu = new System.Windows.Forms.TextBox();
            this.textBox_Fuente = new System.Windows.Forms.TextBox();
            this.textBox_Almacenamiento = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Ingreso";
            // 
            // comboBox_TipoPC
            // 
            this.comboBox_TipoPC.FormattingEnabled = true;
            this.comboBox_TipoPC.Items.AddRange(new object[] {
            "PC OEM",
            "PC de escritorio generica",
            "Notebook"});
            this.comboBox_TipoPC.Location = new System.Drawing.Point(29, 93);
            this.comboBox_TipoPC.Name = "comboBox_TipoPC";
            this.comboBox_TipoPC.Size = new System.Drawing.Size(245, 24);
            this.comboBox_TipoPC.TabIndex = 7;
            // 
            // dateTimePicker_FechaIngreso
            // 
            this.dateTimePicker_FechaIngreso.Location = new System.Drawing.Point(29, 151);
            this.dateTimePicker_FechaIngreso.Name = "dateTimePicker_FechaIngreso";
            this.dateTimePicker_FechaIngreso.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker_FechaIngreso.TabIndex = 8;
            // 
            // comboBox_IdCliente
            // 
            this.comboBox_IdCliente.FormattingEnabled = true;
            this.comboBox_IdCliente.Location = new System.Drawing.Point(28, 35);
            this.comboBox_IdCliente.Name = "comboBox_IdCliente";
            this.comboBox_IdCliente.Size = new System.Drawing.Size(245, 24);
            this.comboBox_IdCliente.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 364);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(26, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Procesador";
            // 
            // textBox_Procesador
            // 
            this.textBox_Procesador.Location = new System.Drawing.Point(29, 204);
            this.textBox_Procesador.Name = "textBox_Procesador";
            this.textBox_Procesador.Size = new System.Drawing.Size(245, 22);
            this.textBox_Procesador.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(26, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ram";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(28, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Almacenamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(26, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fuente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(28, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gpu (Opcional)";
            // 
            // textBox_Ram
            // 
            this.textBox_Ram.Location = new System.Drawing.Point(29, 260);
            this.textBox_Ram.Name = "textBox_Ram";
            this.textBox_Ram.Size = new System.Drawing.Size(245, 22);
            this.textBox_Ram.TabIndex = 17;
            // 
            // textBox_Gpu
            // 
            this.textBox_Gpu.Location = new System.Drawing.Point(28, 313);
            this.textBox_Gpu.Name = "textBox_Gpu";
            this.textBox_Gpu.Size = new System.Drawing.Size(245, 22);
            this.textBox_Gpu.TabIndex = 18;
            // 
            // textBox_Fuente
            // 
            this.textBox_Fuente.Location = new System.Drawing.Point(28, 364);
            this.textBox_Fuente.Name = "textBox_Fuente";
            this.textBox_Fuente.Size = new System.Drawing.Size(245, 22);
            this.textBox_Fuente.TabIndex = 19;
            // 
            // textBox_Almacenamiento
            // 
            this.textBox_Almacenamiento.Location = new System.Drawing.Point(28, 408);
            this.textBox_Almacenamiento.Name = "textBox_Almacenamiento";
            this.textBox_Almacenamiento.Size = new System.Drawing.Size(245, 22);
            this.textBox_Almacenamiento.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.Location = new System.Drawing.Point(759, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 47);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBorrar.Location = new System.Drawing.Point(342, 387);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(147, 49);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModificar.Location = new System.Drawing.Point(547, 387);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 47);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox_Almacenamiento);
            this.Controls.Add(this.textBox_Fuente);
            this.Controls.Add(this.textBox_Gpu);
            this.Controls.Add(this.textBox_Ram);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Procesador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_IdCliente);
            this.Controls.Add(this.dateTimePicker_FechaIngreso);
            this.Controls.Add(this.comboBox_TipoPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_TipoPC;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaIngreso;
        private System.Windows.Forms.ComboBox comboBox_IdCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Procesador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Ram;
        private System.Windows.Forms.TextBox textBox_Gpu;
        private System.Windows.Forms.TextBox textBox_Fuente;
        private System.Windows.Forms.TextBox textBox_Almacenamiento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
    }
}