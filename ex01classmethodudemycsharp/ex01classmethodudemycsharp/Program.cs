using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01classmethodudemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Escreve a largura e altura do retângulo: ");

            string[] val = Console.ReadLine().Split(' ');
            r.Largura = double.Parse(val[0]);
            r.Altura = double.Parse(val[1]);

            Console.WriteLine("AREA = " +  r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
