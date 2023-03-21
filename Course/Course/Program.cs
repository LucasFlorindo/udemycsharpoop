using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é ${1}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é ${1}", produto2, preco2);

            Console.WriteLine("Registro: {0}, código {1} e gêero: {2}", idade, codigo, genero);

            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture:" + medida.ToString("F3", CultureInfo.InvariantCulture));


            double a = 1.0, b = -5.0, c = -3.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = -b + Math.Sqrt(delta) / (2.0 * a);
            double x2 = -b - Math.Sqrt(delta) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);

            string frase = Console.ReadLine();

            string s = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];




        }
    }
}
