using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Hline2(10, '*'); Console.WriteLine();
            Hline2(10, 'a'); Console.WriteLine();
            Hline2(10, 'b'); Console.WriteLine();
        }
        static void Hline2 (int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c);
        }
        static void Vline(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c); bv .
        }
    }
}
