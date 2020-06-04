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
    public partial class frmVerClientes : Form
    {
        public frmVerClientes()
        {
            InitializeComponent();
        }

        void filtro()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from cli in bd.Clientes
                            where cli.nombre_cliente.Contains(nombre)

                            select new
                            {
                                NOMBRE = cli.nombre_cliente,
                                APELLIDO = cli.apellido_cliente,
                                DIRECCION = cli.direccion,
                                TELEFONO = cli.telefono,
                                DUI = cli.dui,
                                NIT = cli.nit,
                                NRC = cli.nrc


                            };

                dgvClientes.DataSource = lista.ToList();
            }
        }

        private void frmVerClientes_Load(object sender, EventArgs e)
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
    }
}
