using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02forudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;


            for (int i = 1; i <= n; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                if (valores >= 10 && valores <= 20)
                {
                    contIn += 1;
                } else
                {
                    contOut += 1;
                }

            }
            Console.WriteLine(contIn + "in");
            Console.WriteLine(contOut + "out");
        }
    }
}
