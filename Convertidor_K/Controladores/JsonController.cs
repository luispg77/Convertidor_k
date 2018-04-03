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
        public List<ArchivoValidacion> RegresaListaValidaciones(string cadenaJson)
        {
            List<ArchivoValidacion> validaciones = new List<ArchivoValidacion>();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            validaciones = ser.Deserialize<List<ArchivoValidacion>>(cadenaJson);
            return validaciones;
        }

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