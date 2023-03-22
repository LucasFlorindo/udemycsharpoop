using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 ==0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
