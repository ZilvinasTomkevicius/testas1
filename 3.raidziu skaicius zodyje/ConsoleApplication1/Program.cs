using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raidziuSkaiciusZodyje
{
    class Program
    {
        static void Main(string[] args)
        {
            // si programa skaiciuoja, kiek yra ivestu raidziu ivestame zodyje
            int raidziuSkaicius = 0;
            Console.WriteLine("iveskite Zodi");
            string zodis = Console.ReadLine();
            Console.WriteLine("iveskite raide");
            string raideKuriaIvedame = Console.ReadLine();                                           
            foreach(char raideKuriosMumsReikia in zodis)
            {
                //konvertuojame is string duom. tipo i char, kad veliau galetume sulyginti
                char raideTampaRaide = Convert.ToChar(raideKuriaIvedame);
                if (raideTampaRaide == raideKuriosMumsReikia) raidziuSkaicius++;
            }
            Console.WriteLine("raidziu skaicius = {0}", raidziuSkaicius);
            Console.ReadKey();
           

        }
    }
}
