using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTAS
{
    class Validacion
    {
        public void soloLetras(KeyPressEventArgs e)
        {
            try {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


            } catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }


        }

        

        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {                   
                    
                        e.Handled = false;
                     
                }
                else
                {
                    e.Handled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
