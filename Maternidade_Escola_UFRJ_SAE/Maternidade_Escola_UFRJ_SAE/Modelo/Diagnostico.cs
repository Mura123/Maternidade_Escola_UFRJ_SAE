using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maternidade_Escola_UFRJ_SAE.Modelo
{
    public class Diagnostico
    {
        public string Tipo { get; set; }

        public Dictionary<string,string> IntevencoeseAprazamento { get; set;}

        public string Especificacoes { get; set; }

        public Dictionary<string,string> EspecificacoesTextuais { get; set; }
    }
}
