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
    /// Lógica interna para Diagnosticos.xaml
    /// </summary>
    public partial class Diagnosticos : Window
    {

        public DataClass DadosForms { get; set; }
        public Diagnosticos(DataClass dadosForms)
        {
            InitializeComponent();

            DadosForms = dadosForms;

            Teste.Content = DadosForms.Nome + " Registro: " + DadosForms.Registro +"\nTipo de Paciente: " + DadosForms.TipoPaciente;
        }
    }
}
