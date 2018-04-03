using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Convertidor_K.Controladores
{
    class ValidadorController
    {

        public String ValidaEntradaTexto(String inputTexto)
        {
            String textoFormato = null;

            return textoFormato;
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
