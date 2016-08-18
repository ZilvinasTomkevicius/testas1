using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktaiIrJuSkaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            int produktuSkaicius = 0;
            Console.WriteLine("iveskite produktus");
            string produktai = Console.ReadLine();
                foreach(char kablelis in produktai)
                if(kablelis == ',') produktuSkaicius ++;
            produktuSkaicius += 1;
            Console.WriteLine("ivesti prduktai: " + produktai + ". ju skaicius: " + produktuSkaicius);
            Console.ReadKey();
        }
    }
}
