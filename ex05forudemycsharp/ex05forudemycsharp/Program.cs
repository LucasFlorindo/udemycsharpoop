using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05forudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for(int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine(fat);
        }
    }
}
