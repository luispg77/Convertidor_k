using Convertidor_K.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertidor_K.Entidades
{
    class Archivo
    {
        public Archivo()
        {
            this.nombreArchivo = String.Empty;
            this.texto = String.Empty;
        }
        public Archivo(String nombre, String texto)
        {
            this.nombreArchivo = nombre;
            this.texto = texto;
        }
        public String nombreArchivo { get; set; }
        public String texto { get; set; }

        public String CorregirElementos(String texto)
        {
            String cadenaNueva = texto;
            Utilerias util = new Utilerias();
            cadenaNueva = util.RealizarReemplazos(cadenaNueva);
            return cadenaNueva;
        }

        public String QuitaSaltosVacios(String texto)
        {
            String textoNuevo = String.Empty;
            textoNuevo = texto.Replace(" \r\n\r\n ", "\r\n");
            textoNuevo = textoNuevo.Replace(" \r\n\r\n", "\r\n");
            textoNuevo = textoNuevo.Replace(" INFO", "INFO");
            textoNuevo = textoNuevo.Replace(" INFO ", "INFO|");
            textoNuevo = textoNuevo.Replace("INFO ", "INFO|");
            textoNuevo = textoNuevo.Replace(")\r\n Comprobante", ")|Comprobante");
            textoNuevo = textoNuevo.Replace("ERROR ", "ERROR|");
            textoNuevo = textoNuevo.Replace(" ERROR ", "ERROR|");
            textoNuevo = textoNuevo.Replace(")\r\n The ", ")|The ");
            textoNuevo = textoNuevo.Replace("(Main) Error ", "Error ");
            textoNuevo = textoNuevo.Replace("failed.\nError", "failed. Error");
            textoNuevo = textoNuevo.Replace(")\r\n CRP222", ")|CRP222");
            textoNuevo = textoNuevo.Replace(")\r\n CRP225", ")|CRP225");
            textoNuevo = textoNuevo.Replace("SA DE CV|'", "SA DE CV'");
            textoNuevo = textoNuevo.Replace("rows\r\nORA", "rows ORA");
            textoNuevo = textoNuevo.Replace(")\r\n N", ")|N");
            textoNuevo = textoNuevo.Replace(")\r\nEl", ") El");
            textoNuevo = textoNuevo.Replace(". \r\nN", ". N");
            textoNuevo = textoNuevo.Replace(". \r\n*****",". *****");
            textoNuevo = textoNuevo.Replace("SOLUCION: \r\nUsuario: ", "SOLUCION: Usuario: ");
            textoNuevo = textoNuevo.Replace(". \r\n                 Si", ". Si");
            textoNuevo = textoNuevo.Replace(". \r\nAdministrador: ", ". Administrador: ");
            textoNuevo = textoNuevo.Replace(". \r\n                 Pongase", ". Pongase");
            textoNuevo = textoNuevo.Replace(")\r\n|", ")|");
            textoNuevo = textoNuevo.Replace(")\r\n CFDI33106", ")|CFDI33106");
            textoNuevo = textoNuevo.Replace(")\r\n CFDI33132", ")|CFDI33132");
            textoNuevo = textoNuevo.Replace(")\r\n Excepc", ")|Excepc");
            textoNuevo = textoNuevo.Replace(").\r\nTrace: ", "). Trace: ");
            textoNuevo = textoNuevo.Replace(")\r\n   at", ")   at");
            textoNuevo = textoNuevo.Replace(")\r\n El ", ") El ");
            textoNuevo = textoNuevo.Replace("posible \r\nduplicar", "posible duplicar");
            textoNuevo = textoNuevo.Replace(")\r\nInnerError: ", ") InnerError: ");
            textoNuevo = textoNuevo.Replace("adecuada\r\nReference ", "adecuada Reference ");
            textoNuevo = textoNuevo.Replace(")\r\n CFDI33107", ")|CFDI33107");
            textoNuevo = textoNuevo.Replace(")\r\n El", ")|El");
            textoNuevo = textoNuevo.Replace(" \r\nduplicar", " duplicar");
            textoNuevo = textoNuevo.Replace(".\r\nThe ", ". The");
            textoNuevo = textoNuevo.Replace(")\r\n CFDI33107", ")|CFDI33107");
            textoNuevo = textoNuevo.Replace("\r\n","@");
            return textoNuevo;
        }

        public string[] SeparadorInicial(String texto)
        {
            string[] textoInicial = null;
            textoInicial = texto.Split('@');
            return textoInicial;
        }
    }
}
