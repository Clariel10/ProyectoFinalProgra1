using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VENTAS.Model;

namespace VENTAS.Vistas
{
    public partial class frmVentas : Form
    {
        public static Log_in log = new Log_in();

        private decimal SubTotal = 0;
        private decimal Total = 0;
        public frmVentas()
        {
            InitializeComponent();
            cbFactura.Checked = false;
            cbTickect.Checked = false;
            
           
        }

        void calculartotalfinal()
        {
            double suma = 0;
            for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
            {
                string datosAOperar = dgvDetalleVenta.Rows[i].Cells[4].Value.ToString();
                double datosConvertidos = Convert.ToDouble(datosAOperar);

                suma += datosConvertidos;

                lblTotal.Text = suma.ToString();

            }
        }

        void evaluar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Producto pro = new Producto();
                int a = 0;

                if (a == dgvDetalleVenta.RowCount)
                {

                }
                else if (a < dgvDetalleVenta.RowCount)
                {
                    for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
                    {
                        string id = dgvDetalleVenta.Rows[i].Cells[0].Value.ToString();
                        int idTabla = Convert.ToInt32(id);

                        string nombreprod = dgvDetalleVenta.Rows[i].Cells[1].Value.ToString();

                        int idDatos = Convert.ToInt32(txtCodigoProducto.Text);

                        if (idTabla == idDatos)
                        {

                            //DATOS CAJAS DE TEXTO
                            int cantidad = Convert.ToInt32(txtCantidad.Text);

                            double total = Convert.ToDouble(txtTotal.Text);

                            //DATOS DARAGRIDVIEW
                            string cantidadGrid = dgvDetalleVenta.Rows[i].Cells[3].Value.ToString();
                            int cantidadGridConver = Convert.ToInt32(cantidadGrid);

                            string precio = dgvDetalleVenta.Rows[i].Cells[2].Value.ToString();

                            string totalGrid = dgvDetalleVenta.Rows[i].Cells[4].Value.ToString();
                            double totalGridConvert = Convert.ToDouble(totalGrid);

                            //OPERACIONES
                            int suma = cantidad + cantidadGridConver;
                            string sumacantidad = Convert.ToString(suma);

                            double suma3 = total + totalGridConvert;
                            string suma2Total = Convert.ToString(suma3);

                            //BORRANDO LA FILA DE DATOS

                            //int ultimafila = dgvDetalleVenta.Rows.Count - 1;
                            dgvDetalleVenta.Rows.RemoveAt(i);

                            //ENVIANDO DATOS NUEVOS

                            //dgvDetalleVenta.Rows[i].Cells[3].Value = sumacantidad;

                            //dgvDetalleVenta.Rows[i].Cells[4].Value = suma2Total;

                            dgvDetalleVenta.Rows.Add(id, nombreprod, precio, sumacantidad, suma2Total);


                        }
                        
                    }
                }               
            }
        }

        void RetornarId()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                var lista = bd.Ventas;

                foreach (var iteracion in lista)
                {
                    string id = iteracion.id_venta.ToString();
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

        void LimpiarCliente()
        {
            txtApellidoCliente.Text = "";
            txtDireccion.Text = "";
            txtDUI.Text = "";
            txtNombreCliente.Text = "";
            txtTelefono.Text = "";
        }
        void limpiarproducto()
        {
            txtCantidad.Text = "";
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtTotal.Text = "";
            txtPrecio.Text = "";
            
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            RetornarId();
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmBuscarCliente bc = new frmBuscarCliente();
                bc.Show();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            frmBuscarCliente bc = new frmBuscarCliente();
            bc.Show();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                Venta tbV = new Venta();
                Empleado em = new Empleado();
                Cliente cli = new Cliente();

                if(txtNombreCliente.Text != "" && txtApellidoCliente.Text != "" && txtTelefono.Text != "" && txtDUI.Text != "" && txtDireccion.Text != "")
                    
                {
                    if (cbFactura.Checked == true && cbTickect.Checked == false)
                    {
                                                
                        em = bd.Empleados.Where(idBuscar => idBuscar.nombre_empleado == lblNombreCajero.Text).First();
                        int idEmpleado = em.id_empleado;

                        string buscarCliente = txtDUI.Text;
                        cli = bd.Clientes.Where(idBuscar => idBuscar.dui == buscarCliente).First();


                        tbV.id_documento = 1;
                        tbV.id_cliente = cli.id_cliente;
                        tbV.id_empleado = idEmpleado;
                        tbV.total_venta = Convert.ToDecimal(lblTotal.Text);
                        tbV.fecha = Convert.ToDateTime(dtpFecha.Text);
                        bd.Ventas.Add(tbV);
                        bd.SaveChanges();
                    }
                    else if (cbTickect.Checked == true && cbFactura.Checked == false)
                    {
                        em = bd.Empleados.Where(idBuscar => idBuscar.nombre_empleado == lblNombreCajero.Text).First();
                        int idEmpleado = em.id_empleado;

                        tbV.id_documento = 2;
                        tbV.id_cliente = 1;
                        tbV.id_empleado = idEmpleado;
                        tbV.total_venta = Convert.ToDecimal(lblTotal.Text);
                        tbV.fecha = Convert.ToDateTime(dtpFecha.Text);
                        bd.Ventas.Add(tbV);
                        bd.SaveChanges();
                    }


                    Detalle_Venta dete = new Detalle_Venta();


                    for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
                    {
                        string idProducto = dgvDetalleVenta.Rows[i].Cells[0].Value.ToString();
                        int idConvertido = Convert.ToInt32(idProducto);

                        string Cantidad = dgvDetalleVenta.Rows[i].Cells[3].Value.ToString();
                        int CantidadConvertido = Convert.ToInt32(Cantidad);
                                                
                        string Total = dgvDetalleVenta.Rows[i].Cells[4].Value.ToString();
                        decimal TotalConvertido = Convert.ToDecimal(Total);


                        dete.id_venta = Convert.ToInt32(lblIdVenta.Text);
                        dete.id_producto = idConvertido;
                        dete.cantidad = CantidadConvertido;
                        dete.precio = TotalConvertido;
                        bd.Detalle_Venta.Add(dete);
                        bd.SaveChanges();

                        
                    }

                    Producto pro = new Producto();

                    for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
                    {
                        //OBTENIENDO DATOS
                        
                        string idProducto = dgvDetalleVenta.Rows[i].Cells[0].Value.ToString();
                        int idConvertido = Convert.ToInt32(idProducto);

                        string Cantidad = dgvDetalleVenta.Rows[i].Cells[3].Value.ToString();
                        int CantidadConvertido = Convert.ToInt32(Cantidad);

                        pro = bd.Productos.Where(BuscarId => BuscarId.id_producto == idConvertido).First();
                        int existencias = Convert.ToInt32(pro.cantidad);

                        //ELIMINANDO EN INVENTARIO

                        int restar = existencias - CantidadConvertido;

                        pro.cantidad = restar;
                        bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                    }


                    
                    limpiarproducto();
                    LimpiarCliente();
                    dgvDetalleVenta.Rows.Clear();
                    RetornarId();
                    lblTotal.Text = "";
                    MessageBox.Show("Venta Guardada con exito");
                }
                else
                {
                    MessageBox.Show("No se han definido algunos valores");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Producto pro = new Producto();

                if (txtCantidad.Text != "" && txtCodigoProducto.Text != "" && txtNombreProducto.Text != "" && txtPrecio.Text != "")
                {

                    string id = txtCodigoProducto.Text;
                    int cantidadCompra = Convert.ToInt32(txtCantidad.Text);

                    int idConvertido = Convert.ToInt32(id);
                    pro = bd.Productos.Where(idBuscar => idBuscar.id_producto == idConvertido).First();

                    int existencias = Convert.ToInt32(pro.cantidad);

                    if (existencias < cantidadCompra)
                    {
                        MessageBox.Show("No hay suficientes productos en existencias,\n" +
                            "pruebe otra cantidad");
                    }
                    else if (existencias >= cantidadCompra)
                    {

                        calculo();
                        //evaluar();
                        dgvDetalleVenta.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                                txtCantidad.Text, txtTotal.Text);

                        calculartotalfinal();

                        dgvDetalleVenta.Refresh();
                        dgvDetalleVenta.ClearSelection();
                        int ultimafila = dgvDetalleVenta.Rows.Count - 1;
                        dgvDetalleVenta.FirstDisplayedScrollingRowIndex = ultimafila;
                        dgvDetalleVenta.Rows[ultimafila].Selected = true;
                        limpiarproducto();

                    }
                }
            
                else
                {
                    MessageBox.Show("Datos vacios");
                }

                               
            }
           
        }

        private void btnBuscarProdcuto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto bp = new frmBuscarProducto();
            bp.Show();
        }

        private void cbTickect_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTickect.CheckState == CheckState.Checked )
            {
                cbFactura.Checked = false;
                txtApellidoCliente.Text = "Generico";
                txtDireccion.Text = "-----";
                txtDUI.Text = "-----";
                txtNombreCliente.Text = "Generico";
                txtTelefono.Text = "0000-0000";
                txtCodigoProducto.Focus();
                btnBuscarCliente.Enabled = false;
                
            }
            else if (cbTickect.CheckState == CheckState.Unchecked)
            {
                LimpiarCliente();
                btnBuscarCliente.Enabled = true;
            }
        }

        private void cbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFactura.CheckState == CheckState.Checked)
            {
                cbTickect.Checked = false;
                limpiarproducto();
                LimpiarCliente();
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            limpiarproducto();
            LimpiarCliente();
            dgvDetalleVenta.Rows.Clear();
            lblTotal.Text = "";
            dtpFecha.Text = "";
            cbFactura.Checked = false;
            cbTickect.Checked = false;
            this.Hide();
            Log_in.m.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
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
                    txtCodigoProducto.Text = Convert.ToString(pr.id_producto);
                    txtNombreProducto.Text = pr.nombre_producto;
                    txtPrecio.Text = Convert.ToString(pr.precio_venta);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar la venta?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                limpiarproducto();
                LimpiarCliente();
                dgvDetalleVenta.Rows.Clear();
                dtpFecha.Text = "";
                lblTotal.Text = "";
                cbFactura.Checked = false;
                cbTickect.Checked = false;
            }
        }

        private void dgvDetalleVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculartotalfinal();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.SoloNumeros(e);
        }

        private void btnNuevoiCliente_Click(object sender, EventArgs e)
        {
            frmClienteNuevo cn = new frmClienteNuevo();
            cn.Show();
        }

        
    }
}
