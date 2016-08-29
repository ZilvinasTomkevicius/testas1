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
            int[] teisingiSkaiciai = new int[500];
            int padetis = 0;
            while( skaicius !=0)
            {
                
                if (skaicius % 2 == 0)
                {
                    int nulis = 0;
                    teisingiSkaiciai[padetis] = nulis;                                                   
                }

                else
                {
                    int vienetas = 1;
                    teisingiSkaiciai[padetis] = vienetas;                                                       
                }
               skaicius = skaicius / 2;
               padetis++;
            }
            for (int i = padetis-1; i>=0; i--)
            {
                Console.Write(teisingiSkaiciai[i]);
            }
            Console.ReadLine();
        }
    }
}
