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
            Console.WriteLine("iveskite sakini");
            string sakinys = Console.ReadLine();
            int balsiuSkaicius = 0;
            // siuos masyvus apsirasiau is pradziu, bet po to ju neprireike
           // char[] balsiuArry = { 'a', 'e', 'i', 'y', 'o', 'u', };
           // char[] priebalsiuArry = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'z' };
           // char[] skyrZenklArry = { ',', '.', ':', ';', '-' };
            int sakinioIlgis = sakinys.Length;
            // sis foreach ciklas suskaiciuoja visas balses
            foreach(char balsiai in sakinys)
            {
                if (balsiai == 'a') balsiuSkaicius++;
                if (balsiai == 'e') balsiuSkaicius++;
                if (balsiai == 'i') balsiuSkaicius++;
                if (balsiai == 'y') balsiuSkaicius++;
                if (balsiai == 'o') balsiuSkaicius++;
                if (balsiai == 'u') balsiuSkaicius++;
            }
            Console.WriteLine("balsiu sakinyje yra {0}", balsiuSkaicius);
            Console.ReadLine();
        }
    }
}
