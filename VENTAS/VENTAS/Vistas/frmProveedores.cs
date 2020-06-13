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

    
    public partial class frmProveedores : Form
    {

        Validacion val = new Validacion();
        public frmProveedores()
        {
            InitializeComponent();
            bloqueo();
        }

        void filtro()
        {

            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from pro in bd.Proveedores
                            where pro.nombre_proveedor.Contains(nombre)

                            select new
                            {
                                NUMERO_PROVEEDOR = pro.id_proveedor,
                                NOMBRE = pro.nombre_proveedor,
                            };

                dgvProveedores.DataSource = lista.ToList();
            }
        }

        void limpiar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";

        }

        void bloqueo()
        {
            txtDireccion.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            rbModificar.Checked = false;
            rbNuevo.Checked = false;
        }

        void cargar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var lista = from pro in bd.Proveedores

                            select new
                            {
                                NUMERO_PROVEEDOR = pro.id_proveedor,
                                NOMBRE = pro.nombre_proveedor,
                                
                            };

                dgvProveedores.DataSource = lista.ToList();
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNuevo.Checked == true && rbModificar.Checked == true)
            {
                rbModificar.Checked = false;
                txtDireccion.Enabled = true;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();

            }
            else if (rbNuevo.Checked == true && rbModificar.Checked == false)
            {
                txtDireccion.Enabled = true;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
            }
        }

        private void rbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbModificar.Checked == true && rbNuevo.Checked == true)
            {
                rbNuevo.Checked = false;
                txtDireccion.Enabled = true;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";

            }
            else if (rbModificar.Checked == true && rbNuevo.Checked == false)
            {
                txtDireccion.Enabled = true;
                txtNombre.Enabled = true;
                txtTelefono.Enabled = true;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Proveedore pro = new Proveedore();
                    pro.nombre_proveedor = txtNombre.Text;
                    pro.telefono = txtTelefono.Text;
                    pro.direccion = txtDireccion.Text;
                    bd.Proveedores.Add(pro);
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
            if (txtDireccion.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Proveedore pro = new Proveedore();
                    string id = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    pro = bd.Proveedores.Where(verificarId => verificarId.id_proveedor == id2).First();
                    pro.nombre_proveedor = txtNombre.Text;
                    pro.telefono = txtTelefono.Text;
                    pro.direccion = txtDireccion.Text;
                    bd.Entry(pro).State = System.Data.Entity.EntityState.Modified;
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

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Proveedore pro = new Proveedore();
                string id = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                pro = bd.Proveedores.Where(verificarId => verificarId.id_proveedor == id2).First();
                txtDireccion.Text = pro.direccion;
                txtNombre.Text = pro.nombre_proveedor;
                txtTelefono.Text = pro.telefono;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
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
                    var Revisar = from pro in bd.Proveedores
                                  where pro.nombre_proveedor == txtNombre.Text
                                  select pro;

                    if (Revisar.Count() > 0)
                    {
                        txtNombre.Text = "";
                        MessageBox.Show("Proveedor existente");

                    }

                }
            }
        }
    }
}
