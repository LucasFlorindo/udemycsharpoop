using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ex08condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0;

            if (valor <= 2000)
            {
                imposto = 0;
            } else if  (valor <= 3000)
            {
                imposto = (valor - 2000) * 0.08;
            } else if (valor <= 4500)
            {
                imposto = (valor - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (valor - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
