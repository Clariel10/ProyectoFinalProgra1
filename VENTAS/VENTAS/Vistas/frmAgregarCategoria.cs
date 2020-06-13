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
    public partial class frmAgregarCategoria : Form
    {
        Validacion val = new Validacion();
        public frmAgregarCategoria()
        {
            InitializeComponent();
            bloqueo();
        }

        void filtro()
        {

            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from c in bd.Categorias
                            where c.nombre_categoria.Contains(nombre)

                            select new
                            {
                                NUMERO_CATEGORIA = c.id_categoria,
                                NOMBRE = c.nombre_categoria

                            };

                dgvCategorias.DataSource = lista.ToList();

            }
        }

            void bloqueo()
        {
            txtNombre.Enabled = false;
           
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        void limpiar()
        {
            txtNombre.Text = "";
        }

        void cargar()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var lista = from c in bd.Categorias

                            select new
                            {
                                NUMERO_CATEGORIA = c.id_categoria,
                                NOMBRE = c.nombre_categoria

                            };

                dgvCategorias.DataSource = lista.ToList();


            }

        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {

            filtro();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                Categoria ca = new Categoria();
                string id = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                ca = bd.Categorias.Where(verificarId => verificarId.id_categoria == id2).First();
                txtNombre.Text = ca.nombre_categoria;
                lblModo.Text = "Visualizacion";
                rbNuevo.Checked = false;
                rbModificar.Checked = false;
                bloqueo();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Categoria ca = new Categoria();
                    ca.nombre_categoria = txtNombre.Text;
                    bd.Categorias.Add(ca);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                using (VENTASEntities bd = new VENTASEntities())
                {
                    Categoria ca = new Categoria();
                    string id = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    ca = bd.Categorias.Where(verificarId => verificarId.id_categoria == id2).First();
                    ca.nombre_categoria = txtNombre.Text;
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

       

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNuevo.Checked == true && rbModificar.Checked == true)
            {
                rbModificar.Checked = false;
                txtNombre.Enabled = true;
               
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                lblModo.Text = "Guardado";
                limpiar();
            }
            else if (rbNuevo.Checked == true && rbModificar.Checked == false)
            {
                txtNombre.Enabled = true;
               
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
                txtNombre.Enabled = true;
              
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
            else if (rbModificar.Checked == true && rbNuevo.Checked == false)
            {
                txtNombre.Enabled = true;
               
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                lblModo.Text = "Edicion";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
                    var Revisar = from car in bd.Categorias
                                  where car.nombre_categoria == txtNombre.Text
                                  select car;

                    if (Revisar.Count() > 0)
                    {
                        txtNombre.Text = "";
                        MessageBox.Show("Nombre de Categoria existente\n" +
                                        "  Intente otro por favor");
                    }

                }
            }
        }
    }
}
