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
            char raides;
            for (byte i = 0; i <= 255; i++)
            {
                raides = Convert.ToChar(i);
                Console.WriteLine(i +" "+ raides);
                if (i == 255) break;
            }
            Console.ReadKey();
        }
    }
}
