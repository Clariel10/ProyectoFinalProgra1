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

        private void Inventario_Load(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var lista = from pro in bd.Productos
                            from cat in bd.Categorias
                            where pro.id_categoria == cat.id_categoria
                            

                            select new
                            {
                                NOMBRE = pro.nombre_producto,
                                EXISTENCIAS = pro.cantidad,
                                CATEGORIA = cat.nombre_categoria,
                                COSTO = pro.costo,
                                PRECIO_VENTA = pro.precio_venta
                                

                            };

                dgvInventario.DataSource = lista.ToList();


            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }
    }
}
