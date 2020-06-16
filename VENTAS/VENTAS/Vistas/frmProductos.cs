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
    public partial class frmProductos : Form
    {
        Validacion Val = new Validacion();
        public frmProductos()
        {
            InitializeComponent();
            bloqueo();
            
        }

        void calcular()
        {
            if (txtCosto.Text == null)
            {
                MessageBox.Show("No puedes ingresar costos menores a 0");
                txtCosto.Select();
            }
            else
            {
                try
                {
                    Double costo;
                    Double precioV;

                    costo = Double.Parse(txtCosto.Text);

                    precioV = ((costo * 0.20) + costo);
                    txtVenta.Text = precioV.ToString();
                }
                catch (Exception ex)
                {
                    txtCosto.Text = "0";
                    txtCosto.Select();
                }
            }
        }

        void filtro()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from pro in bd.Productos
                            where pro.nombre_producto.Contains(nombre)

                            select new
                            {
                                NUMERO_PRODUCTO = pro.id_producto,
                                NOMBRE = pro.nombre_producto

                            };

                dgvProductos.DataSource = lista.ToList();

            }
        }

        void listaProveedores()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var proveedores = bd.Proveedores.ToList();

                if (proveedores.Count() > 0)
                {
                    cmbProveedor.DataSource = proveedores;
                    cmbProveedor.DisplayMember = "nombre_proveedor";
                    cmbProveedor.ValueMember = "id_proveedor";

                    if (cmbProveedor.Items.Count > 0)
                        cmbProveedor.SelectedIndex = -1;

                }


            }

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

        public List<Producto> Buscar()
        {
            VENTASEntities entity = new VENTASEntities();

            var query = from p in entity.Productos
                        select p;

            if (txtBuscar.Text != string.Empty)

                query = query.Where(p => p.nombre_producto == txtBuscar.Text);


           
            return query.ToList();
        }

        void limpiar()
        {
            cmbCategoria.Text = "";
            cmbProveedor.Text = "";
            lblCategoria.Text = "";
            txtNombre.Text = "";
            lblProveedor.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
            txtVenta.Text = "";
        }

        void bloqueo()
        {
            cmbCategoria.Enabled = false;
            txtNombre.Enabled = false;
            cmbProveedor.Enabled = false;
            txtCantidad.Enabled = false;
            txtCosto.Enabled = false;
            txtVenta.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            
        }

        void cargar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                var lista = from pro in bd.Productos

                            select new
                            {
                                NUMERO_PRODUCTO = pro.id_producto,
                                NOMBRE = pro.nombre_producto
                            };

                dgvProductos.DataSource = lista.ToList();

            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Producto pro = new Producto();
                Categoria cat = new Categoria();
                Proveedore prov = new Proveedore();
                string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                pro = bd.Productos.Where(verificarId => verificarId.id_producto == id2).First();
                cat = bd.Categorias.Where(verificarId => verificarId.id_categoria == pro.id_categoria).First();
                prov = bd.Proveedores.Where(verificarId => verificarId.id_proveedor == pro.id_proveedor).First();
                lblCategoria.Text = Convert.ToString(cat.nombre_categoria);
                txtNombre.Text = pro.nombre_producto;
                lblProveedor.Text = Convert.ToString(prov.nombre_proveedor);
                txtCantidad.Text = Convert.ToString(pro.cantidad);
                txtCosto.Text = Convert.ToString(pro.costo);
                txtVenta.Text = Convert.ToString(pro.precio_venta);
                lblModo.Text = "Visualizacion";
                rbNuevo.Checked = false;
                rbModificar.Checked = false;
                bloqueo();

            }

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtNombre.Text != "" && txtCosto.Text != "" && txtVenta.Text != ""
                && cmbProveedor.Text != "" && cmbCategoria.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Producto pro = new Producto();
                    pro.id_categoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                    pro.id_proveedor = int.Parse(cmbProveedor.SelectedValue.ToString());
                    pro.nombre_producto = txtNombre.Text;
                    pro.cantidad = int.Parse(txtCantidad.Text);
                    pro.costo = decimal.Parse(txtCosto.Text);
                    pro.precio_venta = decimal.Parse(txtVenta.Text);
                    bd.Productos.Add(pro);
                    bd.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }
            limpiar();
            bloqueo();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtNombre.Text != "" && txtCosto.Text != "" && txtVenta.Text != "")
            {
                if (cmbProveedor.Text == "" && cmbCategoria.Text !="")
                {
                    using (VENTASEntities bd = new VENTASEntities())
                    {
                        Producto pro = new Producto();
                        string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        pro = bd.Productos.Where(verificarId => verificarId.id_producto == id2).First();
                        pro.id_categoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                        pro.nombre_producto = txtNombre.Text;
                        pro.cantidad = int.Parse(txtCantidad.Text);
                        pro.costo = decimal.Parse(txtCosto.Text);
                        pro.precio_venta = decimal.Parse(txtVenta.Text);
                        bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        listaProveedores();
                    }
                }
                else if (cmbCategoria.Text == "" && cmbProveedor.Text != "")
                {
                    using (VENTASEntities bd = new VENTASEntities())
                    {
                        Producto pro = new Producto();
                        string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        pro = bd.Productos.Where(verificarId => verificarId.id_producto == id2).First();
                        pro.id_proveedor = int.Parse(cmbProveedor.SelectedValue.ToString());
                        pro.nombre_producto = txtNombre.Text;
                        pro.cantidad = int.Parse(txtCantidad.Text);
                        pro.costo = decimal.Parse(txtCosto.Text);
                        pro.precio_venta = decimal.Parse(txtVenta.Text);
                        bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        listaProveedores();
                    }
                }
                else if (cmbCategoria.Text == "" && cmbProveedor.Text == "")
                {
                    using (VENTASEntities bd = new VENTASEntities())
                    {
                        Producto pro = new Producto();
                        string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        pro = bd.Productos.Where(verificarId => verificarId.id_producto == id2).First();
                        pro.nombre_producto = txtNombre.Text;
                        pro.cantidad = int.Parse(txtCantidad.Text);
                        pro.costo = decimal.Parse(txtCosto.Text);
                        pro.precio_venta = decimal.Parse(txtVenta.Text);
                        bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        listaProveedores();
                    }
                }
                else if (cmbCategoria.Text != "" && cmbProveedor.Text != "")
                {
                    using (VENTASEntities bd = new VENTASEntities())
                    {
                        Producto pro = new Producto();
                        string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        pro = bd.Productos.Where(verificarId => verificarId.id_producto == id2).First();
                        pro.id_categoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                        pro.id_proveedor = int.Parse(cmbProveedor.SelectedValue.ToString());
                        pro.nombre_producto = txtNombre.Text;
                        pro.cantidad = int.Parse(txtCantidad.Text);
                        pro.costo = decimal.Parse(txtCosto.Text);
                        pro.precio_venta = decimal.Parse(txtVenta.Text);
                        bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        listaProveedores();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }
            limpiar();
            bloqueo();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtNombre.Text != "" && txtCosto.Text != "" && txtVenta.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    try
                    {
                        Producto pro = new Producto();

                        string id = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        pro = bd.Productos.Where(verificarId => verificarId.id_producto == id2).First();
                        bd.Entry(pro).State = System.Data.Entity.EntityState.Deleted;
                        bd.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Este Producto esta relacionado a un \n" +
                                        "   registro de venta o de compra,\n" +
                                        "        no se puede eliminar");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }
            limpiar();
            bloqueo();
            cargar();
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {

            if (rbNuevo.Checked == true && rbModificar.Checked == true)
            {
                rbModificar.Checked = false;
                cmbCategoria.Enabled = true;
                txtNombre.Enabled = true;
                cmbProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
                
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                
                limpiar();
                listaCategorias();
                listaProveedores();

            }
            else if (rbNuevo.Checked == true && rbModificar.Checked == false)
            {
                cmbCategoria.Enabled = true;
                txtNombre.Enabled = true;
                cmbProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
               
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                
                lblModo.Text = "Guardado";
                limpiar();
                listaCategorias();
                listaProveedores();
            }
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModificar.Checked == true && rbNuevo.Checked == true)
            {
                rbNuevo.Checked = false;
                cmbCategoria.Enabled = true;
                txtNombre.Enabled = true;
                cmbProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
                txtVenta.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                
                lblModo.Text = "Edicion";
                listaCategorias();
                listaProveedores();

            }
            else if (rbModificar.Checked == true && rbNuevo.Checked == false)
            {
                cmbCategoria.Enabled = true;
                txtNombre.Enabled = true;
                cmbProveedor.Enabled = true;
                txtCantidad.Enabled = true;
                txtCosto.Enabled = true;
               
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                
                lblModo.Text = "Edicion";
                listaCategorias();
                listaProveedores();
            }
        }

   
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.soloLetras(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.SoloNumeros(e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.SoloNumeros(e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                if (txtNombre.Text != "")
                {
                    var Revisar = from pro in bd.Productos
                                  where pro.nombre_producto == txtNombre.Text
                                  select pro;

                    if (Revisar.Count() > 0)
                    {
                        txtNombre.Text = "";
                        MessageBox.Show("Nombre de Producto existente\n" +
                                        "  Intente otro por favor");
                    }

                }
            }
        }
    }
}
