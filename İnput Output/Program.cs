using System;

namespace BasicIOExample
{

    class Program
    {


        static void Main(string[] args)
        {

            string greeting = "Merhaba Dünya";

            Console.WriteLine(greeting);

            int year = 2024;

            Console.WriteLine("Bu yıl" + year + ".");

            Console.WriteLine($"Bu yıl {year} .");

            Console.WriteLine("Adınız");

            string name = Console.ReadLine();
            
            Console.WriteLine("Yaşınız");
            string strage = Console.ReadLine(); 

            Console.WriteLine($"Merhaba {name} {strage} yaşındasınız");
           


        }
   





    }






}