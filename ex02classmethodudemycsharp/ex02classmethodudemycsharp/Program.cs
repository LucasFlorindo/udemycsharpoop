using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex02classmethodudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();


            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.Bruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f.Nome, ", $ ", f.SalarioLiquido());

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.Aumento(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados Aualizados: " + f);



        }
    }
}
