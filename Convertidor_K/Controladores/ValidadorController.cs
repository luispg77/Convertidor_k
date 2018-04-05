using Convertidor_K.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Convertidor_K.Controladores
{
    class ValidadorController
    {

        public String ValidaEntradaTexto(RichTextBox tcbInputTexto)
        {
            String textoDarFormato = tcbInputTexto.Text;

            textoDarFormato = textoDarFormato.Replace("\n", "\\r\\n");
            textoDarFormato = textoDarFormato.Replace(Environment.NewLine, "\\r\\n");

            return textoDarFormato;
        }

        public bool ValidaInputNullo(RichTextBox tcbInputTexto)
        {
            if(tcbInputTexto.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        public bool ValidaEntidadArchivo(ArchivoValidacion nuevaValidacion, List<ArchivoValidacion> listaValidaciones)
        {
            Utilerias utileria = new Utilerias();
            String md5Compara = String.Empty;
            foreach(ArchivoValidacion ar in listaValidaciones)
            {
                md5Compara = utileria.GenerarCadenaMD5(ar.origen+ar.reemplazo);
                if (md5Compara.Equals(utileria.GenerarCadenaMD5(nuevaValidacion.origen+nuevaValidacion.reemplazo)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
