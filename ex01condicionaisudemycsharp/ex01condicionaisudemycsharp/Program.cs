using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if(x < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
