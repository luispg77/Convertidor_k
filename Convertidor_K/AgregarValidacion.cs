using System;
using System.Windows.Forms;
using Convertidor_K.Controladores;
using Convertidor_K.Entidades;
using System.Collections.Generic;

namespace Convertidor_K
{
    public partial class AgregarValidacion : Form
    {
        public AgregarValidacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidadorController validadorInp = new ValidadorController();

            List<ArchivoValidacion> listaValidaciones = new List<ArchivoValidacion>();
            ArchivoValidacion nuevaValidacion = null;
            String cadenaJson = String.Empty;
            String rutaValidaciones = @"C:\convertidor_config\config.txt";
            String auxOriginal;

            FileController fc = new FileController();
            JsonController jc = new JsonController();

            if (!validadorInp.ValidaInputNullo(rtbReemplazo))
            {
                MessageBox.Show("El texto de Reemplazo esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                auxOriginal = rtbOriginal.Text.Replace("\\r\\n", "\r\n");
                nuevaValidacion = new ArchivoValidacion(auxOriginal, rtbReemplazo.Text);
                cadenaJson = fc.LeerArchivoConfiguracion(rutaValidaciones);
                listaValidaciones = jc.RegresaListaValidaciones(cadenaJson);
                if (validadorInp.ValidaEntidadArchivo(nuevaValidacion, listaValidaciones))
                {
                    listaValidaciones.Add(nuevaValidacion);
                    cadenaJson = jc.RegresaCadenaJsonValidaciones(listaValidaciones);
                    try
                    {
                        fc.CargarCrearArchivoConfig(cadenaJson);
                        MessageBox.Show("La validación se Agrego Correctamente", "Validacion Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar Validación: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La validación ya  fue Ingresada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

    }
}
