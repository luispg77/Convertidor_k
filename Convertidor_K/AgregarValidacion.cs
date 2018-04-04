using System;
using System.Windows.Forms;
using Convertidor_K.Controladores;

namespace Convertidor_K
{
    public partial class AgregarValidacion : Form
    {
        public AgregarValidacion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidadorController validadorInp = new ValidadorController();

            if (!validadorInp.ValidaInputNullo(rtbReemplazo))
            {
                MessageBox.Show("El texto de Reemplazo esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Guardar en archivo--

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbOriginal_TextChanged(object sender, EventArgs e)
        {
            ValidadorController validadorText = new ValidadorController();
            rtbOriginal.Text = validadorText.ValidaEntradaTexto(rtbOriginal);

            rtbOriginal.Select(this.rtbOriginal.Text.Length, 0);
        }

        private void rtbReemplazo_TextChanged(object sender, EventArgs e)
        {
            ValidadorController validadorText = new ValidadorController();
            rtbReemplazo.Text = validadorText.ValidaEntradaTexto(rtbReemplazo);

            rtbReemplazo.Select(this.rtbReemplazo.Text.Length, 0);
        }
    }
}
