using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace ex02classudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1, f2;

            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            f1.nome = Console.ReadLine();
            Console.Write("Salário:");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            f2.nome = Console.ReadLine();
            Console.Write("Salário:");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salmedia = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Salário médio: " + salmedia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
