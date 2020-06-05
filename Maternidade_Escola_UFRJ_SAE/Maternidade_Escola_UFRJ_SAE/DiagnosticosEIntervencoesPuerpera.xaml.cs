using Maternidade_Escola_UFRJ_SAE.Modelo;
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
    /// Lógica interna para DiagnosticosEIntervencoesPuerpera.xaml
    /// </summary>
    public partial class DiagnosticosEIntervencoesPuerpera : Window
    {
        private DataClass DadosForms { get; set; }
        public DiagnosticosEIntervencoesPuerpera(DataClass dataClass)
        {
            InitializeComponent();
            DadosForms = dataClass;
        }
    }
}
