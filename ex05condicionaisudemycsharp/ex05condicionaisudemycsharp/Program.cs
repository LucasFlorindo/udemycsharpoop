using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();

            int codigo = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);

            double total = 0;
            if (codigo == 1)
            {
                total = qtd * 4.00;
            } else if (codigo == 2)
            {
                total = qtd * 4.50;
            } else if (codigo == 3)
            {
                total = qtd * 5.00;
            } else if (codigo == 4)
            {
                total = qtd * 2.00;
            }else if (codigo == 5)
            {
                total = qtd * 1.50;
            } else
            {
                Console.WriteLine("esse código não consta no cardápio. tente algum item de 1 a 5.");
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2",CultureInfo.InvariantCulture ));
        }
    }
}
