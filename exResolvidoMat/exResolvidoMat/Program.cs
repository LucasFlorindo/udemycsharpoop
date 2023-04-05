using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exResolvidoMat
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz de ordem N = matriz quadratica

            //Programa recebe a construção da amtriz pelo usuário, ex "3"
            // Programa recebe os dados da matriz pelo usuário
            //  Programa recebe os dados da diagonal e mostra quantos números negativos aparecem.


            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }


            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
        }



    }
}
