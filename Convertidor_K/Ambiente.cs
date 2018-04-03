using Convertidor_K.Entidades;
using Convertidor_K.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Convertidor_K
{
    public partial class Ambiente : Form
    {
        public Ambiente()
        {
            Thread hilo = new Thread(new ThreadStart(IniciaSplash));
            hilo.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            hilo.Abort();
        }

        public void IniciaSplash()
        {
            Application.Run(new Splash());
        }

        private void Ambiente_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            richTextBox1.Text = String.Empty;
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String nombreArchivo = String.Empty;
                String texto = String.Empty;
                String textoNuevo = String.Empty;
                openFileDialog1.ShowDialog();
                nombreArchivo = openFileDialog1.FileName;
                label1.Text = openFileDialog1.SafeFileName;
                texto = File.ReadAllText(nombreArchivo);
                Archivo archivo = new Archivo();
                textoNuevo = archivo.QuitaSaltosVacios(texto);
                richTextBox1.Text = textoNuevo;

            }
            catch(FileNotFoundException fe)
            {
                MessageBox.Show("No se pudo abrir el archivo", "Error de lectura: " + fe.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa se generó para apoyo del equipo de CFDI - IBM", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void crearExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelController excon = new ExcelController();
            try
            {
                string texto = String.Empty;
                string[] textoSeparado = null;
                string nombreArchivo = String.Empty;
                Archivo archivo = new Archivo();
                texto = richTextBox1.Text;
                nombreArchivo = label1.Text;
                nombreArchivo.Replace(".txt", "");
                if (!texto.Equals(""))
                {
                    textoSeparado = archivo.SeparadorInicial(texto);
                    excon.CrearArchivo(textoSeparado,nombreArchivo);
                    MessageBox.Show("Se generó Excel con " + textoSeparado.Length + " elementos en c:/archivos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay información para generar archivo Excel :'(", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarValidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarValidacion agregarValidacion = new AgregarValidacion();
            agregarValidacion.Show();
        }
    }
}
