using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_desmtaines_i_dvejetaine
{
    class Program
    {
        static void Main(string[] args)
        {
            //ivedus skaiciu, programa ji perskaiciuoja is desimtaines skaic. sistemos i dvejetaine
            Console.WriteLine("iveskite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            bool  dvejetaine;
            while(skaicius !=0)
            {
                if (skaicius % 2 == 0)
                {
                    dvejetaine = false;
                    int nulis = Convert.ToInt32(dvejetaine);
                    Console.Write(nulis);                                                       
                }

                else
                {
                    dvejetaine = true;
                    int vienetas = Convert.ToInt32(dvejetaine);
                    Console.Write(vienetas);                                       
                }
               skaicius = skaicius / 2;
            }
            Console.WriteLine("(skaityti is desines, nes apsukti dar nepavyko)");
            Console.ReadLine();
            

                


        }
    }
}
