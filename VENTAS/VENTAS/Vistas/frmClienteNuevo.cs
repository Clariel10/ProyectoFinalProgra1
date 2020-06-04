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
    public partial class frmClienteNuevo : Form
    {
        public frmClienteNuevo()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            txtNit.Text = "";
            txtNombre.Text = "";
            txtNrc.Text = "";
            txtTelefono.Text = "";
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDui.Text != ""
                  && txtNit.Text != "" && txtNombre.Text != "" && txtNrc.Text != "" && txtTelefono.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {

                    Cliente cli = new Cliente();
                    cli.apellido_cliente = txtApellido.Text;
                    cli.nombre_cliente = txtNombre.Text;
                    cli.direccion = txtDireccion.Text;
                    cli.telefono = txtTelefono.Text;
                    cli.dui = txtDui.Text;
                    cli.nit = txtNit.Text;
                    cli.nrc = txtNrc.Text;
                    bd.Clientes.Add(cli);
                    bd.SaveChanges();

                    limpiar();

                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar \n" +
                    "valores nulos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
