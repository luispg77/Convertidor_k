using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;

namespace Convertidor_K.Controladores
{
    class ExcelController
    {
        public void CrearArchivo(string [] lineasObtenidas, string nombreArchivo)
        {
            //Se inicializan variables generales
            int filas = 0;
            int columnas = 0;
            int columnaExcelUno = 1;
            int filaExcelInicio = 2;
            int columnaExcelInicio = 1;
            string[] columnasAux = lineasObtenidas[0].Split('|');
            string[] lineaSeparada = { };
            List<string> cabeceras = new List<string>();
            //Se calculan filas y columnas
            filas = lineasObtenidas.Length;
            columnas = columnasAux.Length;
            //Se crean las columnas cabecera
            for(int indice = 1; indice <= 3; indice++)
            {
                cabeceras.Add("Columna_" + indice);
            }
            //Está línea impide errores de compatibilidad contras office 32 bits
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //Se crea las instancias del Excel a generar
            Excel.Application xlAapp = new Microsoft.Office.Interop.Excel.Application();
            //Se valida que esté instalado excel
            if (xlAapp == null)
            {
                throw new Exception("No tiene instalado Excel :(");
            }
            //Se crea el Archivo de Excel
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object valorPerdido = System.Reflection.Missing.Value;

            xlWorkBook = xlAapp.Workbooks.Add(valorPerdido);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //Agrega cabeceras
            foreach(string cabecera in cabeceras)
            {
                xlWorkSheet.Cells[1, columnaExcelUno] = cabecera;
                columnaExcelUno++;
            }
            //Se agregan datos            
            foreach(string linea in lineasObtenidas)
            {
                lineaSeparada = linea.Split('|');
                foreach(string columna in lineaSeparada)
                {
                    xlWorkSheet.Cells[filaExcelInicio, columnaExcelInicio] = columna;
                    columnaExcelInicio++;
                }
                columnaExcelInicio = 1;
                filaExcelInicio++;
            }
            //xlWorkSheet.Cells[1, 1] = "filas: " + filas + " columnas: " + columnas;
            xlWorkBook.SaveAs("c:\\archivos\\" + nombreArchivo + ".xls", Excel.XlFileFormat.xlWorkbookNormal, valorPerdido, valorPerdido, valorPerdido, valorPerdido, Excel.XlSaveAsAccessMode.xlExclusive, valorPerdido, valorPerdido, valorPerdido, valorPerdido, valorPerdido);
            xlWorkBook.Close(true, valorPerdido, valorPerdido);

            xlAapp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlAapp);
        }
    }
}
