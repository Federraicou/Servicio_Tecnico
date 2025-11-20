namespace ProyectoServicio.Interfaces
{
    partial class Repuestos
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
            this.labelRepuesto = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dataGridViewRepuestos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRepuesto
            // 
            this.labelRepuesto.AutoSize = true;
            this.labelRepuesto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepuesto.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelRepuesto.Location = new System.Drawing.Point(164, 107);
            this.labelRepuesto.Name = "labelRepuesto";
            this.labelRepuesto.Size = new System.Drawing.Size(127, 16);
            this.labelRepuesto.TabIndex = 0;
            this.labelRepuesto.Text = "Nombre repuesto";
            this.labelRepuesto.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelPrecio.Location = new System.Drawing.Point(164, 170);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(52, 16);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 126);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(163, 189);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(175, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // dataGridViewRepuestos
            // 
            this.dataGridViewRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepuestos.Location = new System.Drawing.Point(407, 35);
            this.dataGridViewRepuestos.Name = "dataGridViewRepuestos";
            this.dataGridViewRepuestos.RowHeadersWidth = 51;
            this.dataGridViewRepuestos.RowTemplate.Height = 24;
            this.dataGridViewRepuestos.Size = new System.Drawing.Size(339, 304);
            this.dataGridViewRepuestos.TabIndex = 4;
            this.dataGridViewRepuestos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRepuestos_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.Location = new System.Drawing.Point(641, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 34);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(163, 263);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(175, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelCantidad.Location = new System.Drawing.Point(160, 244);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(69, 16);
            this.labelCantidad.TabIndex = 7;
            this.labelCantidad.Text = "Cantidad";
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModificar.Location = new System.Drawing.Point(518, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 34);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBorrar.Location = new System.Drawing.Point(407, 345);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(105, 34);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Repuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridViewRepuestos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelRepuesto);
            this.Name = "Repuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.Repuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRepuesto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dataGridViewRepuestos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
    }
}