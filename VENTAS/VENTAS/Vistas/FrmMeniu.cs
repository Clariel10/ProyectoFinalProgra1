using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VENTAS.Consultar_RPT;
//using VENTAS.Consultar_RPT;

namespace VENTAS.Vistas
{
    public partial class FrmMeniu : Form
    {
        public FrmMeniu()
        {
            InitializeComponent();
        }

        private void agregarYModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Dock = DockStyle.Fill;
            clientes.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarYModificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmpleados em = new frmEmpleados();
            em.MdiParent = this;
            em.Dock = DockStyle.Fill;
            em.Show();
        }

        private void verYModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos pro = new frmProductos();
            pro.MdiParent = this;
            pro.Dock = DockStyle.Fill;
            pro.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verYBuscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.MdiParent = this;
            inventario.Dock = DockStyle.Fill;
            inventario.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerClientes vCli = new frmVerClientes();
            vCli.MdiParent = this;
            vCli.Dock = DockStyle.Fill;
            vCli.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ac = new frmAgregarCategoria();
            ac.MdiParent = this;
            ac.Dock = DockStyle.Fill;
            ac.Show();
        }

        private void verYBuscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerEmpleados ve = new frmVerEmpleados();
            ve.MdiParent = this;
            ve.Dock = DockStyle.Fill;
            ve.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargos cargos = new frmCargos();
            cargos.MdiParent = this;
            cargos.Dock = DockStyle.Fill;
            cargos.Show();
        }

        private void buscarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerProveedores pro = new frmVerProveedores();
            pro.MdiParent = this;
            pro.Dock = DockStyle.Fill;
            pro.Show();
        }

        private void agregarYEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores pro = new frmProveedores();
            pro.MdiParent = this;
            pro.Dock = DockStyle.Fill;
            pro.Show();
        }

        private void FrmMeniu_Load(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.MdiParent = this;
            inicio.Dock = DockStyle.Fill;
            inicio.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.MdiParent = this;
            inicio.Dock = DockStyle.Fill;
            inicio.Show();
        }

        public static frmVentas ventas = new frmVentas();
        public static frmCompras compras = new frmCompras();
        

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ventas.Show();

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            compras.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptProductos rpt = new frmrptProductos();
            rpt.MdiParent = this;
            rpt.Dock = DockStyle.Fill;
            rpt.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptCompras rpt2 = new frmrptCompras();
            rpt2.MdiParent = this;
            rpt2.Dock = DockStyle.Fill;
            rpt2.Show();
        }
    }
}
