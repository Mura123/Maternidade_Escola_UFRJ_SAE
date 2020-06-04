using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maternidade_Escola_UFRJ_SAE.Modelo
{
    public class DataClass
    {
        public string TipoPaciente { get; set; }

        public string Nome { get; set; }

        public string Registro { get; set; }

        public string Leito { get; set; }

        public System.DateTime? Data { get; set; }

        public string Tipo  { get; set; }

        public DataClass(string tipoPaciente)
        {
            TipoPaciente = tipoPaciente;
        }
    }
}
