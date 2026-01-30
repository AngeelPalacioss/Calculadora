using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                int a = 0, b = 0, resultado = 0;

                a = Convert.ToInt32(variableA.Text);
                b = int.Parse(variableB.Text);

                resultado = a + b;

                MessageBox.Show("El resultado de la suma es: " + resultado.ToString(), "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la operacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }







        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
             
            variableA.ResetText();
            variableB.ResetText();
            variableA.Focus();

        }
    }
}
