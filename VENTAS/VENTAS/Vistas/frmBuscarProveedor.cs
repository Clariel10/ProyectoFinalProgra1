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
    public partial class frmBuscarProveedor : Form
    {
        public frmBuscarProveedor()
        {
            InitializeComponent();
        }

        void enviar()
        {
            String nombre = dgvBuscarCliente.CurrentRow.Cells[0].Value.ToString();            
            String telefono = dgvBuscarCliente.CurrentRow.Cells[1].Value.ToString();           
            String direccion = dgvBuscarCliente.CurrentRow.Cells[2].Value.ToString();

            FrmMeniu.compras.txtNombreProveedor.Text = nombre;            
            FrmMeniu.compras.txtTelefono.Text = telefono;            
            FrmMeniu.compras.txtDireccion.Text = direccion;

            FrmMeniu.compras.txtCodigoProducto.Focus();

            this.Close();
        }

        void filtro()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;

                var lista = from p in bd.Proveedores
                            where p.nombre_proveedor.Contains(nombre)

                            select new
                            {
                                NOMBRE = p.nombre_proveedor,                                
                                TELEFONO = p.telefono,                                
                                DIRECCION = p.direccion

                            };

                dgvBuscarCliente.DataSource = lista.ToList();
            }
        }

        private void frmBuscarProveedor_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBuscarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }

        private void dgvBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enviar();
            }
        }
    }
}
