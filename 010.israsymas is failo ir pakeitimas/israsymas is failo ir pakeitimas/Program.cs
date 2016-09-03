using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace israsymas_is_failo_ir_pakeitimas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zodis = File.ReadAllLines("informacija.txt");
            int duomenuKiekis = 0;
            int a = 0;
            foreach (string line in zodis)
            {
                Console.WriteLine(line);
                duomenuKiekis++;
            }
            while (a != duomenuKiekis)
            {
                Console.WriteLine("ar norite ka nors pakeisti?(taip/ne)");
                string atsakymas = Console.ReadLine();
                if (atsakymas == "taip") Console.WriteLine("nurodykite numeri objekto, kuri norite pakeisti");
                if (atsakymas == "ne") break;
                int numeris = int.Parse(Console.ReadLine());
                Console.WriteLine("iveskite duomenis, kurie bus pakeisti numeriui {0}, taip pat pries tai iveskite objekto numeri ({0}.)", numeris);
                string duomenys = Console.ReadLine();
                string reikZodis = ".";
                for (int i = numeris -1; i <= numeris -1; i++)
                {
                    string simbolis = Convert.ToString(numeris);
                    if (zodis[i].Contains(simbolis))
                    {
                        zodis[i] = reikZodis;
                    }
                    zodis[i] = zodis[i].Replace(reikZodis, duomenys);
                }
                a++;
            }
            for(int i = 0;i<=duomenuKiekis-1;i++)
            {
                Console.WriteLine(zodis[i]);
            }
            Console.ReadLine();
        }
    }
}
