using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balsiai_priebalsiai_ir_sk_zenklai
{
    class Program
    {
        static void Main(string[] args)
        {
            // si programa suskaiciuoja kiek blasiu, priebalsiu ir skiriamuju zenklu yra sakinyje
            Console.WriteLine("iveskite sakini");
            string sakinys = Console.ReadLine();
            //kintamieji balsiu, priebalsiu ir skiriamuju zenklu kiekiui issaugoti
            int balsiuSkaicius = 0;
            int priebalsiuSkaicius = 0;
            int skirZenklSkaicius = 0;
            //aprasome balsiu, priebalsiu ir skiriamuju zenklu masyvus
            char[] balsiuArry = { 'a', 'e', 'i', 'y', 'o', 'u', };
            char[] priebalsiuArry = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'z' };
            char[] skyrZenklArry = { ',', '.', ':', ';', '-' }; 
            //naudojame foreach cikla ir kas kart aptikus balse, priebalse arba skiriamaji zenkla, padidiname jo skaiciu kiekviename is kintamuju
            foreach(char simbolis in sakinys)
            {
                if (priebalsiuArry.Contains(simbolis)) priebalsiuSkaicius++;
                if (balsiuArry.Contains(simbolis)) balsiuSkaicius++;
                if (skyrZenklArry.Contains(simbolis)) skirZenklSkaicius++;
            }      
            Console.WriteLine("priebalsiu sakinyje yra {0}, balsiu {1}, o skiriamuju zenklu {2}", priebalsiuSkaicius, balsiuSkaicius, skirZenklSkaicius);
            Console.ReadLine();
        }
    }
}
