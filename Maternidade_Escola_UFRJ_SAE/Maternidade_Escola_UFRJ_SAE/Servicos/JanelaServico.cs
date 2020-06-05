using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Maternidade_Escola_UFRJ_SAE.Servicos
{
    public static class JanelaServico
    {
        private static List<Window> listaJanelas = new List<Window>();
        public static void AbreJanela(Window janela)
        {
            janela.Show();

            listaJanelas.Add(janela);
        }

        public static void FechaJanela(Window janela)
        {
            listaJanelas.Remove(janela);
            janela.Close();
        }

        public static void FechaTudo()
        {
            foreach (Window w in listaJanelas)
            {
                try
                {
                    w.Close();
                }
                catch
                {
                    continue;
                }
            }
            listaJanelas.Clear();
        }
    }
}
