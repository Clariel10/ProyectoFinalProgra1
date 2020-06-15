namespace VENTAS.Vistas
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lkblCategoriaNueva = new System.Windows.Forms.LinkLabel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCategoriaNueva = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lkblCambiarCosto = new System.Windows.Forms.LinkLabel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoiCliente = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNombreCajero = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(57, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "Producto";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.lkblCategoriaNueva);
            this.panel5.Controls.Add(this.cmbCategoria);
            this.panel5.Controls.Add(this.txtCategoriaNueva);
            this.panel5.Controls.Add(this.lblCategoria);
            this.panel5.Controls.Add(this.lkblCambiarCosto);
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Controls.Add(this.btnCancelar);
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
            this.panel5.Controls.Add(this.dgvDetalleCompra);
            this.panel5.Controls.Add(this.txtNombreProducto);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(12, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(692, 577);
            this.panel5.TabIndex = 61;
            // 
            // lkblCategoriaNueva
            // 
            this.lkblCategoriaNueva.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.lkblCategoriaNueva.AutoSize = true;
            this.lkblCategoriaNueva.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkblCategoriaNueva.ForeColor = System.Drawing.Color.Black;
            this.lkblCategoriaNueva.LinkColor = System.Drawing.Color.DimGray;
            this.lkblCategoriaNueva.Location = new System.Drawing.Point(534, 83);
            this.lkblCategoriaNueva.Margin = new System.Windows.Forms.Padding(0);
            this.lkblCategoriaNueva.Name = "lkblCategoriaNueva";
            this.lkblCategoriaNueva.Size = new System.Drawing.Size(104, 16);
            this.lkblCategoriaNueva.TabIndex = 61;
            this.lkblCategoriaNueva.TabStop = true;
            this.lkblCategoriaNueva.Text = "Categoria Nueva";
            this.lkblCategoriaNueva.Visible = false;
            this.lkblCategoriaNueva.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkblCategoriaNueva_LinkClicked);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(519, 58);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(123, 25);
            this.cmbCategoria.TabIndex = 60;
            this.cmbCategoria.Visible = false;
            // 
            // txtCategoriaNueva
            // 
            this.txtCategoriaNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoriaNueva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaNueva.Location = new System.Drawing.Point(519, 63);
            this.txtCategoriaNueva.Name = "txtCategoriaNueva";
            this.txtCategoriaNueva.Size = new System.Drawing.Size(123, 16);
            this.txtCategoriaNueva.TabIndex = 59;
            this.txtCategoriaNueva.Visible = false;
            this.txtCategoriaNueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaNueva_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoria.Location = new System.Drawing.Point(433, 61);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(83, 18);
            this.lblCategoria.TabIndex = 58;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Visible = false;
            // 
            // lkblCambiarCosto
            // 
            this.lkblCambiarCosto.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.lkblCambiarCosto.AutoSize = true;
            this.lkblCambiarCosto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkblCambiarCosto.ForeColor = System.Drawing.Color.Black;
            this.lkblCambiarCosto.LinkColor = System.Drawing.Color.DimGray;
            this.lkblCambiarCosto.Location = new System.Drawing.Point(93, 78);
            this.lkblCambiarCosto.Name = "lkblCambiarCosto";
            this.lkblCambiarCosto.Size = new System.Drawing.Size(90, 16);
            this.lkblCambiarCosto.TabIndex = 57;
            this.lkblCambiarCosto.TabStop = true;
            this.lkblCambiarCosto.Text = "Cambiar Costo";
            this.lkblCambiarCosto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkblCambiarCosto_LinkClicked);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::VENTAS.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(623, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(41, 42);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(647, 52);
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
            this.btnBuscarProdcuto.Location = new System.Drawing.Point(574, 3);
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
            this.txtPrecio.Location = new System.Drawing.Point(78, 61);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 16);
            this.txtPrecio.TabIndex = 47;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(17, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 18);
            this.label14.TabIndex = 46;
            this.label14.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(298, 61);
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
            this.label13.Location = new System.Drawing.Point(216, 59);
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
            this.txtCodigoProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
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
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetalleCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.UNITARIO,
            this.CANTIDAD,
            this.tol,
            this.CATEGORIA,
            this.VALOR,
            this.PROVEEDOR,
            this.TELEFONO,
            this.DIRECCION});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(17, 104);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(656, 391);
            this.dgvDetalleCompra.TabIndex = 0;
            this.dgvDetalleCompra.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalleCompra_RowsRemoved);
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
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.Visible = false;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Visible = false;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            this.PROVEEDOR.Visible = false;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Visible = false;
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            this.DIRECCION.Visible = false;
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
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(197, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(57, 16);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Fecha";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.dtpFecha);
            this.panel4.Location = new System.Drawing.Point(29, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 55);
            this.panel4.TabIndex = 59;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Proveedor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnNuevoiCliente);
            this.panel3.Controls.Add(this.btnBuscarProveedor);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.txtDireccion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNombreProveedor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(26, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 116);
            this.panel3.TabIndex = 57;
            // 
            // btnNuevoiCliente
            // 
            this.btnNuevoiCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoiCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoiCliente.Image = global::VENTAS.Properties.Resources.nuevo;
            this.btnNuevoiCliente.Location = new System.Drawing.Point(610, 13);
            this.btnNuevoiCliente.Name = "btnNuevoiCliente";
            this.btnNuevoiCliente.Size = new System.Drawing.Size(41, 42);
            this.btnNuevoiCliente.TabIndex = 62;
            this.btnNuevoiCliente.UseVisualStyleBackColor = true;
            this.btnNuevoiCliente.Click += new System.EventHandler(this.btnNuevoiCliente_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::VENTAS.Properties.Resources.buscar;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(560, 13);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(41, 42);
            this.btnBuscarProveedor.TabIndex = 42;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(399, 41);
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
            this.label8.Location = new System.Drawing.Point(324, 39);
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
            this.txtDireccion.Location = new System.Drawing.Point(106, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(503, 16);
            this.txtDireccion.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Direccion";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(97, 39);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(187, 16);
            this.txtNombreProveedor.TabIndex = 32;
            this.txtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblIdVenta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTipoDocumento);
            this.panel1.Location = new System.Drawing.Point(485, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 63;
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
            this.lblTipoDocumento.Text = "FACTURA\r\n COMPRA";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::VENTAS.Properties.Resources.cerrar;
            this.pbCerrar.Location = new System.Drawing.Point(691, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(23, 22);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 62;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(15, 870);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Supervisado por:";
            // 
            // lblNombreCajero
            // 
            this.lblNombreCajero.AutoSize = true;
            this.lblNombreCajero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCajero.ForeColor = System.Drawing.Color.White;
            this.lblNombreCajero.Location = new System.Drawing.Point(163, 870);
            this.lblNombreCajero.Name = "lblNombreCajero";
            this.lblNombreCajero.Size = new System.Drawing.Size(61, 19);
            this.lblNombreCajero.TabIndex = 64;
            this.lblNombreCajero.Text = "Cajero";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(716, 898);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNombreCajero);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarProdcuto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        public System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.LinkLabel lkblCambiarCosto;
        private System.Windows.Forms.LinkLabel lkblCategoriaNueva;
        private System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.TextBox txtCategoriaNueva;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.Button btnNuevoiCliente;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblNombreCajero;
    }
}