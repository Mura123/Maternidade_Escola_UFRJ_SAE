using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static System.Collections.Generic.Dictionary<string, string>;

namespace Maternidade_Escola_UFRJ_SAE.Conversores
{
    class ListaParaStringConversor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string colecao = "";
            int i = 0;
            if(value is KeyCollection chaves)
            {
                foreach(var aux in chaves)
                {
                    if(i==0)
                    {
                        colecao += aux;
                        i++;
                    }
                    else
                    {
                        colecao += ", " + aux;
                    }
                }
                return colecao;
            }
            if(value is ValueCollection valores)
            {
                foreach (var aux in valores)
                {
                    if (i == 0)
                    {
                        colecao += aux;
                        i++;
                    }
                    else
                    {
                        colecao += ", " + aux;
                    }
                }
                return colecao;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
