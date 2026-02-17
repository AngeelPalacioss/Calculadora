using Calculadora.Formularios;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadoraSimple = new frmCalculadora();
            calculadoraSimple.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.Show();

        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();

            registro.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemporizadores tempo = new frmTemporizadores();
            tempo.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor frmEditor = new frmEditor();
            frmEditor.Show();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContador frmConta = new frmContador();

            frmConta.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXMLAcces frmXML = new frmXMLAcces();
            frmXML.Show();
        }
    }
}
