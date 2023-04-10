﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulafuncint
{
    class Program
    {
        static void Main(string[] args)///
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6  = original.Replace('a', 'x');

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: " + original);
            Console.WriteLine("Original com letras maiúsculas(ToUpper): " + s1);
            Console.WriteLine("Original com letras minúsculas(ToLower): " + s2);
            Console.WriteLine("Original removendo espaços em excesso(trim): " + s3);
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LasrIndexOf('bc'): " + n2);
            Console.WriteLine("Substring: " + s4);
            Console.WriteLine("SubString: " + s5);
            Console.WriteLine("Replace('a', 'x')" +s6);
            Console.WriteLine("isnullorempty "+b1);
            Console.WriteLine(b2);
            Console.ReadKey();





        }
    }
}
