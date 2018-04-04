using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
