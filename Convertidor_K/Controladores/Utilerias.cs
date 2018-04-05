using Convertidor_K.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        #region Generación de Hash
        /// <summary>
        /// Genera una cadena MD5 con el texto que se le pasa
        /// </summary>
        /// <param name="texto">texto del que se quiere regresar la cadena MD5</param>
        /// <returns>String</returns>
        public String GenerarCadenaMD5(String texto)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(texto);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        #endregion
    }
}
