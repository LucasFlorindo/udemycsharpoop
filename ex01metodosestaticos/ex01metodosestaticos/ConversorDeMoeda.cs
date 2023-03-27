using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01metodosestaticos
{
    class ConversorDeMoeda
    {

        public static double Iof = 6.0;
        public static double PrecoReal(double qtd,double dolar)
        {
            double total = qtd * dolar;
            return total + total * Iof / 100;
        }
    }
}
