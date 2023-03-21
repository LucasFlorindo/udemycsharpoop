using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ex05udemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(vet[0]);
            double numeroPeca1 = double.Parse(vet[1]);
            double valorPeca1 = double.Parse(vet[2]);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vet2[0]);
            double numeroPeca2 = double.Parse(vet2[1]);
            double valorPeca2 = double.Parse(vet2[2]);

            double pagar = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

            Console.WriteLine("VALOR A PAGAR: R${0}", pagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
