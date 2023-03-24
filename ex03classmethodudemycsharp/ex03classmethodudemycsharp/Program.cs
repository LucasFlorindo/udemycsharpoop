using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex03classmethodudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            a.Nota1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            a.Nota2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            a.Nota3 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Resultado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
            }

        }
    }
}
