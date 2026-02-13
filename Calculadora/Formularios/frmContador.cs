using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmContador : Form
    {
        int contador;
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tcbVelocidad.Enabled = true;
            tmrContador.Interval = tcbVelocidad.Value * 200;
            tcbVelocidad.Enabled = true;
            tmrContador.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            tcbVelocidad.Enabled = false;
            
        }

        private void tcbVelocidad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tcbVelocidad.Value * 200;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
        }
    }
}
