﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulafuncint
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");

            Console.WriteLine("Original: " + original);
            Console.WriteLine("Original com letras maiúsculas(ToUpper): " + s1);
            Console.WriteLine("Original com letras minúsculas(ToLower): " + s2);
            Console.WriteLine("Original removendo espaços em excesso(trim): " + s3);
            Console.WriteLine("IndexOf('bc'): " + n1);




        }
    }
}