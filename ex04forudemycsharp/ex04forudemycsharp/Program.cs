using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04forudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int x = int.Parse(num[0]);
                int y = int.Parse(num[1]);

                if( y==0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
