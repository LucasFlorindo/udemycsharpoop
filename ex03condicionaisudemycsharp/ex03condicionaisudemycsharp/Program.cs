using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao multiplos");
            } else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
