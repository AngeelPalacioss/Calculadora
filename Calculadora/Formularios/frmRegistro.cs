using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{

    public partial class frmRegistro : Form
    {
        List<Persona> persona = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Fecha = dtpNacimiento.Value });
            MessageBox.Show("Usuario registrado con exito", "Sistema");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
            }
        }

        
    }
}
