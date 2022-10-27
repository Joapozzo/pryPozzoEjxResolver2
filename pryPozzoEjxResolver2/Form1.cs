using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPozzoEjxResolver2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show = ("Ingrese solo Numeros");
            }
            
        }

        private void mrcCosto_Enter(object sender, EventArgs e)
        {

        }

        private void lblPrecioMostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPrecioMostrar_TextChanged(object sender, EventArgs e)
        {
           



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int vDias = 0;
            int vDistancia = 0;
            int vCosto = 5;
            int vPrecio = 0;
            int vTotal = 0;

            vDias = Convert.ToInt32(numDias.Value);
            vDistancia = Convert.ToInt32(txtDistancia.Text);
            vPrecio = vDistancia * vCosto;
            vTotal = vPrecio / 2;

            
            if (vDistancia >= 100 && vDias >= 7)
            {
                lblPrecioMostrar.Text = ("$") + Convert.ToString(vPrecio);
                lblTotalMostrar.Text = ("$") + vTotal.ToString() + " " + ("Su descuento es del %50");
            }
            else
            {
                lblPrecioMostrar.Text = ("$") + Convert.ToString(vPrecio);
                lblTotalMostrar.Text = ("$") + Convert.ToString(vPrecio);
            }
        }
    }
}
