using Maternidade_Escola_UFRJ_SAE.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Maternidade_Escola_UFRJ_SAE.Servicos;

namespace Maternidade_Escola_UFRJ_SAE
{
    /// <summary>
    /// Lógica interna para DiagnosticosEIntervencoesPuerpera.xaml
    /// </summary>
    public partial class DiagnosticosEIntervencoesPuerpera : Window
    {
        private DataClass DadosForms { get; set; }
        private ObservableCollection<Diagnostico> diags;

        public DiagnosticosEIntervencoesPuerpera(DataClass dataClass)
        {
            InitializeComponent();
            diags= new ObservableCollection<Diagnostico>();
            DataContext = diags;
            Lista.ItemsSource = diags;
            DadosForms = dataClass;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            diags.Add(new Diagnostico { Tipo = Tipo.Text});
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if(Lista.SelectedItem!=null)
            {
                diags.Remove((Diagnostico)Lista.SelectedItem);
            }
        }

        private void OpenDiagWindow(object sender, MouseButtonEventArgs e)
        {
            if(Lista.SelectedItems!=null && Lista.SelectedItems.Count!=0)
            {
                MensagemServico.MostraMensagem("Click duplo no" + ((Diagnostico)Lista.SelectedItem).Tipo);
            }
        }
    }

}
