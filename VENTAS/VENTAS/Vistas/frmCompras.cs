using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VENTAS.Model;

namespace VENTAS.Vistas
{
    public partial class frmCompras : Form
    {

        private decimal SubTotal = 0;
        private decimal Total = 0;
        public frmCompras()
        {
            InitializeComponent();
            bloquear();
        }

        void restaurarformulario()
        {
            limpiarproducto();
            LimpiarProveedor();
            txtNombreProveedor.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            btnBuscarProveedor.Enabled = true;
            btnBuscarProdcuto.Enabled = true;
            lkblCambiarCosto.Visible = true;
            lblCategoria.Visible = false;
            cmbCategoria.Visible = false;
            cmbCategoria.Enabled = false;
            lkblCategoriaNueva.Visible = false;
            txtCategoriaNueva.Visible = false;
            txtCategoriaNueva.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecio.Enabled = false;
            txtCodigoProducto.Enabled = true;
            txtPrecio.Enabled = false;
            txtCodigoProducto.Focus();
        }

        void calculartotalfinal()
        {
            double suma = 0;
            for (int i = 0; i < dgvDetalleCompra.RowCount; i++)
            {
                string datosAOperar = dgvDetalleCompra.Rows[i].Cells[4].Value.ToString();
                double datosConvertidos = Convert.ToDouble(datosAOperar);

                suma += datosConvertidos;

                lblTotal.Text = suma.ToString();

            }
        }

        void bloquear()
        {
            txtCategoriaNueva.Enabled = false;
            txtCategoriaNueva.Visible = false;
            cmbCategoria.Enabled = false;
            cmbCategoria.Visible = false;
            lkblCategoriaNueva.Visible = false;
            lblCategoria.Visible = false;
            txtNombreProveedor.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
        }

       void FinalizacionVenta()
        {
            limpiarproducto();
            LimpiarProveedor();
            RetornarId();
            dgvDetalleCompra.Rows.Clear();
            lblTotal.Text = "";
            MessageBox.Show("Compra Guardada con exito");
        }
        public void listaCategorias()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var categorias = bd.Categorias.ToList();

                if (categorias.Count() > 0)
                {
                    cmbCategoria.DataSource = categorias;
                    cmbCategoria.DisplayMember = "nombre_categoria";
                    cmbCategoria.ValueMember = "id_categoria";

                    if (cmbCategoria.Items.Count > 0)
                        cmbCategoria.SelectedIndex = -1;

                }


            }
        }

        void RetornarId()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                var lista = bd.Compras;

                foreach (var iteracion in lista)
                {
                    string id = iteracion.id_compra.ToString();
                    int idConvertir = Convert.ToInt32(id);
                    int suma = idConvertir + 1;

                    lblIdVenta.Text = suma.ToString();
                }

            }
        }

        void calculo()
        {

            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);
                decimal subtotal = (cantidad * precio);

                txtTotal.Text = Convert.ToString(subtotal);

            }
            catch (Exception ex)
            {

            }
        }

        void LimpiarProveedor()
        {
            txtDireccion.Text = "";
            txtNombreProveedor.Text = "";
            txtTelefono.Text = "";
        }
        void limpiarproducto()
        {
            txtCantidad.Text = "";
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtTotal.Text = "";
            txtPrecio.Text = "";
            txtCategoriaNueva.Text = "";
            cmbCategoria.Text = "";

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor bp = new frmBuscarProveedor();
            bp.Show();
        }

        private void btnBuscarProdcuto_Click(object sender, EventArgs e)
        {
            frmProductoCompra bp = new frmProductoCompra();
            bp.Show();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            RetornarId();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Producto pro = new Producto();

                if (txtPrecio.Enabled == true && txtNombreProducto.Enabled == true)
                {
                    if (txtCategoriaNueva.Visible == false && cmbCategoria.Visible == true && txtNombreProveedor.Enabled == false)
                    {
                        //PRODUCTO NUEVO CATEGORIA EXISTENTE Y PROVEEDOR EXISTENTE
                        if (txtCantidad.Text != ""  && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != ""&&
                        txtPrecio.Text != "" && cmbCategoria.Text != "" && txtDireccion.Text != "")
                        {

                            var busqueda = from produc in bd.Productos
                                           where produc.nombre_producto == txtNombreProducto.Text
                                           select produc;

                            if (busqueda.Count() > 0)
                            {
                                limpiarproducto();
                                MessageBox.Show("Este producto ya existe");
                            }
                            else if(busqueda.Count() == 0)
                            {
                                string valor = "0";
                                string categoria = cmbCategoria.SelectedValue.ToString();

                                calculo();
                                dgvDetalleCompra.Rows.Add("", txtNombreProducto.Text, txtPrecio.Text,
                               txtCantidad.Text, txtTotal.Text, categoria, valor, txtNombreProveedor.Text);
                                calculartotalfinal();
                                LimpiarProveedor();
                                restaurarformulario();
                                bloquear();

                                dgvDetalleCompra.Refresh();
                                dgvDetalleCompra.ClearSelection();
                                int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                                dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                                dgvDetalleCompra.Rows[ultimafila].Selected = true;
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("No se aceptan datos vacios");
                        }
                        limpiarproducto();
                    }
                    else if (txtCategoriaNueva.Visible == true && cmbCategoria.Visible == false && txtNombreProveedor.Enabled == false)
                    {
                        //PRODUCTO NUEVO CATEGORIA TAMBIEN Y PROVEEDOR EXISTENTE
                        if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != "" && txtCategoriaNueva.Text != "" && txtDireccion.Text != "")
                        {
                            var busqueda = from produc in bd.Productos
                                           where produc.nombre_producto == txtNombreProducto.Text
                                           select produc;

                            var busqueda2 = from cate in bd.Categorias                                          
                                           where cate.nombre_categoria == txtCategoriaNueva.Text
                                           select cate;
                            

                            if (busqueda.Count() > 0 || busqueda2.Count() > 0)
                            {
                                limpiarproducto();
                                MessageBox.Show("Producto o Categoria ya existe");
                            }
                            else if(busqueda.Count() == 0 && busqueda2.Count() == 0)
                            {
                                string valor = "1";
                                string categoria = txtCategoriaNueva.Text;

                                calculo();
                                dgvDetalleCompra.Rows.Add("", txtNombreProducto.Text, txtPrecio.Text,
                               txtCantidad.Text, txtTotal.Text, categoria, valor, txtNombreProveedor.Text);
                                calculartotalfinal();
                                LimpiarProveedor();
                                restaurarformulario();
                                bloquear();

                                dgvDetalleCompra.Refresh();
                                dgvDetalleCompra.ClearSelection();
                                int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                                dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                                dgvDetalleCompra.Rows[ultimafila].Selected = true;
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("No se aceptan datos vacios");
                        }
                        limpiarproducto();
                    }
                    else if (txtCategoriaNueva.Visible == true && cmbCategoria.Visible == false && txtNombreProveedor.Enabled == true)
                    {
                        //PRODUCTO NUEVO CATEGORIA TAMBIEN Y PROVEEDOR NUEVO
                        if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != "" && txtCategoriaNueva.Text != "" && txtDireccion.Text != "")
                        {
                            var busqueda = from produc in bd.Productos
                                           where produc.nombre_producto == txtNombreProducto.Text
                                           select produc;

                            var busqueda2 = from cate in bd.Categorias
                                            where cate.nombre_categoria == txtCategoriaNueva.Text
                                            select cate;

                            var busqueda3 = from prove in bd.Proveedores
                                            where prove.nombre_proveedor == txtNombreProveedor.Text
                                            select prove;


                            if (busqueda.Count() > 0 || busqueda2.Count() > 0 || busqueda3.Count() > 0)
                            {
                                limpiarproducto();
                                MessageBox.Show("Producto, Proveedor o Categoria ya existe");
                            }
                            else if (busqueda.Count() == 0 && busqueda2.Count() == 0 && busqueda3.Count() == 0)
                            {
                                string valor = "4";
                                string categoria = txtCategoriaNueva.Text;

                                calculo();
                                dgvDetalleCompra.Rows.Add("", txtNombreProducto.Text, txtPrecio.Text,
                               txtCantidad.Text, txtTotal.Text, categoria, valor, txtNombreProveedor.Text, txtTelefono.Text, txtDireccion.Text);
                                calculartotalfinal();
                                LimpiarProveedor();
                                restaurarformulario();
                                bloquear();

                                dgvDetalleCompra.Refresh();
                                dgvDetalleCompra.ClearSelection();
                                int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                                dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                                dgvDetalleCompra.Rows[ultimafila].Selected = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se aceptan datos vacios");
                        }
                        limpiarproducto();

                    }
                    else if (txtCategoriaNueva.Visible == false && cmbCategoria.Visible == true && txtNombreProveedor.Enabled == true)
                    {
                        //PRODUCTO NUEVO CATEGORIA EXISTENTE Y PROVEEDOR NUEVO
                        if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != "" && cmbCategoria.Text != "" && txtDireccion.Text != "")
                        {
                            var busqueda = from produc in bd.Productos
                                           where produc.nombre_producto == txtNombreProducto.Text
                                           select produc;                           

                            var busqueda3 = from prove in bd.Proveedores
                                            where prove.nombre_proveedor == txtNombreProveedor.Text
                                            select prove;


                            if (busqueda.Count() > 0 || busqueda3.Count() > 0)
                            {
                                limpiarproducto();
                                MessageBox.Show("Producto o Proveedor ya existe");
                            }
                            else if (busqueda.Count() == 0 && busqueda3.Count() == 0)
                            {

                                string valor = "5";
                                string categoria = cmbCategoria.SelectedValue.ToString();

                                calculo();
                                dgvDetalleCompra.Rows.Add("", txtNombreProducto.Text, txtPrecio.Text,
                               txtCantidad.Text, txtTotal.Text, categoria, valor, txtNombreProveedor.Text, txtTelefono.Text, txtDireccion.Text);
                                calculartotalfinal();
                                LimpiarProveedor();
                                restaurarformulario();
                                bloquear();

                                dgvDetalleCompra.Refresh();
                                dgvDetalleCompra.ClearSelection();
                                int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                                dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                                dgvDetalleCompra.Rows[ultimafila].Selected = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se aceptan datos vacios");
                        }
                        limpiarproducto();
                    }
                }
                else if (txtPrecio.Enabled == true && txtNombreProducto.Enabled == false && txtNombreProveedor.Enabled == false && txtTelefono.Enabled == false)
                {
                    //PRODUCTO EXISTENTE PERO SE CAMBIA PRECIO DE ENTRADA
                    if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != ""  && txtDireccion.Text != "")
                    {
                        Producto prod = new Producto();
                        Proveedore prov = new Proveedore();

                        string proveedor = txtNombreProveedor.Text;
                        int idProducto = Convert.ToInt32(txtCodigoProducto.Text);

                        prov = bd.Proveedores.Where(Nombre => Nombre.nombre_proveedor == proveedor).First();
                        int idproveedor = prov.id_proveedor;

                        prod = bd.Productos.Where(IdBuscar => IdBuscar.id_producto == idProducto).First();
                        int idproveedor2 = prod.id_proveedor;

                        if (idproveedor == idproveedor2)
                        {
                            string valor = "2";
                            calculo();
                            dgvDetalleCompra.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                        txtCantidad.Text, txtTotal.Text, "", valor, txtNombreProveedor.Text);
                            calculartotalfinal();
                            LimpiarProveedor();

                            dgvDetalleCompra.Refresh();
                            dgvDetalleCompra.ClearSelection();
                            int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                            dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                            dgvDetalleCompra.Rows[ultimafila].Selected = true;
                        }
                        else if(idproveedor != idproveedor2)
                        {
                            DialogResult result = MessageBox.Show("El proveedor seleccionado no es el asigando para este producto\n" +
                            "¿Desea continuar y actualizarlo como el nuevo proveedor?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (result == DialogResult.OK)
                            {
                                prod.id_proveedor = idproveedor;
                                bd.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                                bd.SaveChanges();

                                string valor = "2";
                                calculo();
                                dgvDetalleCompra.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                            txtCantidad.Text, txtTotal.Text, "", valor, txtNombreProveedor.Text);
                                calculartotalfinal();
                                LimpiarProveedor();

                                dgvDetalleCompra.Refresh();
                                dgvDetalleCompra.ClearSelection();
                                int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                                dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                                dgvDetalleCompra.Rows[ultimafila].Selected = true;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                LimpiarProveedor();
                            }
                        }                       

                    }
                    else
                    {
                        MessageBox.Show("Datos vacios");
                    }
                    limpiarproducto();

                }
                else if (txtPrecio.Enabled == false && txtNombreProducto.Enabled == false && txtNombreProveedor.Enabled == false && txtTelefono.Enabled == false)
                {
                    //TODO EXISTE YA EN LA BASE DE DATOS
                    if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != "" && txtDireccion.Text != "")
                    {
                        Producto prod = new Producto();
                        Proveedore prov = new Proveedore();

                        string proveedor = txtNombreProveedor.Text;
                        int idProducto = Convert.ToInt32(txtCodigoProducto.Text);

                        prov = bd.Proveedores.Where(Nombre => Nombre.nombre_proveedor == proveedor).First();
                        int idproveedor = prov.id_proveedor;

                        prod = bd.Productos.Where(IdBuscar => IdBuscar.id_producto == idProducto).First();
                        int idproveedor2 = prod.id_proveedor;


                        if (idproveedor == idproveedor2)
                        {
                            string valor = "3";

                            calculo();
                            dgvDetalleCompra.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                        txtCantidad.Text, txtTotal.Text, "", valor, txtNombreProveedor.Text);
                            calculartotalfinal();
                            LimpiarProveedor();

                            dgvDetalleCompra.Refresh();
                            dgvDetalleCompra.ClearSelection();
                            int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                            dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                            dgvDetalleCompra.Rows[ultimafila].Selected = true;
                        }
                        else if (idproveedor != idproveedor2)
                        {
                            DialogResult result = MessageBox.Show("El proveedor seleccionado no es el asigando para este producto\n" +
                            "¿Desea continuar y actualizarlo como el nuevo proveedor?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (result == DialogResult.OK)
                            {

                                prod.id_proveedor = idproveedor;
                                bd.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                                bd.SaveChanges();

                                string valor = "3";
                                calculo();
                                dgvDetalleCompra.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                            txtCantidad.Text, txtTotal.Text, "", valor, txtNombreProveedor.Text);
                                calculartotalfinal();
                                LimpiarProveedor();

                                dgvDetalleCompra.Refresh();
                                dgvDetalleCompra.ClearSelection();
                                int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                                dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                                dgvDetalleCompra.Rows[ultimafila].Selected = true;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                LimpiarProveedor();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Datos vacios");
                        }
                    }
                    limpiarproducto();
                }
                else if (txtPrecio.Enabled == false && txtNombreProducto.Enabled == false && txtNombreProveedor.Enabled == true && txtTelefono.Enabled == true)
                {
                    //REGISTRO DE PRODUCTO EXISTE PERO ES NUEVO PROVEEDOR 
                    if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != "" && txtDireccion.Text != "")
                    {
                        var busqueda3 = from prove in bd.Proveedores
                                        where prove.nombre_proveedor == txtNombreProveedor.Text
                                        select prove;


                        if (busqueda3.Count() > 0)
                        {
                            LimpiarProveedor();
                            MessageBox.Show("Proveedor ya existe");
                        }
                        else if (busqueda3.Count() == 0)
                        {

                            string valor = "6";

                            calculo();
                            dgvDetalleCompra.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                        txtCantidad.Text, txtTotal.Text, "", valor, txtNombreProveedor.Text, txtTelefono.Text, txtDireccion.Text);
                            calculartotalfinal();
                            LimpiarProveedor();
                            restaurarformulario();

                            dgvDetalleCompra.Refresh();
                            dgvDetalleCompra.ClearSelection();
                            int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                            dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                            dgvDetalleCompra.Rows[ultimafila].Selected = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Datos vacios");
                    }
                    limpiarproducto();
                }
                else if (txtPrecio.Enabled == true && txtNombreProducto.Enabled == false && txtNombreProveedor.Enabled == true && txtTelefono.Enabled == true)
                {
                    //REGISTRO DE PRODUCTO EXISTE PERO ES NUEVO PROVEEDOR Y CAMBIA EL COSTO 
                    if (txtCantidad.Text != "" && txtNombreProducto.Text != "" && txtNombreProveedor.Text != "" && txtTelefono.Text != "" &&
                        txtPrecio.Text != "" && txtDireccion.Text != "")
                    {
                        var busqueda3 = from prove in bd.Proveedores
                                        where prove.nombre_proveedor == txtNombreProveedor.Text
                                        select prove;


                        if (busqueda3.Count() > 0)
                        {
                            LimpiarProveedor();
                            MessageBox.Show("Proveedor ya existe");
                        }
                        else if (busqueda3.Count() == 0)
                        {

                            string valor = "7";

                            calculo();
                            dgvDetalleCompra.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                        txtCantidad.Text, txtTotal.Text, "", valor, txtNombreProveedor.Text, txtTelefono.Text, txtDireccion.Text);
                            calculartotalfinal();
                            LimpiarProveedor();
                            restaurarformulario();

                            dgvDetalleCompra.Refresh();
                            dgvDetalleCompra.ClearSelection();
                            int ultimafila = dgvDetalleCompra.Rows.Count - 1;
                            dgvDetalleCompra.FirstDisplayedScrollingRowIndex = ultimafila;
                            dgvDetalleCompra.Rows[ultimafila].Selected = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Datos vacios");
                    }
                    limpiarproducto();
                }

            }
                        
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            
            limpiarproducto();
            LimpiarProveedor();
            restaurarformulario();
            dgvDetalleCompra.Rows.Clear();
            dtpFecha.Text = "";
            lblTotal.Text = "";
            this.Hide();
            Log_in.m.Show();          
            
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (txtCodigoProducto.Enabled == true && txtNombreProducto.Enabled == false)
            {
                limpiarproducto();
                listaCategorias();
                btnBuscarProdcuto.Enabled = false;
                lkblCambiarCosto.Visible = false;
                lblCategoria.Visible = true;
                cmbCategoria.Visible = true;
                cmbCategoria.Enabled = true;
                lkblCategoriaNueva.Visible = true;
                txtNombreProducto.Enabled = true;
                txtPrecio.Enabled = true;
                txtCodigoProducto.Enabled = false;
                txtNombreProducto.Focus();
                
            }
            else if (txtCodigoProducto.Enabled == false && txtNombreProducto.Enabled == true)
            {
                limpiarproducto();
                listaCategorias();
                btnBuscarProdcuto.Enabled = true;
                lkblCambiarCosto.Visible = true;
                lblCategoria.Visible = false;
                cmbCategoria.Visible = false;
                cmbCategoria.Enabled = false;
                lkblCategoriaNueva.Visible = false;
                txtNombreProducto.Enabled = false;
                txtPrecio.Enabled = false;
                txtCodigoProducto.Enabled = true;
                txtCodigoProducto.Focus();
            }



        }

        private void lkblCambiarCosto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtPrecio.Text != "")
            {
                txtPrecio.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay un precio al cual aplicar cambios");
            }

        }

        private void lkblCategoriaNueva_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbCategoria.Visible == true && txtCategoriaNueva.Visible == false)
            {
                listaCategorias();
                cmbCategoria.Visible = false;
                cmbCategoria.Enabled = false;
                txtCategoriaNueva.Visible = true;
                txtCategoriaNueva.Enabled = true;
            }
            else if (cmbCategoria.Visible == false && txtCategoriaNueva.Visible == true)
            {
                listaCategorias();
                cmbCategoria.Visible = true;
                cmbCategoria.Enabled = true;
                txtCategoriaNueva.Visible = false;
                txtCategoriaNueva.Enabled = false;
            }

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Compra com = new Compra();
                Proveedore prove = new Proveedore();
                Empleado em = new Empleado();

                if (dtpFecha.Text != "" )
                {
                    em = bd.Empleados.Where(idBuscar => idBuscar.nombre_empleado == lblNombreCajero.Text).First();
                    int idEmpleado = em.id_empleado;

                    com.id_empleado = idEmpleado;                 
                    com.total_compra = Convert.ToDecimal(lblTotal.Text);
                    com.fecha = Convert.ToDateTime(dtpFecha.Text);
                    bd.Compras.Add(com);
                    bd.SaveChanges();

                    Detalle_Compra dete = new Detalle_Compra();

                    for (int i = 0; i < dgvDetalleCompra.RowCount; i++)
                    {
                        //OBTENIENDO ALGUNOS DATOS                        

                        string descripcion = dgvDetalleCompra.Rows[i].Cells[1].Value.ToString();
                        
                        string costo = dgvDetalleCompra.Rows[i].Cells[2].Value.ToString();
                        double costouni = Convert.ToDouble(costo);

                        string cantidad = dgvDetalleCompra.Rows[i].Cells[3].Value.ToString();
                        int cantidadConvertida = Convert.ToInt32(cantidad);

                        string Total = dgvDetalleCompra.Rows[i].Cells[4].Value.ToString();
                        decimal TotalConvertido = Convert.ToDecimal(Total);

                        string categoria = dgvDetalleCompra.Rows[i].Cells[5].Value.ToString();                        

                        string categoriapalabra = dgvDetalleCompra.Rows[i].Cells[5].Value.ToString();

                        string valor = dgvDetalleCompra.Rows[i].Cells[6].Value.ToString();
                        int valorConvertido = Convert.ToInt32(valor);                        
                        
                        string proveedorpalabra = dgvDetalleCompra.Rows[i].Cells[7].Value.ToString();                        
                        

                        //COMPARACIONES

                        if (valorConvertido == 0)
                        {
                            //PRODUCTO NUEVO, CATEGORIA EXISTENTE, PROVEEDOR EXISTENTE
                            Producto pro = new Producto();
                            Categoria cat = new Categoria();
                            Proveedore prov = new Proveedore();

                            double precioventa = (costouni + (costouni * 0.20));                            

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int proveedornumero = prov.id_proveedor;
                            
                            int categorianumero = Convert.ToInt32(categoriapalabra);

                            pro.nombre_producto = descripcion;
                            pro.costo =  Convert.ToDecimal(costouni);
                            pro.precio_venta = Convert.ToDecimal(precioventa);
                            pro.cantidad = cantidadConvertida;
                            pro.id_categoria = categorianumero;
                            pro.id_proveedor = proveedornumero;
                            bd.Productos.Add(pro);
                            bd.SaveChanges();

                            pro = bd.Productos.Where(Buscar => Buscar.nombre_producto == descripcion).First();
                            int idproducto = pro.id_producto;

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idproducto;
                            dete.id_proveedor = proveedornumero;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();


                        }
                        else if (valorConvertido == 1 )
                        {
                            //PRODUCTO NUEVO, CATEGORIA NUEVO, PROVEEDOR EXISTENTE
                            Producto pro = new Producto();
                            Categoria cat = new Categoria();
                            Proveedore prov = new Proveedore();

                            double precioventa = (costouni + (costouni * 0.20));
                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int proveedornumero = prov.id_proveedor;
                            

                            cat.nombre_categoria = categoriapalabra;
                            bd.Categorias.Add(cat);
                            bd.SaveChanges();

                            cat = bd.Categorias.Where(Buscar => Buscar.nombre_categoria == categoriapalabra).First();
                            int id = cat.id_categoria;

                            pro.nombre_producto = descripcion;
                            pro.costo = Convert.ToDecimal(costouni);
                            pro.precio_venta = Convert.ToDecimal(precioventa);
                            pro.cantidad = cantidadConvertida;
                            pro.id_categoria = id;
                            pro.id_proveedor = proveedornumero;
                            bd.Productos.Add(pro);
                            bd.SaveChanges();

                            pro = bd.Productos.Where(Buscar => Buscar.nombre_producto == descripcion).First();
                            int idproducto = pro.id_producto;

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idproducto;
                            dete.id_proveedor = proveedornumero;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();
                        }
                        else if (valorConvertido == 2)
                        {
                            //EL PRODUCTO ES EXISTENTE PERO SE CAMBIO SU PRECIO DE ENTRADA
                            Producto pro = new Producto();
                            Proveedore prov = new Proveedore();

                            string idProducto = dgvDetalleCompra.Rows[i].Cells[0].Value.ToString();
                            int idConvertido = Convert.ToInt32(idProducto);

                            double precioventa = (costouni + (costouni * 0.20));

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int proveedornumero = prov.id_proveedor;                            

                            pro = bd.Productos.Where(IdBuscar => IdBuscar.id_producto == idConvertido).First();
                            int existencias = Convert.ToInt32(pro.cantidad);

                            int SUMAR = existencias + cantidadConvertida;

                            pro.cantidad = SUMAR;
                            pro.precio_venta = Convert.ToDecimal(precioventa);
                            pro.costo = Convert.ToDecimal(costouni);
                            bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idConvertido;
                            dete.id_proveedor = proveedornumero;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();
                        }
                        else if (valorConvertido == 3)
                        {
                            //TODOS LOS DATOS DEL PRODUCTO SON EXISTENTES
                            Producto pro = new Producto();
                            Proveedore prov = new Proveedore();

                            string idProducto = dgvDetalleCompra.Rows[i].Cells[0].Value.ToString();
                            int idConvertido = Convert.ToInt32(idProducto);

                            pro = bd.Productos.Where(IdBuscar => IdBuscar.id_producto == idConvertido).First();
                            int existencias = Convert.ToInt32(pro.cantidad);

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int proveedornumero = prov.id_proveedor;

                            int SUMAR = existencias + cantidadConvertida;

                            pro.cantidad = SUMAR;                            
                            bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text); 
                            dete.id_producto = idConvertido;
                            dete.id_proveedor = proveedornumero;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();

                        }
                        else if (valorConvertido == 4)
                        {
                            //PRODUCTO NUEVO, CATEGORIA NUEVO, PROVEEDOR NUEVO
                            Producto pro = new Producto();
                            Categoria cat = new Categoria();
                            Proveedore prov = new Proveedore(); 

                            double precioventa = (costouni + (costouni * 0.20));
                            string telefono = dgvDetalleCompra.Rows[i].Cells[8].Value.ToString();
                            string direccion = dgvDetalleCompra.Rows[i].Cells[9].Value.ToString();

                            cat.nombre_categoria = categoriapalabra;
                            bd.Categorias.Add(cat);
                            bd.SaveChanges();

                            prov.nombre_proveedor = proveedorpalabra;
                            prov.telefono = telefono;
                            prov.direccion = direccion;
                            bd.Proveedores.Add(prov);
                            bd.SaveChanges();

                            cat = bd.Categorias.Where(Buscar => Buscar.nombre_categoria == categoriapalabra).First();
                            int id = cat.id_categoria;

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int idproveedor = prov.id_proveedor;

                            pro.nombre_producto = descripcion;
                            pro.costo = Convert.ToDecimal(costouni);
                            pro.precio_venta = Convert.ToDecimal(precioventa);
                            pro.cantidad = cantidadConvertida;
                            pro.id_categoria = id;
                            pro.id_proveedor = idproveedor;
                            bd.Productos.Add(pro);
                            bd.SaveChanges();

                            pro = bd.Productos.Where(Buscar => Buscar.nombre_producto == descripcion).First();
                            int idproducto = pro.id_producto;                                                      

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idproducto;
                            dete.id_proveedor = idproveedor;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();

                        }
                        else if (valorConvertido == 5)
                        {
                            //PRODUCTO NUEVO, CATEGORIA EXISTENTE, PROVEEDOR NUEVO
                            Producto pro = new Producto();                           
                            Proveedore prov = new Proveedore();

                            double precioventa = (costouni + (costouni * 0.20));
                            int categorianumero = Convert.ToInt32(categoria);
                            string telefono = dgvDetalleCompra.Rows[i].Cells[8].Value.ToString();
                            string direccion = dgvDetalleCompra.Rows[i].Cells[9].Value.ToString();

                            prov.nombre_proveedor = proveedorpalabra;
                            prov.telefono = telefono;
                            prov.direccion = direccion;
                            bd.Proveedores.Add(prov);
                            bd.SaveChanges();                            

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int idproveedor = prov.id_proveedor;

                            pro.nombre_producto = descripcion;
                            pro.costo = Convert.ToDecimal(costouni);
                            pro.precio_venta = Convert.ToDecimal(precioventa);
                            pro.cantidad = cantidadConvertida;
                            pro.id_categoria = categorianumero;
                            pro.id_proveedor = idproveedor;
                            bd.Productos.Add(pro);
                            bd.SaveChanges();

                            pro = bd.Productos.Where(Buscar => Buscar.nombre_producto == descripcion).First();
                            int idproducto = pro.id_producto;

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idproducto;
                            dete.id_proveedor = idproveedor;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();

                        }
                        else if(valorConvertido == 6)
                        {
                            //TODOS LOS DATOS DEL PRODUCTO SON EXISTENTES PERO SU PROVEEDOR ES NUEVO
                            Producto pro = new Producto();
                            Proveedore prov = new Proveedore();

                            string idProducto = dgvDetalleCompra.Rows[i].Cells[0].Value.ToString();
                            int idConvertido = Convert.ToInt32(idProducto);

                            pro = bd.Productos.Where(IdBuscar => IdBuscar.id_producto == idConvertido).First();
                            int existencias = Convert.ToInt32(pro.cantidad);

                            int SUMAR = existencias + cantidadConvertida;
                            string telefono = dgvDetalleCompra.Rows[i].Cells[8].Value.ToString();
                            string direccion = dgvDetalleCompra.Rows[i].Cells[9].Value.ToString();

                            prov.nombre_proveedor = proveedorpalabra;
                            prov.telefono = telefono;
                            prov.direccion = direccion;
                            bd.Proveedores.Add(prov);
                            bd.SaveChanges();

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int idproveedor = prov.id_proveedor;

                            pro.cantidad = SUMAR;
                            pro.id_proveedor = idproveedor;
                            bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idConvertido;
                            dete.id_proveedor = idproveedor;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();
                        }
                        else if (valorConvertido == 7)
                        {
                            //TODOS LOS DATOS DEL PRODUCTO SON EXISTENTES PERO SU PROVEEDOR ES NUEVO Y COSTO CAMBIA
                            Producto pro = new Producto();
                            Proveedore prov = new Proveedore();

                            string idProducto = dgvDetalleCompra.Rows[i].Cells[0].Value.ToString();
                            int idConvertido = Convert.ToInt32(idProducto);

                            double precioventa = (costouni + (costouni * 0.20));

                            pro = bd.Productos.Where(IdBuscar => IdBuscar.id_producto == idConvertido).First();
                            int existencias = Convert.ToInt32(pro.cantidad);

                            int SUMAR = existencias + cantidadConvertida;
                            string telefono = dgvDetalleCompra.Rows[i].Cells[8].Value.ToString();
                            string direccion = dgvDetalleCompra.Rows[i].Cells[9].Value.ToString();

                            prov.nombre_proveedor = proveedorpalabra;
                            prov.telefono = telefono;
                            prov.direccion = direccion;
                            bd.Proveedores.Add(prov);
                            bd.SaveChanges();

                            prov = bd.Proveedores.Where(Buscar => Buscar.nombre_proveedor == proveedorpalabra).First();
                            int idproveedor = prov.id_proveedor;
                            
                            pro.cantidad = SUMAR;
                            pro.precio_venta = Convert.ToDecimal(precioventa);
                            pro.costo = Convert.ToDecimal(costouni);
                            pro.id_proveedor = idproveedor;
                            bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();

                            dete.id_compra = Convert.ToInt32(lblIdVenta.Text);
                            dete.id_producto = idConvertido;
                            dete.id_proveedor = idproveedor;
                            dete.cantidad = cantidadConvertida;
                            dete.precio = Convert.ToDecimal(costouni);
                            bd.Detalle_Compra.Add(dete);
                            bd.SaveChanges();

                            FinalizacionVenta();
                        }
                        else
                        {
                            MessageBox.Show("Error de Gardado");
                        }
                    }
                    }
                else
                {
                    MessageBox.Show("No se aceptan valores vacios");
                }
            }            
        }

        private void btnNuevoiCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Enabled == false && txtDireccion.Enabled == false && txtTelefono.Enabled == false)
            {
                LimpiarProveedor();
                txtNombreProveedor.Enabled = true;
                txtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
                btnBuscarProveedor.Enabled = false;
            }
            else if (txtNombreProveedor.Enabled == true && txtDireccion.Enabled == true && txtTelefono.Enabled == true)
            {
                LimpiarProveedor();
                txtNombreProveedor.Enabled = false;
                txtTelefono.Enabled = false;
                txtDireccion.Enabled = false;
                btnBuscarProveedor.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar la compra?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                limpiarproducto();
                LimpiarProveedor();
                dgvDetalleCompra.Rows.Clear();
                dtpFecha.Text = "";
                lblTotal.Text = "";
            }
        }

        private void dgvDetalleCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotalfinal();
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCodigoProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnBuscarProdcuto.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (VENTASEntities bd = new VENTASEntities())
                {

                    Producto pr = new Producto();
                    int buscar = int.Parse(txtCodigoProducto.Text);
                    pr = bd.Productos.Where(idBuscar => idBuscar.id_producto == buscar).First();                    
                    txtNombreProducto.Text = pr.nombre_producto;
                    txtPrecio.Text = Convert.ToString(pr.costo);
                    txtCantidad.Focus();                    
                    intentos = 2;
                }


            }
        }

        int intentos = 1;

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (intentos == 2)
                {
                    btnAgregar.PerformClick();
                    txtCodigoProducto.Text = "";                                     
                    txtNombreProducto.Text = "";
                    txtPrecio.Text = "";
                    txtTotal.Text = "";
                    intentos = 0;
                    txtCantidad.Text = "1";
                    txtCodigoProducto.Focus();

                }
                intentos += 1;
            }
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtCategoriaNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }
    }
}
