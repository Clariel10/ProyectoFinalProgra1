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
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;

namespace VENTAS.Vistas
{
    public partial class frmVentas : Form
    {
        public static Log_in log = new Log_in();

        string imagen = "Desktop\\venta";
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

        void evaluacion()
        {
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                calculo();
                dgvDetalleVenta.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                        txtCantidad.Text, txtTotal.Text);
                calculartotalfinal();
                limpiarproducto();
            }
            else if (dgvDetalleVenta.Rows.Count > 0)
            {
                calculo();
                for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
                {
                    int codigotxt = Convert.ToInt32(txtCodigoProducto.Text);
                    string cod = dgvDetalleVenta.Rows[i].Cells[0].Value.ToString();
                    int codigodgv = Convert.ToInt32(cod);
                    
                    if (i == dgvDetalleVenta.Rows.Count - 1 && codigodgv == codigotxt)
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

                        //ENVIANDO DATOS NUEVOS

                        dgvDetalleVenta.Rows[i].Cells[3].Value = sumacantidad;

                        dgvDetalleVenta.Rows[i].Cells[4].Value = suma2Total;

                        calculartotalfinal();
                        limpiarproducto();

                        break;
                    }
                    else if (i == dgvDetalleVenta.Rows.Count - 1 && codigodgv != codigotxt)
                    {
                        calculo();
                        dgvDetalleVenta.Rows.Add(txtCodigoProducto.Text, txtNombreProducto.Text, txtPrecio.Text,
                                txtCantidad.Text, txtTotal.Text);
                        calculartotalfinal();
                        limpiarproducto();
                        break;
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

                if (txtNombreCliente.Text != "" && txtApellidoCliente.Text != "" && txtTelefono.Text != "" && txtDUI.Text != "" && txtDireccion.Text != "")

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

                    //IMPRIMIENDO FACTURA

                    pdImprimir = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    pdImprimir.PrinterSettings = ps;
                    pdImprimir.PrintPage += Imprimir;
                    pdImprimir.Print();



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
                        evaluacion();
                        dgvDetalleVenta.Refresh();
                        dgvDetalleVenta.ClearSelection();
                        int ultimafila = dgvDetalleVenta.Rows.Count - 1;
                        dgvDetalleVenta.FirstDisplayedScrollingRowIndex = ultimafila;
                        dgvDetalleVenta.Rows[ultimafila].Selected = true;

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
            if (cbTickect.CheckState == CheckState.Checked)
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

        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Image img = Image.FromFile();
            Font font = new Font("Arial", 14);
            Font font2 = new Font("Arial", 10);
            int ancho = 1000;
            int y = 20;

            e.Graphics.DrawString("SISTEMA DE VENTA", font, Brushes.Black, new RectangleF(350, y += 50, ancho, 20));
            e.Graphics.DrawString("Comprobante de pago", font2, Brushes.Black, new RectangleF(375, y += 20, ancho, 20));
            //e.Graphics.DrawImage(img, new Rectangle(50, y += 20, 100,50));
            e.Graphics.DrawString("                Comprobante #  " + lblIdVenta.Text, font, Brushes.Black, new RectangleF(20, y += 50, ancho, 20));
            e.Graphics.DrawString("Fecha: " + dtpFecha.Text, font, Brushes.Black, new RectangleF(450, y + 30, ancho, 20));
            e.Graphics.DrawString("                Cliente: " + txtNombreCliente.Text + " " + txtApellidoCliente.Text, font, Brushes.Black, new RectangleF(20, y += 30, ancho, 20));
            e.Graphics.DrawString("                Cajero: " + lblNombreCajero.Text, font, Brushes.Black, new RectangleF(20, y += 30, ancho, 20));
            y += 35;
            e.Graphics.DrawString("                Producto" + "                      " + "Precio" + "                  " + "Cantidad" + "               " + "Total"
                , font, Brushes.Black, new RectangleF(20, y += 35, ancho, 20));
            y += 35;

            for (int i = 0; i < dgvDetalleVenta.RowCount; i++)
            {

                e.Graphics.DrawString(dgvDetalleVenta.Rows[i].Cells[1].Value.ToString(), font, Brushes.Black, new RectangleF(110, y + 20, ancho, 20));
                e.Graphics.DrawString("$ " + dgvDetalleVenta.Rows[i].Cells[2].Value.ToString(), font, Brushes.Black, new RectangleF(300, y + 20, ancho, 20));
                e.Graphics.DrawString(dgvDetalleVenta.Rows[i].Cells[3].Value.ToString(), font, Brushes.Black, new RectangleF(490, y + 20, ancho, 20));
                e.Graphics.DrawString("$ " + dgvDetalleVenta.Rows[i].Cells[4].Value.ToString(), font, Brushes.Black, new RectangleF(610, y + 20, ancho, 20));
                y += 20;

            }
            y += 40;
            e.Graphics.DrawString("Total:  $ " + lblTotal.Text, font, Brushes.Black, new RectangleF(120, y += 35, ancho, 20));
            e.Graphics.DrawString("¡Gracias por tu compra!", font, Brushes.Black, new RectangleF(300, y += 55, ancho, 20));


        }
    }
}
