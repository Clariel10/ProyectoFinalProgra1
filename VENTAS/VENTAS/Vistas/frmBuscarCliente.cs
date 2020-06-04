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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        void enviar()
        {
            String nombre = dgvBuscarCliente.CurrentRow.Cells[0].Value.ToString();
            String apellido = dgvBuscarCliente.CurrentRow.Cells[1].Value.ToString();
            String telefono = dgvBuscarCliente.CurrentRow.Cells[2].Value.ToString();
            String dui = dgvBuscarCliente.CurrentRow.Cells[3].Value.ToString();
            String direccion = dgvBuscarCliente.CurrentRow.Cells[4].Value.ToString();

            FrmMeniu.ventas.txtNombreCliente.Text = nombre;
            FrmMeniu.ventas.txtApellidoCliente.Text = apellido;
            FrmMeniu.ventas.txtTelefono.Text = telefono;
            FrmMeniu.ventas.txtDUI.Text = dui;
            FrmMeniu.ventas.txtDireccion.Text = direccion;



            FrmMeniu.ventas.txtCodigoProducto.Focus();

            this.Close();
        }

        void filtro()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;

                var lista = from c in bd.Clientes
                            where c.nombre_cliente.Contains(nombre)

                            select new
                            {
                                NOMBRE = c.nombre_cliente,
                                APELLIDO = c.apellido_cliente,
                                TELEFONO = c.telefono,
                                DUI = c.dui,
                                DIRECCION = c.direccion

                            };

                dgvBuscarCliente.DataSource = lista.ToList();
            }
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
