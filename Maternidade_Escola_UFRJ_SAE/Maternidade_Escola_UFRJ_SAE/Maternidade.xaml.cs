﻿using Maternidade_Escola_UFRJ_SAE.Modelo;
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
                DataClass DadosForms = new DataClass(tipoPaciente);
                Cabecalho cabecalho = new Cabecalho(DadosForms);
                JanelaServico.AbreJanela(cabecalho);
            }
        }

        private void JanelaPrincipalFechada(object sender, EventArgs e)
        {
            JanelaServico.FechaTudo();
        }
    }
}
