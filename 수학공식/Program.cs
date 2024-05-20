
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학공식;
internal class TesT
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();

        int a = 1;
        int b = 1;
        int c = 1;
        int d = 1;

        for (int i = 0; i < int.Parse(num); i++)
        {
            d = a + b + c;
            a = b;
            b = c;
            c = d;

            Console.WriteLine(c + " ");
        }
    }
}