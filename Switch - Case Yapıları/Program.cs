int gun = 3;
switch (gun)
{
    case 1:
        Console.WriteLine("pazartesi");
    break;

    case 2:
        Console.WriteLine("Salı");
    break;

    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break; 
    default:
        Console.WriteLine("Geçersiz gün");
        break;
            
}

enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar

        //Enum' a tekrardan bak.Enumlar 0 dan başlar. Ama değiştirmek istersen Pazartesi = 1 yazarsan başlangıç 1 olur devam eder. 
}