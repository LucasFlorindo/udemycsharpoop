﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaMatrix01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.Length);
        }
    }
}
