namespace ProyectoServicio
{
    partial class Reparaciones
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
            this.labelEquipo = new System.Windows.Forms.Label();
            this.labelRepuesto = new System.Windows.Forms.Label();
            this.labelDiagnostico = new System.Windows.Forms.Label();
            this.comboBoxRepuesto = new System.Windows.Forms.ComboBox();
            this.comboBoxIdEquipo = new System.Windows.Forms.ComboBox();
            this.textBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.dataGridViewReparaciones = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelFechaEstimada = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEstimada = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEquipo
            // 
            this.labelEquipo.AutoSize = true;
            this.labelEquipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipo.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelEquipo.Location = new System.Drawing.Point(12, 118);
            this.labelEquipo.Name = "labelEquipo";
            this.labelEquipo.Size = new System.Drawing.Size(73, 16);
            this.labelEquipo.TabIndex = 0;
            this.labelEquipo.Text = "Id Equipo";
            // 
            // labelRepuesto
            // 
            this.labelRepuesto.AutoSize = true;
            this.labelRepuesto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepuesto.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelRepuesto.Location = new System.Drawing.Point(12, 185);
            this.labelRepuesto.Name = "labelRepuesto";
            this.labelRepuesto.Size = new System.Drawing.Size(74, 16);
            this.labelRepuesto.TabIndex = 1;
            this.labelRepuesto.Text = "Repuesto";
            // 
            // labelDiagnostico
            // 
            this.labelDiagnostico.AutoSize = true;
            this.labelDiagnostico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnostico.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelDiagnostico.Location = new System.Drawing.Point(9, 248);
            this.labelDiagnostico.Name = "labelDiagnostico";
            this.labelDiagnostico.Size = new System.Drawing.Size(90, 16);
            this.labelDiagnostico.TabIndex = 2;
            this.labelDiagnostico.Text = "Diagnostico";
            // 
            // comboBoxRepuesto
            // 
            this.comboBoxRepuesto.FormattingEnabled = true;
            this.comboBoxRepuesto.Location = new System.Drawing.Point(12, 204);
            this.comboBoxRepuesto.Name = "comboBoxRepuesto";
            this.comboBoxRepuesto.Size = new System.Drawing.Size(200, 24);
            this.comboBoxRepuesto.TabIndex = 3;
            // 
            // comboBoxIdEquipo
            // 
            this.comboBoxIdEquipo.FormattingEnabled = true;
            this.comboBoxIdEquipo.Location = new System.Drawing.Point(12, 137);
            this.comboBoxIdEquipo.Name = "comboBoxIdEquipo";
            this.comboBoxIdEquipo.Size = new System.Drawing.Size(200, 24);
            this.comboBoxIdEquipo.TabIndex = 4;
            // 
            // textBoxDiagnostico
            // 
            this.textBoxDiagnostico.Location = new System.Drawing.Point(12, 267);
            this.textBoxDiagnostico.Name = "textBoxDiagnostico";
            this.textBoxDiagnostico.Size = new System.Drawing.Size(200, 22);
            this.textBoxDiagnostico.TabIndex = 5;
            // 
            // dataGridViewReparaciones
            // 
            this.dataGridViewReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReparaciones.Location = new System.Drawing.Point(218, 45);
            this.dataGridViewReparaciones.Name = "dataGridViewReparaciones";
            this.dataGridViewReparaciones.RowHeadersWidth = 51;
            this.dataGridViewReparaciones.RowTemplate.Height = 24;
            this.dataGridViewReparaciones.Size = new System.Drawing.Size(547, 342);
            this.dataGridViewReparaciones.TabIndex = 6;
            this.dataGridViewReparaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReparaciones_CellDoubleClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBorrar.Location = new System.Drawing.Point(218, 393);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 35);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModificar.Location = new System.Drawing.Point(444, 393);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 35);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.Location = new System.Drawing.Point(668, 393);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 35);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelFechaEstimada
            // 
            this.labelFechaEstimada.AutoSize = true;
            this.labelFechaEstimada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFechaEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaEstimada.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelFechaEstimada.Location = new System.Drawing.Point(9, 318);
            this.labelFechaEstimada.Name = "labelFechaEstimada";
            this.labelFechaEstimada.Size = new System.Drawing.Size(119, 16);
            this.labelFechaEstimada.TabIndex = 10;
            this.labelFechaEstimada.Text = "Fecha Estimada";
            // 
            // dateTimePickerFechaEstimada
            // 
            this.dateTimePickerFechaEstimada.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePickerFechaEstimada.Location = new System.Drawing.Point(12, 337);
            this.dateTimePickerFechaEstimada.Name = "dateTimePickerFechaEstimada";
            this.dateTimePickerFechaEstimada.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaEstimada.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Cliente.Location = new System.Drawing.Point(9, 62);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(60, 18);
            this.Cliente.TabIndex = 13;
            this.Cliente.Text = "Cliente";
            // 
            // Reparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerFechaEstimada);
            this.Controls.Add(this.labelFechaEstimada);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dataGridViewReparaciones);
            this.Controls.Add(this.textBoxDiagnostico);
            this.Controls.Add(this.comboBoxIdEquipo);
            this.Controls.Add(this.comboBoxRepuesto);
            this.Controls.Add(this.labelDiagnostico);
            this.Controls.Add(this.labelRepuesto);
            this.Controls.Add(this.labelEquipo);
            this.Name = "Reparaciones";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.Reparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipo;
        private System.Windows.Forms.Label labelRepuesto;
        private System.Windows.Forms.Label labelDiagnostico;
        private System.Windows.Forms.ComboBox comboBoxRepuesto;
        private System.Windows.Forms.ComboBox comboBoxIdEquipo;
        private System.Windows.Forms.TextBox textBoxDiagnostico;
        private System.Windows.Forms.DataGridView dataGridViewReparaciones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelFechaEstimada;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEstimada;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Cliente;
    }
}