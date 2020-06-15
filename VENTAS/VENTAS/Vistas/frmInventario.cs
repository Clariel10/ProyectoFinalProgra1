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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        void filtro()
        {
           using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from pro in bd.Productos
                            from cat in bd.Categorias
                            from prov in bd.Proveedores
                            where pro.id_categoria == cat.id_categoria
                            where pro.id_proveedor == prov.id_proveedor
                            where pro.nombre_producto.Contains(nombre)

                            select new
                            {
                                NOMBRE = pro.nombre_producto,
                                EXISTENCIAS = pro.cantidad,
                                CATEGORIA = cat.nombre_categoria,
                                PROVEEDOR = prov.nombre_proveedor,
                                COSTO = pro.costo,
                                PRECIO_VENTA = pro.precio_venta

                            };

                dgvInventario.DataSource = lista.ToList();

            }
        }        

        private void Inventario_Load(object sender, EventArgs e)
        {
            filtro();
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

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dgvInventario.Columns[e.ColumnIndex].Index == 1)
            {
                if (Convert.ToInt32(e.Value) <= 149 )
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Salmon;
                                        
                }
                if (Convert.ToInt32(e.Value) >= 150 && Convert.ToInt32(e.Value) <= 300)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Khaki;
                }
            }
        }
    }
}
