using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirminiai_skaiciai_iki_milijono
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            for(int i = 1; i<=x ;i++)
            {
                if (i == 1) Console.WriteLine(i);
                for ( int j = 2; j <= i;j++ )
                {
                    
                    if(i==j) Console.WriteLine(i);
                    if (i % j == 0) break;
                   
                }
                  
            }
             
            Console.ReadKey();
        }
    }
}
