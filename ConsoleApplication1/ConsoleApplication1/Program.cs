using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine(10, '*'); Console.WriteLine();

        }
        static void HLine (int n )
        {
            for( int i = 0; i< n ; i++)
            Console.WriteLine("*");
        }
    }

    }

