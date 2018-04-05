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
    public partial class VisualizarValidaciones : Form
    {
        private String origenSeleccionado = String.Empty;
        private String reemplazoSeleccionado = String.Empty;

        public VisualizarValidaciones()
        {
            InitializeComponent();
            this.GeneraTabla();
            this.dgvVisualizaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizaciones_CellClick);
        }

        public void GeneraTabla()
        {
            List<ArchivoValidacion> listaValidaciones = new List<ArchivoValidacion>();
            DataTable dtValidaciones;
            String cadenaJson = String.Empty;
            String rutaValidaciones = @"C:\convertidor_config\config.txt";

            FileController fc = new FileController();
            JsonController jc = new JsonController();

            cadenaJson = fc.LeerArchivoConfiguracion(rutaValidaciones);
            listaValidaciones = jc.RegresaListaValidaciones(cadenaJson);

            if (cadenaJson.Equals(""))
            {
                MessageBox.Show("No existen Validaciones.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtValidaciones = ConvertToDataTable(listaValidaciones);

                dgvVisualizaciones.DataSource = dtValidaciones;

            }
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarValidacion_Click(object sender, EventArgs e)
        {
            ModificarValidacion modificarValidacion;

            if (!origenSeleccionado.Equals(""))
            {
                modificarValidacion = new ModificarValidacion(origenSeleccionado, reemplazoSeleccionado);
                modificarValidacion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un Valor de la Lista ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvVisualizaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row;

            try
            {
                 row = dgvVisualizaciones.SelectedRows[0];
                 origenSeleccionado = row.Cells[0].Value.ToString();
                 reemplazoSeleccionado = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar Valor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
