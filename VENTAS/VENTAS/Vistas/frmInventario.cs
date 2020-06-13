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

        void filtro2()
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
                            select pro;


                foreach (var iteracion in lista)
                {
                    dgvInventario.Rows.Add(iteracion.nombre_producto,iteracion.cantidad,iteracion.Categoria.nombre_categoria, iteracion.Proveedore.nombre_proveedor,
                        iteracion.costo, iteracion.precio_venta);
                }

            }
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
                            select pro;


                foreach (var iteracion in lista)
                {
                    dgvInventario.Rows.Add(iteracion.nombre_producto,iteracion.cantidad,iteracion.Categoria.nombre_categoria, iteracion.Proveedore.nombre_proveedor,
                        iteracion.costo, iteracion.precio_venta);
                }

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
            filtro2();
        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dgvInventario.Columns[e.ColumnIndex].Name == "existencias")
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
