using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03whileudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gas = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while(tipo != 4)
            {
                if (tipo ==1) {
                    alcool += 1;
                } else if (tipo == 2) {
                    gas += 1;
                } else if (tipo == 3) {
                    diesel += 1;
                }

                tipo = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + diesel);


        }
    }
}
