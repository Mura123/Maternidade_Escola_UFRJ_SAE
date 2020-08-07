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
using System.Windows.Threading;

namespace Maternidade_Escola_UFRJ_SAE
{
    /// <summary>
    /// Lógica interna para DiagnosticosEIntervencoesPuerpera.xaml
    /// </summary>
    public partial class DiagnosticosEIntervencoes : Window
    {
        #region Gestante
        private string[] Gestante =  {
            "Cólica Uterina",
            "Deambulação prejudicada/Mobilidade física prejudicada",
            "Edema Periférico",
            "Fezes Presente",
            "Gravidez",
            "Hiperglicemia",
            "Hipoglicemia",
            "Pressão Sanguínea Elevada (hipertensão Crônica e Pré-eclampsia leve ou grave)",
            "Risco de Infecção (ruptura pematura de membranas ovulares)",
            "Sangramento Vaginal",
            "Urina Normal",
            "Vômito/ Risco de Vômito "
        };
        #endregion
        #region Puerpera
        private string[] Puerpera = { 
            "Característica do período pós-parto", 
            "Cólica Uterina", 
            "Dor Aguda",
            "Falta de conhecimento sobre cuidados com o recém-nascido", 
            "Ferida cirúrgica limpa (cesareana)",
            "Fezes Presente", 
            "Hiperglicemia", 
            "Hipoglicemia", 
            "Pressão Sanguínea Elevada (hipertensão Crônica e Pré-eclampsia leve ou grave)",
            "Urina Normal"
        };
        #endregion
        #region Recem Nascido
        private string[] RN = {
            "Coto Umbilical",
            "Crescimento e Desenvolvimento do Recém-Nascido ",
            "Fezes Presente",
            "Hipoglicemia",
            "Regurgitação/ Vômitos",
            "Risco de Queda",
            "Urina Normal"
        };
        #endregion


        private DataClass DadosForms { get; set; }
        private ObservableCollection<Diagnostico> diags;

        public DiagnosticosEIntervencoes(DataClass dataClass)
        {
            InitializeComponent();
            diags = new ObservableCollection<Diagnostico>();
            DataContext = diags;
            Lista.ItemsSource = diags;
            DadosForms = dataClass;
            if (dataClass.TipoPaciente == "Gestante")
            {
                Tipo.ItemsSource = Gestante;
            }
            if (dataClass.TipoPaciente == "Puerpera")
            {
                Tipo.ItemsSource = Puerpera;
            }
            if (dataClass.TipoPaciente == "RecemNascido")
            {
                Tipo.ItemsSource = RN;
            }
            Tipo.SelectedIndex = 0;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            diags.Add(new Diagnostico { Tipo = Tipo.Text, IntevencoeseAprazamento = new Dictionary<string, string>() });
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (Lista.SelectedItem != null)
            {
                diags.Remove((Diagnostico)Lista.SelectedItem);
            }
        }

        private void OpenDiagWindow(object sender, MouseButtonEventArgs e)
        {
            if (Lista.SelectedItems != null && Lista.SelectedItems.Count != 0)
            {
                if (((Diagnostico)Lista.SelectedItem).Tipo == "Urina Normal" && (DadosForms.TipoPaciente=="Gestante"|| DadosForms.TipoPaciente == "Puerpera"))
                {
                    Action acao = new Action(()=> { Lista.Items.Refresh(); }) ;
                    UrinaMae Janela = new UrinaMae((Diagnostico)Lista.SelectedItem, acao);
                    JanelaServico.AbreJanela(Janela);                    
                }
            }
        }
    }

}
