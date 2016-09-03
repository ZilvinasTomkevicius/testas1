using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klases
{
    class Produktai
    {
       public string[] produktuSavybes;
       int produktuKiekis;
    }
    class Mesa : Produktai
    {
       public string kiauliena;
       public string vistiena;
       public string jautiena;
       public string zuvis;
    }
    class Vaisiai : Produktai
    {
        public string[] vaisiai;
    }
    class Darzoves : Produktai
    {
        public string[] darzoves;
    }
    class Riesutai : Produktai
    {
        public string[] riesutai;
    }
    class Uogos : Produktai
    {
        public string[] uogos;
    }
    class Skysciai : Produktai
    {
        public string[] alkoholiniaiGerimai;
        public string[] sultys;
        public string vanduo;
    }
    class GyvuliniaiPRoduktai : Produktai
    {
       public string[] kiausiniai;
        public string pienas;
    }
    class PienoProduktai : GyvuliniaiPRoduktai
    {
        public string suris;
        public string grietine;
        public string[] varskesProduktai;
        public string sviestas;
    }
    class Grudai : Produktai
    {
        public string[] krupos;
        public string miltai;
    }
    class MiltiniaiProduktai : Grudai
    {
        public string duona;
        public string batonas;
    }
    class Pusfabrikaciai : Produktai
    {
        public string koldunai;
        public string makaronai;
    }
}
