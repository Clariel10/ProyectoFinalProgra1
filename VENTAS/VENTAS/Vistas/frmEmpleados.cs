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
    public partial class frmEmpleados : Form
    {
        Validacion validacion = new Validacion();
        public frmEmpleados()
        {
            InitializeComponent();
            bloqueo();
        }

        void filtro()
        {

            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from m in bd.Empleados
                            where m.nombre_empleado.Contains(nombre)

                            select new
                            {
                                NUMERO_EMPLEADO = m.id_empleado,
                                NOMBRE = m.nombre_empleado,
                                APELLIDO = m.apellido_empleado,


                            };

                dgvEmpleados.DataSource = lista.ToList();


            }
        }

        void listaCargos()
        {
             using (VENTASEntities bd = new VENTASEntities())
            {
                var cargos = bd.Cargos.ToList();

                if (cargos.Count() > 0)
                {
                    cmbCargos.DataSource = cargos;
                    cmbCargos.DisplayMember = "nombre_cargo";
                    cmbCargos.ValueMember = "id_cargo";

                    if (cmbCargos.Items.Count > 0)
                        cmbCargos.SelectedIndex = -1;

                }


            }
            
        }


        void limpiar()
        {
            txtApellido.Text = "";
            cmbCargos.Text = "";
            txtContra.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            lblCargo.Text = "";

        }

        void cargar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {

                var lista = from m in bd.Empleados

                            select new
                            {
                                NUMERO_EMPLEADO = m.id_empleado,
                                NOMBRE = m.nombre_empleado,
                                APELLIDO = m.apellido_empleado
                            };

                dgvEmpleados.DataSource = lista.ToList();


            }
        }

        void bloqueo()
        {
            txtApellido.Enabled = false;
            cmbCargos.Enabled = false;
            txtContra.Enabled = false;
            txtNombre.Enabled = false;
            txtUsuario.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            filtro();

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            using (VENTASEntities bd = new VENTASEntities())
            {
              
                Empleado em = new Empleado();
                Cargo cargo = new Cargo();
                string id = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                em = bd.Empleados.Where(verificarId => verificarId.id_empleado == id2).First();
                cargo = bd.Cargos.Where(verificarId => verificarId.id_cargo == em.id_cargo).First();
                txtApellido.Text = em.apellido_empleado;
                lblCargo.Text = Convert.ToString(cargo.nombre_cargo);
                txtContra.Text = em.contrasenia;
                txtNombre.Text = em.nombre_empleado;
                txtUsuario.Text = em.usuario;
                lblModo.Text = "Visualizacion";
                rbNuevo.Checked = false;
                rbModificar.Checked = false;
                bloqueo();


            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && cmbCargos.Text != "" && txtContra.Text != ""
                && txtNombre.Text != "" && txtUsuario.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Empleado em = new Empleado();
                    em.apellido_empleado = txtApellido.Text;
                    em.id_cargo = int.Parse(cmbCargos.SelectedValue.ToString());
                    em.contrasenia = txtContra.Text;
                    em.nombre_empleado = txtNombre.Text;
                    em.usuario = txtUsuario.Text;
                    bd.Empleados.Add(em);
                    bd.SaveChanges();
                    listaCargos();

                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores Vacios");
            }
            limpiar();
            bloqueo();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtApellido.Text != "" && cmbCargos.Text != "" && txtContra.Text != ""
                && txtNombre.Text != "" && txtUsuario.Text != "")
            {
                if (cmbCargos.Text != "")
                {
                    using (VENTASEntities bd = new VENTASEntities())
                    {
                        Empleado em = new Empleado();
                        string id = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        em = bd.Empleados.Where(verificarId => verificarId.id_empleado == id2).First();
                        em.apellido_empleado = txtApellido.Text;
                        em.id_cargo = int.Parse(cmbCargos.SelectedValue.ToString());
                        em.contrasenia = txtContra.Text;
                        em.nombre_empleado = txtNombre.Text;
                        em.usuario = txtUsuario.Text;
                        bd.Entry(em).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        listaCargos();
                    }
                }
                else if (cmbCargos.Text == "")
                {
                    using (VENTASEntities bd = new VENTASEntities())
                    {
                        Empleado em = new Empleado();
                        string id = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        em = bd.Empleados.Where(verificarId => verificarId.id_empleado == id2).First();
                        em.apellido_empleado = txtApellido.Text;
                        em.contrasenia = txtContra.Text;
                        em.nombre_empleado = txtNombre.Text;
                        em.usuario = txtUsuario.Text;
                        bd.Entry(em).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                        listaCargos();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("No se aceptan valores Vacios");
            }
            limpiar();
            bloqueo();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != ""  && txtContra.Text != ""
               && txtNombre.Text != "" && txtUsuario.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    try
                    {
                        Empleado em = new Empleado();
                        string id = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                        int id2 = int.Parse(id);
                        em = bd.Empleados.Where(verificarId => verificarId.id_empleado == id2).First();
                        bd.Entry(em).State = System.Data.Entity.EntityState.Deleted;
                        bd.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Este Empleado esta relacionado a un \n" +
                                        "   registro de venta o de compra,\n" +
                                        "        no se puede eliminar");
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores Vacios");
            }
            limpiar();
            bloqueo();
            cargar();
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {

            if (rbNuevo.Checked == true && rbModificar.Checked == true)
            {
                rbModificar.Checked = false;
                txtApellido.Enabled = true;
                cmbCargos.Enabled = true;
                txtContra.Enabled = true;
                txtNombre.Enabled = true;
                txtUsuario.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
                listaCargos();
            }
            else if (rbNuevo.Checked == true && rbModificar.Checked == false)
            {

                txtApellido.Enabled = true;
                cmbCargos.Enabled = true;
                txtContra.Enabled = true;
                txtNombre.Enabled = true;
                txtUsuario.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
                listaCargos();
            }
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModificar.Checked == true && rbNuevo.Checked == true)
            {
                rbNuevo.Checked = false;
                txtApellido.Enabled = true;
                cmbCargos.Enabled = true;
                txtContra.Enabled = true;
                txtNombre.Enabled = true;
                txtUsuario.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
                listaCargos();

            }
            else if (rbModificar.Checked == true && rbNuevo.Checked == false)
            {

                txtApellido.Enabled = true;
                cmbCargos.Enabled = true;
                txtContra.Enabled = true;
                txtNombre.Enabled = true;
                txtUsuario.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
                listaCargos();

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

     

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion val = new Validacion();
            val.soloLetras(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                if (txtUsuario.Text != "")
                {
                    var Revisar = from us in bd.Empleados
                                  where us.usuario == txtUsuario.Text
                                  select us;

                    if (Revisar.Count() > 0)
                    {
                        txtUsuario.Text = "";
                        MessageBox.Show("Nombre de Usuario existente\n" +
                                        "  Intente otro por favor");
                    }

                }
            }
                        
        }
    }
}
