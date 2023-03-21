using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06udemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            double triangulo = (a * c) / 2;
            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3"));

            double circulo = 3.14159 * Math.Pow(c, 2);
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3"));

            double trapezio = ((a + b) * c) / 2;
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3"));

            double quadrado = Math.Pow(b, 2);
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3"));

            double retangulo = a * b;
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3"));



        }
    }
}
