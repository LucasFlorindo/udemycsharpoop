using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exfixMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i<m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j<n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

        }
    }
}
