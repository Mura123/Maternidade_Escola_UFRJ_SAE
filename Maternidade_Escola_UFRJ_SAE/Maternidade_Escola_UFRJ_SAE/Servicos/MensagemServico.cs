using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Maternidade_Escola_UFRJ_SAE.Servicos
{
    public static class MensagemServico
    {
        public static void MostraMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
    }
}
