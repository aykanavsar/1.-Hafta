using System;
using System.ComponentModel.Design;

namespace MAnav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya MAnavına Hoşgeldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");

            Console.WriteLine("Hangi meyveyi satın almak istersiniz ?");

            string a = Console.ReadLine().ToLower();

            switch (a)
            {
                case "elma":
                    Console.WriteLine("Seçtiniz meyvenin fiyatı: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Seçtiniz meyvenin fiyatı: 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Seçtiniz meyvenin fiyatı: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Seçtiniz meyvenin fiyatı: 3 TL");
                    break;
                default:
                    Console.WriteLine("Seçtiniz meyvenin fiyatı: 4 TL");
                    break;

                    // Kesinlikle Switch ile çözmek daha kolay. Switch çözümünü çalıştırmak için üst tarafı yorumlayı, aşağı kısmın yorumlarını siliniz. 
            }







        }
    }
}

//using System;

namespace MAnav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya MAnavına Hoşgeldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");

            Console.WriteLine("Hangi meyveyi satın almak istersiniz ?");

            string a = Console.ReadLine().ToLower();

            if (a == "elma")
            {

                Console.WriteLine("Seçtiniz meyvenin fiyatı: 2 TL");
            }

            else if (a == "armut")
            {
                Console.WriteLine("Seçtiniz meyvenin fiyatı: 2 TL");

            }

            else if (a == "çilek")
            {
                Console.WriteLine("Seçtiniz meyvenin fiyatı: 2 TL");
                ;
            }

            else if (a == "muz")
            {
                Console.WriteLine("Seçtiniz meyvenin fiyatı: 3 TL");

            }

            else
            {
                Console.WriteLine("Seçtiniz meyvenin fiyatı: 4 TL");
            }
}



                    // Kesinlikle Switch ile çözmek daha kolay.








        }
    }
}//