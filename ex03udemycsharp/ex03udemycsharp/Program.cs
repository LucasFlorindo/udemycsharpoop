using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03udemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine("Diferença = {0}", diferenca);
        }
    }
}
