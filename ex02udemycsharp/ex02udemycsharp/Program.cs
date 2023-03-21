using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02udemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Raio do círculo:");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A = {0}", area.ToString("F4"));
        }
    }
}
