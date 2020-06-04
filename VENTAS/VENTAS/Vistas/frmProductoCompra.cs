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
    public partial class frmProductoCompra : Form
    {
        public frmProductoCompra()
        {
            InitializeComponent();
        }

        void enviar()
        {
            String id = dgvBuscar.CurrentRow.Cells[0].Value.ToString();
            String nombre = dgvBuscar.CurrentRow.Cells[1].Value.ToString();
            String precio = dgvBuscar.CurrentRow.Cells[2].Value.ToString();

            FrmMeniu.compras.txtCodigoProducto.Text = id;
            FrmMeniu.compras.txtNombreProducto.Text = nombre;
            FrmMeniu.compras.txtPrecio.Text = precio;

            FrmMeniu.compras.txtCantidad.Focus();

            this.Close();
        }

        void filtro()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;

                var lista = from p in bd.Productos
                            where p.nombre_producto.Contains(nombre)

                            select new
                            {
                                CODIGO = p.id_producto,
                                NOMBRE = p.nombre_producto,
                                PRECIO = p.costo

                            };

                dgvBuscar.DataSource = lista.ToList();
            }
        }

        private void frmProductoCompra_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }

        private void dgvBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enviar();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
