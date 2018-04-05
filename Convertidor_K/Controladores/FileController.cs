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
        /// <summary>
        /// Crea/Guarda el archivo de configuración
        /// </summary>
        /// <param name="cadenaJson">cadena Json a guardar en el archivo de configuración</param>
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
        /// <summary>
        /// Lee el archivo de configuración y regresa el texto contenido en él
        /// </summary>
        /// <param name="ruta">ruta en la que se encuentra el archivo debe ir con extensión</param>
        /// <returns>String</returns>
        public String LeerArchivoConfiguracion(String ruta)
        {
            String texto = String.Empty;
            texto = File.ReadAllText(ruta);
            return texto;
        }
    }
}