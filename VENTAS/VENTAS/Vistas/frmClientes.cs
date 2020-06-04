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
using System.Data.SqlClient;

namespace VENTAS.Vistas
{
    public partial class frmClientes : Form
    {
        Validacion validacion = new Validacion();
        public frmClientes()
        {
            InitializeComponent();
            bloqueo();

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
                                NUMERO_CLIENTE = cli.id_cliente,
                                NOMBRE = cli.nombre_cliente,
                                APELLIDO = cli.apellido_cliente
                            };

                dgvClientes.DataSource = lista.ToList();

            }
        }

        void cargar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                var lista = from cli in bd.Clientes

                            select new
                            {
                                NUMERO_CLIENTE = cli.id_cliente,
                                NOMBRE = cli.nombre_cliente,
                                APELLIDO = cli.apellido_cliente
                            };

                dgvClientes.DataSource = lista.ToList();

            }
            bloqueo();

        }
    


        void bloqueo()
        {
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtDui.Enabled = false;
           
            txtNit.Enabled = false;
            txtNombre.Enabled = false;
            txtNrc.Enabled = false;
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            rbModificar.Checked = false;
            rbNuevo.Checked = false;
        }


        void limpiar()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            txtDui.Text = "";
            
            txtNit.Text = "";
            txtNombre.Text = "";
            txtNrc.Text = "";
            txtTelefono.Text = "";
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (rbModificar.Checked == true && rbNuevo.Checked == true)
            {
                rbNuevo.Checked = false;
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                txtDui.Enabled = true;
                
                txtNit.Enabled = true;
                txtNombre.Enabled = true;
                txtNrc.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
            else if (rbModificar.Checked == true && rbNuevo.Checked == false)
            {
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                txtDui.Enabled = true;
                
                txtNit.Enabled = true;
                txtNombre.Enabled = true;
                txtNrc.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
           
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNuevo.Checked == true && rbModificar.Checked == true)
            {
                rbModificar.Checked = false;
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                txtDui.Enabled = true;
                
                txtNit.Enabled = true;
                txtNombre.Enabled = true;
                txtNrc.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
            }
            else if (rbNuevo.Checked == true && rbModificar.Checked == false)
            {
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                txtDui.Enabled = true;
                
                txtNit.Enabled = true;
                txtNombre.Enabled = true;
                txtNrc.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
            }
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
                    
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar \n" +
                    "valores nulos");
            }
            limpiar();
            bloqueo();
            cargar();
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDui.Text != ""  
                  && txtNit.Text != "" && txtNombre.Text != "" && txtNrc.Text != "" && txtTelefono.Text != "")
            {

                using (VENTASEntities bd = new VENTASEntities())
                {
                    Cliente cli = new Cliente();
                    string id = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    cli = bd.Clientes.Where(verificarId => verificarId.id_cliente == id2).First();
                    cli.apellido_cliente = txtApellido.Text;
                    cli.direccion = txtDireccion.Text;
                    cli.dui = txtDui.Text;
                   
                    cli.nit = txtNit.Text;
                    cli.nombre_cliente = txtNombre.Text;
                    cli.nrc = txtNrc.Text;
                    cli.telefono = txtTelefono.Text;
                    bd.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();


                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }

            limpiar();
            bloqueo();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtDireccion.Text != "" && txtDui.Text != ""  
                && txtNit.Text != "" && txtNombre.Text != "" && txtNrc.Text != "" && txtTelefono.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Cliente cli = new Cliente();
                    string id = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    cli = bd.Clientes.Where(verificarId => verificarId.id_cliente == id2).First();
                    bd.Entry(cli).State = System.Data.Entity.EntityState.Deleted;
                    bd.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("No se pueden eliminar \n" +
                    "valores vacios");
            }
            limpiar();
            bloqueo();
            cargar();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtGiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtNrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var mostrar = from cli in bd.Clientes
                              where cli.nombre_cliente == txtBuscar.Text
                              select cli;


                //if (mostrar.Count() > 0)
                //{
                //    dgvClientes.DataSource = mostrar.ToList();
                //}
                //else
                //{
                //    MessageBox.Show("No encontrado");
                //}

            }
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Cliente cli = new Cliente();

                string id = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                cli = bd.Clientes.Where(verificarId => verificarId.id_cliente == id2).First();
                txtNombre.Text = cli.nombre_cliente;
                txtApellido.Text = cli.apellido_cliente;
                txtDireccion.Text = cli.direccion;
                txtDui.Text = cli.dui;
                
                txtNit.Text = cli.nit;
                txtNrc.Text = cli.nrc;
                txtTelefono.Text = cli.telefono;
                lblModo.Text = "Visualizacion";
                rbNuevo.Checked = false;
                rbModificar.Checked = false;
                bloqueo();

            }
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
