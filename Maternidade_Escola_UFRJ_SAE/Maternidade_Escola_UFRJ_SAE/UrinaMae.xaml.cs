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
        Diagnostico ajustes;
        public UrinaMae(Diagnostico diagnosticos)
        {
            InitializeComponent();
            ajustes = diagnosticos;
            var Check = FindLogicalChildren<CheckBox>(this);
            var Praz = FindLogicalChildren<TextBox>(this);
            for (int i = 0; i < Check.Count(); i++)
            {
                if (diagnosticos.IntevencoeseAprazamento.ContainsKey((string)Check.ElementAt(i).Content))
                {
                    Check.ElementAt(i).IsChecked = true;
                    Praz.ElementAt(i).Text = diagnosticos.IntevencoeseAprazamento[(string)Check.ElementAt(i).Content];
                }
            }
        }

        private void Confirmar(object sender, RoutedEventArgs e)
        {

            var Check = FindLogicalChildren<CheckBox>(this);
            var Praz = FindLogicalChildren<TextBox>(this);
            for (int i = 0; i < Check.Count(); i++)
            {
                if (Check.ElementAt(i).IsChecked == true)
                {

                    if (!ajustes.IntevencoeseAprazamento.ContainsKey((string)Check.ElementAt(i).Content))
                    {
                        ajustes.IntevencoeseAprazamento.Add((string)Check.ElementAt(i).Content, (string)Praz.ElementAt(i).Text);
                    }
                    else
                    {
                        ajustes.IntevencoeseAprazamento[(string)Check.ElementAt(i).Content] = (string)Praz.ElementAt(i).Text;
                    }
                }
            }
        }

        private void ConfirmareFechar(object sender, RoutedEventArgs e)
        {
            var Check = FindLogicalChildren<CheckBox>(this);
            var Praz = FindLogicalChildren<TextBox>(this);
            for (int i = 0; i < Check.Count(); i++)
            {
                if (Check.ElementAt(i).IsChecked == true)
                {

                    if (!ajustes.IntevencoeseAprazamento.ContainsKey((string)Check.ElementAt(i).Content))
                    {
                        ajustes.IntevencoeseAprazamento.Add((string)Check.ElementAt(i).Content, (string)Praz.ElementAt(i).Text);
                    }
                    else
                    {
                        ajustes.IntevencoeseAprazamento[(string)Check.ElementAt(i).Content] = (string)Praz.ElementAt(i).Text;
                    }
                }
            }
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
