using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulanullable01
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null; Não roda por conta do valor double não aceitar um valor nulo
            //Nullable<double> x = null; Resolve o problema tornando a variavel x opcional
            //Porém a melhor forma de representar é:

            double? x = null;
            double? y = 10.0;

            //métodos do nullable:
            //GetValurOrDefault - se existir um valor, ele imprime, se não tiver valor, ele opta pelo opcional representado, como por exemplo na variavel x, o nulo.
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());



            //HasValue - Diz se existe um valor dentro da variável, null = false, anyother true
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            //Value (lança uma exceção se não houver valor). Mas precia estar na instrução de uma condicional.


            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else { Console.WriteLine("x is null"); }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y is null");
            }



            //Operador de coalescência nula. Colocar o valor de z, que é nullable em w, que não é nullable;

            double? z = null;
            double? w = 10;

            double a = z ?? 5;
            double b = w ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);




            //Um nullable não pode ser atribuído para um struct comum


        }
    }
}
