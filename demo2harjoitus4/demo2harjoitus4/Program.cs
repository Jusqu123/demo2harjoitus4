
// Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna ikasi");
            luku = int.Parse(Console.ReadLine());
            if (luku < 18)
                Console.WriteLine("alaikainen");

            else if (luku >= 18 && luku <= 65)
                Console.WriteLine("aikuinen");

            else if (luku >= 65)
                Console.WriteLine("seniori");
        }
    }
}
