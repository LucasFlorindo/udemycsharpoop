using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulawhileudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          

            while (num >= 0)
            {
                double resultado = Math.Sqrt(num);
                Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número:");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            Console.WriteLine("Número negativo!");
        }
    }
}
