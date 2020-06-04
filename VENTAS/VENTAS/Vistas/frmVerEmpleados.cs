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
    public partial class frmVerEmpleados : Form
    {
        public frmVerEmpleados()
        {
            InitializeComponent();
        }

        void filtro()
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                string nombre = txtBuscar.Text;
                var lista = from em in bd.Empleados
                            from ca in bd.Cargos
                            where em.id_cargo == ca.id_cargo
                            where em.nombre_empleado.Contains(nombre)

                            select new
                            {
                                NOMBRE = em.nombre_empleado,
                                APELLIDO = em.apellido_empleado,
                                CARGO = ca.nombre_cargo,
                                SUELDO = ca.sueldo,


                            };

                dgvEmpleados.DataSource = lista.ToList();
            }
        }

        private void frmVerEmpleados_Load(object sender, EventArgs e)
        {
            filtro();
        }

        private void frmVerEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
