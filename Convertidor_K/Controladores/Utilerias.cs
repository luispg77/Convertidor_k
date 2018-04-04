using Convertidor_K.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertidor_K.Controladores
{
    class Utilerias
    {
        public String RealizarReemplazos(String texto)
        {
            String cadenaFormateada = texto;
            String cadenaJson = String.Empty;
            List<ArchivoValidacion> listaValidaciones = new List<ArchivoValidacion>();
            String rutaValidaciones = @"C:\convertidor_config\config.txt";
            FileController fc = new FileController();
            JsonController jc = new JsonController();
            cadenaJson = fc.LeerArchivoConfiguracion(rutaValidaciones);
            listaValidaciones = jc.RegresaListaValidaciones(cadenaJson);
            foreach(ArchivoValidacion validacion in listaValidaciones)
            {
                cadenaFormateada = cadenaFormateada.Replace(validacion.origen, validacion.reemplazo);
            }
            return cadenaFormateada;
        }
    }
}
