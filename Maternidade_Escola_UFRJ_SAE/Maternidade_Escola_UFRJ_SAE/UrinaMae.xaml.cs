using Maternidade_Escola_UFRJ_SAE.Modelo;
using Maternidade_Escola_UFRJ_SAE.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Maternidade_Escola_UFRJ_SAE
{
    /// <summary>
    /// Lógica interna para UrinaMae.xaml
    /// </summary>
    public partial class UrinaMae : Window
    {
        Action Refresca;
        Diagnostico ajustes;
        public UrinaMae(Diagnostico diagnosticos, Action acao)
        {
            InitializeComponent();
            ajustes = diagnosticos;
            Refresca = acao;
            List<CheckBox> Check = FindLogicalChildren<CheckBox>(this).ToList();
            List<TextBox> Praz = FindLogicalChildren<TextBox>(this).ToList();
            for (int i = 0; i < Check.Count; i++)
            {
                if (diagnosticos.IntevencoeseAprazamento.ContainsKey((string)Check[i].Content))
                {
                    Check[i].IsChecked = true;
                    Praz[i].Text = diagnosticos.IntevencoeseAprazamento[(string)Check[i].Content];
                }
            }
        }

        private void Confirmar(object sender, RoutedEventArgs e)
        {

            List<CheckBox> Check = FindLogicalChildren<CheckBox>(this).ToList();
            List<TextBox> Praz = FindLogicalChildren<TextBox>(this).ToList();
            for (int i = 0; i < Check.Count; i++)
            {
                if (Check[i].IsChecked == true)
                {

                    if (!ajustes.IntevencoeseAprazamento.ContainsKey((string)Check[i].Content))
                    {
                        ajustes.IntevencoeseAprazamento.Add((string)Check[i].Content, (string)Praz[i].Text);
                    }
                    else
                    {
                        ajustes.IntevencoeseAprazamento[(string)Check[i].Content] = (string)Praz[i].Text;
                    }
                }
                else
                {
                    if (ajustes.IntevencoeseAprazamento.ContainsKey((string)Check[i].Content))
                    {
                        ajustes.IntevencoeseAprazamento.Remove((string)Check[i].Content);
                    }
                }
            }
            Refresca.Invoke();
        }

        private void ConfirmareFechar(object sender, RoutedEventArgs e)
        {
            Confirmar(sender, e);
            JanelaServico.FechaJanela(this);
        }

        public static IEnumerable<T> FindLogicalChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                foreach (object childObj in LogicalTreeHelper.GetChildren(depObj))
                {
                    DependencyObject child = childObj as DependencyObject;
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }
                    foreach (T childOfChild in FindLogicalChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}
