﻿using System;

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


            }







        }
    }
}