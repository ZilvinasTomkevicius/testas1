using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace duom_baze
{
    class Program
    {

        static void Main(string[] args)
        {
            //si programa iraso pateikta informacija i .txt faila
            // sukuriame string tipo masyva su 30 vietu
            string[] asmenuInfo = new string[30];
            int padetis = 0;
            int z = 0;  
            //sukame while cikla nuo vieno iki 30, kadangi masyve yra 30 vietu      
            while(z!=30)
            {
                Console.WriteLine("ar norite pildyti duomenu baze? (taip/ne)");
                string atsakymas2 = Console.ReadLine();
                // pateikiame salyga atsakymui "taip"
                if(atsakymas2 == "taip")
                {
                    Console.WriteLine("iveskite varda, pavarde, tel nr");
                    string asmuo = Console.ReadLine();
                    asmenuInfo[padetis] = asmuo;
                    //kaskart irase duomenis i masyva, paslenkame masyvo vieta per 1
                    padetis++;
                }
                //pateikiame salyga atsakymui "ne"
                if (atsakymas2 == "ne") break;                         
            } 
            //isspausdiname masyvo turini i ekrana  
            for(int i = 0; i <= padetis; i++)
            {
                Console.WriteLine(asmenuInfo[i]);
            }
            //isspausdiname masyvo uzimtu vietu skaiciu
            Console.WriteLine(padetis);
            //nuskaitome masyvo turini i .txt faila, taciau taip neivyksta :(           
            for(int x = 0; x <= padetis; x++)
            {
                using (StreamWriter duomenys = new StreamWriter("asmenys.txt"))
                    duomenys.WriteLine(asmenuInfo[x]);         
            }           
            Console.ReadLine();
        }

    }
}
