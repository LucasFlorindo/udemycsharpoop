using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04condicionaisudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int inicial = int.Parse(vet[0]);
            int final = int.Parse(vet[1]);

            int duracao;

            if (inicial < final)
            {
                duracao = final - inicial;
            } else
            {
                duracao = 24 + final - inicial;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);

        }
    }
}
