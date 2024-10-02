using System;

namespace Odev2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Aşağıdaki Bilgileri Giriniz:");

            Console.WriteLine("T.C. Kimlik Numarası:");
            string TCNO = Console.ReadLine();

            Console.WriteLine("Adınız");
            string Ad = Console.ReadLine();

            Console.WriteLine("Soy Adınız:");
            string SoyAd = Console.ReadLine();

            Console.WriteLine("Telefon Numaranız:");
            string Tlf = Console.ReadLine();

            Console.WriteLine("Yaşınız:");
            string Yas = Console.ReadLine();

            Console.WriteLine("İlk Aldığın Ürünün Fiyatı:");
            double fiyat1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("İkinci Aldığın Ürünün Fiyatı:");
            double fiyat2 = Convert.ToInt16(Console.ReadLine());

            double toplam = fiyat1 + fiyat2;
            double puan = toplam * 0.1;

            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine($"{TCNO} TC numaralı {Ad} {SoyAd} isimli kişi için kayıt oluşturulmuştur. Tlf} telefon numarasına bildirim mesajı gönderilmiştir. {toplam} toplam harcama karşılığında kazanılan %10 patika puan miktarı = {puan}  ");








        }




    }







}