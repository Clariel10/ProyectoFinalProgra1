namespace VENTAS.Vistas
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTickect = new System.Windows.Forms.CheckBox();
            this.cbFactura = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoiCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarProdcuto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.lblNombreCajero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pdImprimir = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.UNITARIO,
            this.CANTIDAD,
            this.tol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(17, 104);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(656, 391);
            this.dgvDetalleVenta.TabIndex = 0;
            this.dgvDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDetalleVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalleVenta_RowsRemoved);
            // 
            // CODIGO
            // 
            this.CODIGO.FillWeight = 50F;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.FillWeight = 150F;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // UNITARIO
            // 
            this.UNITARIO.FillWeight = 50F;
            this.UNITARIO.HeaderText = "P. UNIT.";
            this.UNITARIO.Name = "UNITARIO";
            this.UNITARIO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.FillWeight = 50F;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // tol
            // 
            this.tol.FillWeight = 50F;
            this.tol.HeaderText = "TOTAL";
            this.tol.Name = "tol";
            this.tol.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tipo de Documento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdVenta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTipoDocumento);
            this.panel1.Location = new System.Drawing.Point(485, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.Location = new System.Drawing.Point(104, 58);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(22, 24);
            this.lblIdVenta.TabIndex = 2;
            this.lblIdVenta.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "N";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(46, 5);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(121, 48);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "FACTURA\r\n  VENTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.cbTickect);
            this.panel2.Controls.Add(this.cbFactura);
            this.panel2.Location = new System.Drawing.Point(26, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 55);
            this.panel2.TabIndex = 34;
            // 
            // cbTickect
            // 
            this.cbTickect.AutoSize = true;
            this.cbTickect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTickect.ForeColor = System.Drawing.Color.DimGray;
            this.cbTickect.Location = new System.Drawing.Point(123, 19);
            this.cbTickect.Name = "cbTickect";
            this.cbTickect.Size = new System.Drawing.Size(80, 22);
            this.cbTickect.TabIndex = 3;
            this.cbTickect.Text = "Tickect";
            this.cbTickect.UseVisualStyleBackColor = true;
            this.cbTickect.CheckedChanged += new System.EventHandler(this.cbTickect_CheckedChanged);
            // 
            // cbFactura
            // 
            this.cbFactura.AutoSize = true;
            this.cbFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactura.ForeColor = System.Drawing.Color.DimGray;
            this.cbFactura.Location = new System.Drawing.Point(22, 20);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(82, 22);
            this.cbFactura.TabIndex = 2;
            this.cbFactura.Text = "Factura";
            this.cbFactura.UseVisualStyleBackColor = true;
            this.cbFactura.CheckedChanged += new System.EventHandler(this.cbFactura_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnNuevoiCliente);
            this.panel3.Controls.Add(this.btnBuscarCliente);
            this.panel3.Controls.Add(this.txtDUI);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtApellidoCliente);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtDireccion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNombreCliente);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(26, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 116);
            this.panel3.TabIndex = 36;
            // 
            // btnNuevoiCliente
            // 
            this.btnNuevoiCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoiCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoiCliente.Image = global::VENTAS.Properties.Resources.nuevo;
            this.btnNuevoiCliente.Location = new System.Drawing.Point(610, 46);
            this.btnNuevoiCliente.Name = "btnNuevoiCliente";
            this.btnNuevoiCliente.Size = new System.Drawing.Size(41, 42);
            this.btnNuevoiCliente.TabIndex = 63;
            this.btnNuevoiCliente.UseVisualStyleBackColor = true;
            this.btnNuevoiCliente.Click += new System.EventHandler(this.btnNuevoiCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Image = global::VENTAS.Properties.Resources.buscar;
            this.btnBuscarCliente.Location = new System.Drawing.Point(602, 6);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(41, 42);
            this.btnBuscarCliente.TabIndex = 42;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            this.btnBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBuscarCliente_KeyDown);
            // 
            // txtDUI
            // 
            this.txtDUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDUI.Enabled = false;
            this.txtDUI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUI.Location = new System.Drawing.Point(289, 59);
            this.txtDUI.MaxLength = 9;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(152, 16);
            this.txtDUI.TabIndex = 40;
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(251, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "DUI";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoCliente.Enabled = false;
            this.txtApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(382, 28);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(194, 16);
            this.txtApellidoCliente.TabIndex = 38;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoCliente_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(300, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Apellidos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(90, 59);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 16);
            this.txtTelefono.TabIndex = 36;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(15, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(101, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(503, 16);
            this.txtDireccion.TabIndex = 34;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Direccion";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(89, 26);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(187, 16);
            this.txtNombreCliente.TabIndex = 32;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(279, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.dtpFecha);
            this.panel4.Location = new System.Drawing.Point(264, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 55);
            this.panel4.TabIndex = 38;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(10, 20);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(188, 21);
            this.dtpFecha.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(57, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Producto";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.btnFacturar);
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Controls.Add(this.btnBuscarProdcuto);
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtPrecio);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtCantidad);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtCodigoProducto);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.dgvDetalleVenta);
            this.panel5.Controls.Add(this.txtNombreProducto);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(12, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(692, 577);
            this.panel5.TabIndex = 40;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::VENTAS.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(17, 517);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(41, 42);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(492, 64);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(57, 16);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.Visible = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Image = global::VENTAS.Properties.Resources.facturar;
            this.btnFacturar.Location = new System.Drawing.Point(72, 517);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(41, 42);
            this.btnFacturar.TabIndex = 53;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::VENTAS.Properties.Resources.agregar2;
            this.btnAgregar.Location = new System.Drawing.Point(555, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(41, 42);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscarProdcuto
            // 
            this.btnBuscarProdcuto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProdcuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProdcuto.Image = global::VENTAS.Properties.Resources.buscar;
            this.btnBuscarProdcuto.Location = new System.Drawing.Point(602, 11);
            this.btnBuscarProdcuto.Name = "btnBuscarProdcuto";
            this.btnBuscarProdcuto.Size = new System.Drawing.Size(41, 42);
            this.btnBuscarProdcuto.TabIndex = 43;
            this.btnBuscarProdcuto.UseVisualStyleBackColor = true;
            this.btnBuscarProdcuto.Click += new System.EventHandler(this.btnBuscarProdcuto_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(517, 513);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 32);
            this.lblTotal.TabIndex = 49;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(434, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 21);
            this.label15.TabIndex = 48;
            this.label15.Text = "TOTAL: $\r\n";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(102, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 16);
            this.txtPrecio.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(28, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 18);
            this.label14.TabIndex = 46;
            this.label14.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(333, 63);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 16);
            this.txtCantidad.TabIndex = 45;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(251, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Cantidad";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(102, 24);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(123, 16);
            this.txtCodigoProducto.TabIndex = 43;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            this.txtCodigoProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(20, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 42;
            this.label12.Text = "Codigo";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(352, 24);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(216, 16);
            this.txtNombreProducto.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(245, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 18);
            this.label16.TabIndex = 31;
            this.label16.Text = "Descripcion";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::VENTAS.Properties.Resources.cerrar;
            this.pbCerrar.Location = new System.Drawing.Point(691, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(23, 22);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 52;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // lblNombreCajero
            // 
            this.lblNombreCajero.AutoSize = true;
            this.lblNombreCajero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCajero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreCajero.Location = new System.Drawing.Point(144, 870);
            this.lblNombreCajero.Name = "lblNombreCajero";
            this.lblNombreCajero.Size = new System.Drawing.Size(61, 19);
            this.lblNombreCajero.TabIndex = 53;
            this.lblNombreCajero.Text = "Cajero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(12, 870);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Atendido por:";
            // 
            // pdImprimir
            // 
            this.pdImprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(716, 898);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNombreCajero);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.TextBox txtNombreProducto;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtCodigoProducto;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProdcuto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFacturar;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbTickect;
        private System.Windows.Forms.CheckBox cbFactura;
        public System.Windows.Forms.TextBox txtDUI;
        public System.Windows.Forms.TextBox txtApellidoCliente;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevoiCliente;
        public System.Windows.Forms.Label lblNombreCajero;
        public System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument pdImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tol;
    }
}