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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maternidade_Escola_UFRJ_SAE
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AbreCabecalho(object sender, RoutedEventArgs e)
        {
            string tipoPaciente = "";
            if (Gestante.IsChecked == true)
            {
                tipoPaciente = Gestante.Name;
            }
            else if (Puerpera.IsChecked == true)
            {
                tipoPaciente = Puerpera.Name;
            }
            else if (RecemNascido.IsChecked == true)
            {
                tipoPaciente = RecemNascido.Name;
            }
            else
            {
                MessageBox.Show("Por favor, marque uma opção antes de prosseguir.");
            }

            if (!string.IsNullOrEmpty(tipoPaciente))
            {
                Cabecalho cabecalho = new Cabecalho(tipoPaciente);
                cabecalho.Show();
            }
        }
    }
}
