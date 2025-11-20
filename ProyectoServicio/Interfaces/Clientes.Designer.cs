namespace ProyectoServicio
{
    partial class Clientes
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
            this.label_nombreapellido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_NombreYApellido = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.label_Telefono = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombreapellido
            // 
            this.label_nombreapellido.AutoSize = true;
            this.label_nombreapellido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_nombreapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreapellido.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_nombreapellido.Location = new System.Drawing.Point(62, 32);
            this.label_nombreapellido.Name = "label_nombreapellido";
            this.label_nombreapellido.Size = new System.Drawing.Size(136, 16);
            this.label_nombreapellido.TabIndex = 0;
            this.label_nombreapellido.Text = "Nombre y Apellido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(308, 269);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox_NombreYApellido
            // 
            this.textBox_NombreYApellido.Location = new System.Drawing.Point(65, 51);
            this.textBox_NombreYApellido.Name = "textBox_NombreYApellido";
            this.textBox_NombreYApellido.Size = new System.Drawing.Size(308, 22);
            this.textBox_NombreYApellido.TabIndex = 5;
            this.textBox_NombreYApellido.TextChanged += new System.EventHandler(this.textBox_NombreYApellido_TextChanged);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(65, 105);
            this.textBox_Telefono.MaxLength = 20;
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(308, 22);
            this.textBox_Telefono.TabIndex = 6;
            // 
            // label_Telefono
            // 
            this.label_Telefono.AutoSize = true;
            this.label_Telefono.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telefono.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_Telefono.Location = new System.Drawing.Point(62, 86);
            this.label_Telefono.Name = "label_Telefono";
            this.label_Telefono.Size = new System.Drawing.Size(69, 16);
            this.label_Telefono.TabIndex = 8;
            this.label_Telefono.Text = "Telefono";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.Location = new System.Drawing.Point(279, 408);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(65, 408);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 30);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Borrar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModificar.Location = new System.Drawing.Point(165, 408);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 30);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label_Telefono);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_NombreYApellido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_nombreapellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombreapellido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_NombreYApellido;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Label label_Telefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
    }
}