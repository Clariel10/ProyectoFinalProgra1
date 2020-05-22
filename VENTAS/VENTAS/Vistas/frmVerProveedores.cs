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
    public partial class frmVerProveedores : Form
    {
        public frmVerProveedores()
        {
            InitializeComponent();
        }

        private void frmVerProveedores_Load(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                var lista = from pro in bd.Proveedores

                            select new
                            {
                                NOMBRE = pro.nombre_proveedor,
                                DIRECCION = pro.direccion,
                                TELEFONO = pro.telefono
                            };

                dgvProveedores.DataSource = lista.ToList();

            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }
    }
}
