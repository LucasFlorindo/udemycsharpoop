using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04udemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Número do funcionário: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto recebe por hora: ");
            double valor = double.Parse(Console.ReadLine());

            double salario = horas * valor;

            Console.WriteLine("NUMBER = {0}", num);
            Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2"));

        }
    }
}
