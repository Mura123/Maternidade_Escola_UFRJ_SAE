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
            string paciente = "";
            if (Gestante.IsChecked == true)
            {
                paciente = "gestante";
            }
            else if (Puerpera.IsChecked == true)
            {
                paciente = "puerpera";
            }
            else if (RecemNascido.IsChecked == true)
            {
                paciente = RecemNascido.Name;
            }
            else
            {
                MessageBox.Show("Por favor, marque uma opção antes de prosseguir.");
            }

            if (!string.IsNullOrEmpty(paciente))
            {
                Cabecalho cabecalho = new Cabecalho(paciente);
                cabecalho.Show();
                this.Close();
            }
        }
    }
}
