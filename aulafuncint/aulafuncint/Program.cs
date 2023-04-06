using System;
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

            Console.WriteLine("Original: " + original);
            Console.WriteLine("Original com letras maiúsculas: "+ s1);
        }
    }
}
