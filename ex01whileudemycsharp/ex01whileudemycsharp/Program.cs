using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01whileudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso Permitido!");

        }
    }
}
