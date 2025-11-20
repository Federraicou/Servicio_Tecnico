namespace ProyectoServicio
{
    partial class frmPrincipal
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu.BackgroundImage = global::ProyectoServicio.Properties.Resources.light_blue_wide_background_with_radial_blurred_gradient_abstract_free_vector;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.equipToolStripMenuItem,
            this.repuestosToolStripMenuItem,
            this.reparacionesToolStripMenuItem,
            this.pagoToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 65);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(982, 45);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyectoServicio.Properties.Resources._391247;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(72, 41);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::ProyectoServicio.Properties.Resources._6326055;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(95, 41);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // equipToolStripMenuItem
            // 
            this.equipToolStripMenuItem.Image = global::ProyectoServicio.Properties.Resources._8193209;
            this.equipToolStripMenuItem.Name = "equipToolStripMenuItem";
            this.equipToolStripMenuItem.Size = new System.Drawing.Size(96, 41);
            this.equipToolStripMenuItem.Text = "Equipos";
            this.equipToolStripMenuItem.Click += new System.EventHandler(this.equipToolStripMenuItem_Click);
            // 
            // repuestosToolStripMenuItem
            // 
            this.repuestosToolStripMenuItem.Image = global::ProyectoServicio.Properties.Resources.procesadorpng;
            this.repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            this.repuestosToolStripMenuItem.Size = new System.Drawing.Size(111, 41);
            this.repuestosToolStripMenuItem.Text = "Repuestos";
            this.repuestosToolStripMenuItem.Click += new System.EventHandler(this.repuestosToolStripMenuItem_Click);
            // 
            // reparacionesToolStripMenuItem
            // 
            this.reparacionesToolStripMenuItem.Image = global::ProyectoServicio.Properties.Resources._4709003;
            this.reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            this.reparacionesToolStripMenuItem.Size = new System.Drawing.Size(132, 41);
            this.reparacionesToolStripMenuItem.Text = "Reparaciones";
            this.reparacionesToolStripMenuItem.Click += new System.EventHandler(this.reparacionesToolStripMenuItem_Click);
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Image = global::ProyectoServicio.Properties.Resources._7758094;
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(76, 41);
            this.pagoToolStripMenuItem.Text = "Pago";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuTitulo.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.menuTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(982, 65);
            this.menuTitulo.TabIndex = 8;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.label_Titulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.Color.Transparent;
            this.label_Titulo.Image = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.label_Titulo.Location = new System.Drawing.Point(22, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(471, 40);
            this.label_Titulo.TabIndex = 7;
            this.label_Titulo.Text = "TERAFIX - Servicio Tecnico";
            this.label_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 110);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(982, 443);
            this.Contenedor.TabIndex = 9;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoServicio.Properties.Resources.photo_1557683316_973673baf926;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionesToolStripMenuItem;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
    }
}