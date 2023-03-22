using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());

            if (x<0 || x > 100)
            {
                Console.WriteLine("Fora de intervalo");
            } else if (x <= 25)
            {
                Console.WriteLine("Intervalo (0,25)");
            } else if (x <= 50)
            {
                Console.WriteLine("Intervalo (25,50)");
            } else if (x <= 75)
            {
                Console.WriteLine("Intervalo (50,75)");
            } else
            {
                Console.WriteLine("Intervalo (75,100)");
            }
            
        }
    }
}
