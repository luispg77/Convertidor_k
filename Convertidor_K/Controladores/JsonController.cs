using Convertidor_K.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Convertidor_K.Controladores
{
    class JsonController
    {
        /// <summary>
        /// Regresa una lista de todas las validaciones contenidas en la cadena Json que se le pasa como parámetro
        /// </summary>
        /// <param name="cadenaJson">Cadena Json a convertir en lista</param>
        /// <returns>List</returns>
        public List<ArchivoValidacion> RegresaListaValidaciones(string cadenaJson)
        {
            List<ArchivoValidacion> validaciones = new List<ArchivoValidacion>();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            validaciones = ser.Deserialize<List<ArchivoValidacion>>(cadenaJson);
            return validaciones;
        }
        /// <summary>
        /// Convierte una lista de archivos de validación en una cadena Json
        /// </summary>
        /// <param name="listaValidaciones">Lista de los archivos de validación</param>
        /// <returns>String</returns>
        public String RegresaCadenaJsonValidaciones(List<ArchivoValidacion> listaValidaciones)
        {
            String cadenaJson = String.Empty;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            cadenaJson = ser.Serialize(listaValidaciones);
            return cadenaJson;
        }
    }
}