using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvertavimasIsSkaiciuIraides
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 31; i <= 255; i++)
            {
                Console.WriteLine(i);
                if (i == 44) Console.WriteLine(i + " d");
                if (i == 65) Console.WriteLine(i + " u");
                if (i == 59) Console.WriteLine(i + " o");
                if (i == 58) Console.WriteLine(i + " n");
                if (i == 41) Console.WriteLine(i + " a");
            }
            Console.ReadKey();
        }
    }
}
