﻿namespace VENTAS.Vistas
{
    partial class FrmMeniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeniu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarYModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarYEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verYModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verYBuscarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verYBuscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarYModificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditoFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.venderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(100, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(764, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 38);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem,
            this.agregarYModificarToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientesToolStripMenuItem.Image = global::VENTAS.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.buscarClienteToolStripMenuItem.Text = "Ver y Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // agregarYModificarToolStripMenuItem
            // 
            this.agregarYModificarToolStripMenuItem.Name = "agregarYModificarToolStripMenuItem";
            this.agregarYModificarToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.agregarYModificarToolStripMenuItem.Text = "Agregar y Modificar";
            this.agregarYModificarToolStripMenuItem.Click += new System.EventHandler(this.agregarYModificarToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProveedoresToolStripMenuItem,
            this.agregarYEditarToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.proveedoresToolStripMenuItem.Image = global::VENTAS.Properties.Resources.proveedor;
            this.proveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(148, 36);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // buscarProveedoresToolStripMenuItem
            // 
            this.buscarProveedoresToolStripMenuItem.Name = "buscarProveedoresToolStripMenuItem";
            this.buscarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.buscarProveedoresToolStripMenuItem.Text = "Buscar Proveedores";
            this.buscarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.buscarProveedoresToolStripMenuItem_Click);
            // 
            // agregarYEditarToolStripMenuItem
            // 
            this.agregarYEditarToolStripMenuItem.Name = "agregarYEditarToolStripMenuItem";
            this.agregarYEditarToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.agregarYEditarToolStripMenuItem.Text = "Agregar y Modificar";
            this.agregarYEditarToolStripMenuItem.Click += new System.EventHandler(this.agregarYEditarToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verYModificarToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.productosToolStripMenuItem.Image = global::VENTAS.Properties.Resources.producto;
            this.productosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // verYModificarToolStripMenuItem
            // 
            this.verYModificarToolStripMenuItem.Name = "verYModificarToolStripMenuItem";
            this.verYModificarToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.verYModificarToolStripMenuItem.Text = "Agregar y Modificar";
            this.verYModificarToolStripMenuItem.Click += new System.EventHandler(this.verYModificarToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verYBuscarProductosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inventarioToolStripMenuItem.Image = global::VENTAS.Properties.Resources.inventario;
            this.inventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // verYBuscarProductosToolStripMenuItem
            // 
            this.verYBuscarProductosToolStripMenuItem.Name = "verYBuscarProductosToolStripMenuItem";
            this.verYBuscarProductosToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.verYBuscarProductosToolStripMenuItem.Text = "Visualizar";
            this.verYBuscarProductosToolStripMenuItem.Click += new System.EventHandler(this.verYBuscarProductosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verYBuscarEmpleadoToolStripMenuItem,
            this.agregarYModificarToolStripMenuItem1,
            this.cargosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.empleadosToolStripMenuItem.Image = global::VENTAS.Properties.Resources.empleado;
            this.empleadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // verYBuscarEmpleadoToolStripMenuItem
            // 
            this.verYBuscarEmpleadoToolStripMenuItem.Name = "verYBuscarEmpleadoToolStripMenuItem";
            this.verYBuscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.verYBuscarEmpleadoToolStripMenuItem.Text = "Ver y Buscar Empleados";
            this.verYBuscarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.verYBuscarEmpleadoToolStripMenuItem_Click);
            // 
            // agregarYModificarToolStripMenuItem1
            // 
            this.agregarYModificarToolStripMenuItem1.Name = "agregarYModificarToolStripMenuItem1";
            this.agregarYModificarToolStripMenuItem1.Size = new System.Drawing.Size(253, 24);
            this.agregarYModificarToolStripMenuItem1.Text = "Agregar y Modificar";
            this.agregarYModificarToolStripMenuItem1.Click += new System.EventHandler(this.agregarYModificarToolStripMenuItem1_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.creditoFiscalToolStripMenuItem});
            this.venderToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venderToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.venderToolStripMenuItem.Image = global::VENTAS.Properties.Resources.dolar;
            this.venderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(108, 36);
            this.venderToolStripMenuItem.Text = "Vender";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // creditoFiscalToolStripMenuItem
            // 
            this.creditoFiscalToolStripMenuItem.Name = "creditoFiscalToolStripMenuItem";
            this.creditoFiscalToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.creditoFiscalToolStripMenuItem.Text = "Credito Fiscal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VENTAS.Properties.Resources.minimizar;
            this.pictureBox1.Location = new System.Drawing.Point(1185, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 5);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VENTAS.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(1233, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VENTAS.Properties.Resources.dinero2;
            this.pictureBox3.Location = new System.Drawing.Point(7, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 766);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMeniu";
            this.Load += new System.EventHandler(this.FrmMeniu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarYModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarYEditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verYModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verYBuscarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verYBuscarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarYModificarToolStripMenuItem1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditoFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}