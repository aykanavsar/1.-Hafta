using System;
using System.ComponentModel.Design;

namespace Kimmilyonerolmakister
{
    class progra
    {
        private static readonly string a;

        static void Main(string[] args)
        {
                       
            Console.WriteLine(" Sıfırı ilk defa kim kullanan hangisidir ?");
            Console.WriteLine("a) Harzemi b)El Battani");
            string kx = Console.ReadLine().ToLower();
            int x;
            int y;
            int z;


            bool ilksorudogrumi = (kx == "a");
            if (ilksorudogrumi)
            {
                Console.WriteLine("Tebrikler Cevabınız Doğru");
                x = 1;

            }

            else
            {
                Console.WriteLine("Malesef Yanlış Cevap Verdiniz");
                x = 0;
            }

            Console.WriteLine(" Dünya' ya en yakın gezegen hangisidir ?");
            Console.WriteLine("a) Mars b)Venüs");
            string ky = Console.ReadLine().ToLower();

            bool ikincisorudogrumi = (ky == "a");
            if (ikincisorudogrumi)
            {
                Console.WriteLine("Tebrikler Cevabınız Doğru");
                y = 1;
            
            }
            else
            {
                Console.WriteLine("Malesef Yanlış Cevap Verdibiz");
                y = 0;
            }

            if ((x + y) > 0)
            {
                if (x + y == 2)
                {
                    Console.WriteLine("Tebrikler 1 Milyon TL Kazandınız");

                }
                else if (x + y == 1)
                {
                    Console.WriteLine("3. Soruya Doğru Cevap Verirseniz 1 Milyon TL Kazanacaksınız");
                    Console.WriteLine("En kalabalık ülke hangisidir ?");
                    Console.WriteLine("a) Çin  b) Hindistan");
                    string kz = Console.ReadLine();
                    if (kz == "b")
                    {
                        Console.WriteLine("Tebrikler Bu Doğru Cevapla 1 Milyon TL Kazandınız");
                    }
                    else
                    {
                        Console.WriteLine("Malesef Yanlış Cevap Büyük Ödülü Kaybettiniz.");
                    }

                }


            }
            else
            {
                Console.WriteLine("Malesef Yanlış Cevap Büyük Ödülü Kaybettiniz.");
            }
        
    
            


















        }
    }
}