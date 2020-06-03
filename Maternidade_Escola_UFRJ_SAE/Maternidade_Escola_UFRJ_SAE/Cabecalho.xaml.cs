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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Cabecalho : Window
    {
        public string TipoPaciente { get; set; }
        public Cabecalho(string tipoPaciente)
        {
            InitializeComponent();

            TipoPaciente = tipoPaciente;
        }

        private void AbrirDiagnosticosEIntervencoes(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Nome: "+Nome.Text+"\n"+
                "Registro: "+Registro.Text+"\n"+
                "Leito: "+Leito.Text+"\n"+
                "Data: "+Data.SelectedDate+"\n"+
                "Tipo: "+Tipo.Text);
        }
    }
}
