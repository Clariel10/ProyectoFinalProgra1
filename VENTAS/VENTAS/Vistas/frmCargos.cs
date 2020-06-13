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
    public partial class frmCargos : Form
    {
        Validacion val = new Validacion();
        public frmCargos()
        {
            InitializeComponent();
            bloqueo();
            
        }

       void filtro()
        {

            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from c in bd.Cargos
                            where c.nombre_cargo.Contains(nombre)

                            select new
                            {
                                NUMERO_CARGO = c.id_cargo,
                                NOMBRE = c.nombre_cargo

                            };

                dgvCargo.DataSource = lista.ToList();


            }
        }

        void bloqueo()
        {
            txtNombre.Enabled = false;
            txtCargo.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        void limpiar()
        {
            txtNombre.Text = "";
            txtCargo.Text = "";
        }

        void cargar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var lista = from c in bd.Cargos

                            select new
                            {
                                NUMERO_CARGO = c.id_cargo,
                                NOMBRE = c.nombre_cargo

                            };

                dgvCargo.DataSource = lista.ToList();


            }

        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Cargo ca = new Cargo();
                string id = dgvCargo.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                ca = bd.Cargos.Where(verificarId => verificarId.id_cargo == id2).First();
                txtNombre.Text = ca.nombre_cargo;
                txtCargo.Text = Convert.ToString(ca.sueldo);
                lblModo.Text = "Visualizacion";
                rbNuevo.Checked = false;
                rbModificar.Checked = false;
                bloqueo();

            }
        }
                             

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
        }

        private void rbNuevo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbNuevo.Checked == true && rbModificar.Checked == true)
            {
                rbModificar.Checked = false;
                txtNombre.Enabled = true;
                txtCargo.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
            }
            else if (rbNuevo.Checked == true && rbModificar.Checked == false)
            {
                txtNombre.Enabled = true;
                txtCargo.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
            }
        }

        private void rbModificar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbModificar.Checked == true && rbNuevo.Checked == true)
            {
                rbNuevo.Checked = false;
                txtNombre.Enabled = true;
                txtCargo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
            else if (rbModificar.Checked == true && rbNuevo.Checked == false)
            {
                txtNombre.Enabled = true;
                txtCargo.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtCargo.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Cargo ca = new Cargo();
                    ca.nombre_cargo = txtNombre.Text;
                    ca.sueldo = decimal.Parse(txtCargo.Text);
                    bd.Cargos.Add(ca);
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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtCargo.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Cargo ca = new Cargo();
                    string id = dgvCargo.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    ca = bd.Cargos.Where(verificarId => verificarId.id_cargo == id2).First();
                    ca.nombre_cargo = txtNombre.Text;
                    ca.sueldo = decimal.Parse(txtCargo.Text);
                    bd.Entry(ca).State = System.Data.Entity.EntityState.Modified;
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

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.soloLetras(e);
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

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                if (txtNombre.Text != "")
                {
                    var Revisar = from car in bd.Cargos
                                  where car.nombre_cargo == txtNombre.Text
                                  select car;

                    if (Revisar.Count() > 0)
                    {
                        txtNombre.Text = "";
                        MessageBox.Show("Nombre de Cargo existente\n" +
                                        "  Intente otro por favor");
                    }

                }
            }
        }
    }
}

