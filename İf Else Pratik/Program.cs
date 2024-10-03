using System;

namespace İfelsepratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi > 10)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Sayı 10 dan büyüktür.");
                    Console.WriteLine("Sayı çifttir.");

                }
                else
                {
                    Console.WriteLine("Sayı 10' dan büyüktür.");
                    Console.WriteLine("Sayı Tektir.");

                }
            }
            else if (sayi < 10)
            {

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Sayı 10' dan küçüktür");
                    Console.WriteLine("Sayı Çifttir");

                }
                else
                {
                    Console.WriteLine("Sayı 10' dan küçüktür.");
                    Console.WriteLine("Sayı tektir.");
                }
            }

            else
            {
                Console.WriteLine("Sayı 10'a eşittir.");
                Console.WriteLine("Sayı çifttir.");
            }



                    
 
            


          

              




            



        }
    }
}