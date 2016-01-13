//Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä. 
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




            Console.Write("montako sekuntia muutetaan");
           int luku = int.Parse(Console.ReadLine());
         
            int luku1 = luku / 3600;
   
            int luku2 = (luku- luku1*3600)/60;
     
            int luku3 = (luku-luku1*3600 -luku2*60);


            Console.WriteLine("tunnit : ");
            Console.WriteLine(luku1);
            Console.WriteLine("minuutit : ");
            Console.WriteLine(luku2);
            Console.WriteLine("sekuntit : ");
            Console.WriteLine(luku3);
        }
    }
}
