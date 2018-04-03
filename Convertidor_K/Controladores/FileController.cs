using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.AccessControl;

namespace Convertidor_K.Controladores
{
    class FileController
    {
        public void CargarCrearArchivoConfig(string cadenaJson)
        {
            String rutaDirectorio = "c:\\convertidor_config";
            string path = "c:\\convertidor_config\\config.txt";
            if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            }
            using (StreamWriter sw = (File.Exists(path)) ? File.CreateText(path) : File.CreateText(path))
            {
                sw.WriteLine(cadenaJson);
            }
        }
    }
}
