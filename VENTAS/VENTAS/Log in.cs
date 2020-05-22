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
using VENTAS.Vistas;

namespace VENTAS
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            txtContra.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            

            }

        private void button1_Click(object sender, EventArgs e)
        {
            using (VENTASEntities bd = new VENTASEntities())
            {
                var entrar = from us in bd.Empleados
                             where us.usuario == txtUsuario.Text
                             && us.contrasenia == txtContra.Text
                             select us;

                if (entrar.Count() > 0)
                {
                    FrmMeniu m = new FrmMeniu();
                    m.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }
    }
}
