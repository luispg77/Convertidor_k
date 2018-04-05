using Convertidor_K.Controladores;
using Convertidor_K.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convertidor_K
{
    public partial class ModificarValidacion : Form
    {
        public ModificarValidacion(String origenSeleccionado,String reemplazoSeleccionado)
        {
            InitializeComponent();
            rtbOriginal.Text = origenSeleccionado;
            rtbReemplazo.Text = reemplazoSeleccionado;
            rtbOriginal.Text = rtbOriginal.Text.Replace("\r\n", "\\r\\n");
            rtbReemplazo.Text = rtbReemplazo.Text.Replace("\r\n", "\\r\\n");
        }

        private void rtbReemplazo_TextChanged(object sender, EventArgs e)
        {
            ValidadorController validadorText = new ValidadorController();
            rtbReemplazo.Text = validadorText.ValidaEntradaTexto(rtbReemplazo);

            rtbReemplazo.Select(this.rtbReemplazo.Text.Length, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VisualizarValidaciones visualizarValidacion;
            this.Close();
            visualizarValidacion = new VisualizarValidaciones();
            visualizarValidacion.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<ArchivoValidacion> listaValidaciones = new List<ArchivoValidacion>();
            ArchivoValidacion modificaValidacion = new ArchivoValidacion();
            String cadenaJson = String.Empty;
            String rutaValidaciones = @"C:\convertidor_config\config.txt";
            VisualizarValidaciones visualizarValidacion;

            FileController fc = new FileController();
            JsonController jc = new JsonController();

            cadenaJson = fc.LeerArchivoConfiguracion(rutaValidaciones);
            listaValidaciones = jc.RegresaListaValidaciones(cadenaJson);

            modificaValidacion = listaValidaciones.Find(x => x.origen == rtbOriginal.Text.Replace("\\r\\n", "\r\n"));
            modificaValidacion.reemplazo = rtbReemplazo.Text.Replace("\\r\\n", "\r\n");

            cadenaJson = jc.RegresaCadenaJsonValidaciones(listaValidaciones);
            try
            {
                fc.CargarCrearArchivoConfig(cadenaJson);
                MessageBox.Show("La validación se Agrego Correctamente", "Validacion Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                visualizarValidacion = new VisualizarValidaciones();
                visualizarValidacion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Validación: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
