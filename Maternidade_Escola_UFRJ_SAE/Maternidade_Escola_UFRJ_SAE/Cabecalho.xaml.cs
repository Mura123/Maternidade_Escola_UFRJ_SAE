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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Cabecalho : Window
    {
        public DataClass DadosForms { get; set; }
        public Cabecalho(DataClass dadosForms)
        {
            InitializeComponent();

            DadosForms = dadosForms;
        }

        private void AbreDiagnosticos(object sender, RoutedEventArgs e)
        {
            DadosForms.Nome = Nome.Text;
            DadosForms.Registro = Registro.Text;
            DadosForms.Leito = Leito.Text;
            DadosForms.Data = Data.SelectedDate;
            DadosForms.Tipo = Tipo.Text;
            DiagnosticosEIntervencoes diag = new DiagnosticosEIntervencoes(DadosForms);
            JanelaServico.AbreJanela(diag);
            JanelaServico.FechaJanela(this);
        }
    }
}
