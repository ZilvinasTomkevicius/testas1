using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace failoPervadinimas
{
    class Program
    {
        static void Main(string[] args)
            //si programa sukuria .txt faila ivestu parametru pavadinimu. Veliau, failo pavadinima pakeicia kito parametro pavadinimu
            // parametrus galima ivesti: Properties>Debug>Start Project>Command line arguments
        {
            Console.WriteLine("parametrai yra: 1 {0} ir 2 {1} \nprograma sukure .txt faila 1-uoju parametro pavadinimu", args[0], args[1]);

            DateTime now = DateTime.Now; //uzfiksuojame dabartine data ir dabartini laika

            string message = "execute time: " + now;                      

            File.WriteAllText(args[0], message); //sukuriame .txt faila

            Console.WriteLine("Paspaudus bet kuri mygtuka, programa pakeis .txt failo pavadinima 2-uoju parametro pavadinimu");

            Console.ReadLine();

            File.Move(args[0], args[1]); //pakeiciame .txt failo pavadinima  
        }
    }
}
