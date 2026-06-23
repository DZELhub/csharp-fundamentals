namespace MyFirstProject.Lessons
{
    public static class Lesson33_SwitchCase
    {
        public static void Run()
        {
            // int day = (int)DateTime.Now.DayOfWeek; //* 0 → pazar, 1 → ptesi, ... , 6 → ctesi

            // switch (day)
            // {
            //     case 0:
            //         Console.WriteLine("pazar");
            //         break;
            //     case 1:
            //         Console.WriteLine("pazartesi");
            //         break;
            //     case 2:
            //         Console.WriteLine("salı");
            //         break;
            //     case 3:
            //         Console.WriteLine("çarşamba");
            //         break;
            //     case 4:
            //         Console.WriteLine("perşembe");
            //         break;
            //     case 5:
            //         Console.WriteLine("cuma");
            //         break;
            //     case 6:
            //         Console.WriteLine("cumartesi");
            //         break;
            //     default:
            //         Console.WriteLine("Hatalı Gün");
            //         break;
            // }

            // int month = (int)DateTime.Now.Month;

            // switch (month)
            // {
            //     case 1:
            //         Console.WriteLine("Ocak");
            //         break;
            //     case 2:
            //         Console.WriteLine("Şubat");
            //         break;
            //     case 3:
            //         Console.WriteLine("Mart");
            //         break;
            //     case 4:
            //         Console.WriteLine("Nisan");
            //         break;
            //     case 5:
            //         Console.WriteLine("Mayıs");
            //         break;
            //     case 6:
            //         Console.WriteLine("Haziran");
            //         break;
            //     case 7:
            //         Console.WriteLine("Temmuz");
            //         break;
            //     case 8:
            //         Console.WriteLine("Ağustos");
            //         break;
            //     case 9:
            //         Console.WriteLine("Eylül");
            //         break;
            //     case 10:
            //         Console.WriteLine("Ekim");
            //         break;
            //     case 11:
            //         Console.WriteLine("Kasım");
            //         break;
            //     case 12:
            //         Console.WriteLine("Aralık");
            //         break;
            // }

            // int month = (int)DateTime.Now.Month;

            // switch (month)
            // {
            //     case 12:
            //     case 1:
            //     case 2:
            //         Console.WriteLine("Winter");
            //         break;
            //     case 3:
            //     case 4:
            //     case 5:
            //         Console.WriteLine("Spring");
            //         break;
            //     case 6:
            //     case 7:
            //     case 8:
            //         Console.WriteLine("Summer");
            //         break;
            //     case 9:
            //     case 10:
            //     case 11:
            //         Console.WriteLine("Autumn");
            //         break;
            // }

            //? Mini Challenge 1 🚀 Kullanıcıdan bir sayı al. 1 → Pazartesi 2 → Salı 3 → Çarşamba 4 → Perşembe 5 → Cuma 6 → Cumartesi 7 → Pazar. Switch kullanarak günü yazdır.

            // Console.Write("Bir Sayı Giriniz(1-7): ");
            // int numberOfDay = Convert.ToInt32(Console.ReadLine());

            // string dayOfWeek = numberOfDay == 1 ? "Pazartesi" : numberOfDay == 2 ? "Salı" : numberOfDay == 3 ? "Çarşamba" : numberOfDay == 4 ? "Perşembe" : numberOfDay == 5 ? "Cuma" : numberOfDay == 6 ? "Cumartesi" : numberOfDay == 7 ? "Pazar" : "Hatalı Giriş";

            // switch (numberOfDay)
            // {
            //     case 1:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     case 2:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     case 3:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     case 4:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     case 5:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     case 6:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     case 7:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            //     default:
            //         Console.WriteLine(dayOfWeek);
            //         break;
            // }

            //? Mini Challenge 2 🚀 Kullanıcıdan bir işlem seçmesini iste: 1 → Toplama 2 → Çıkarma 3 → Çarpma 4 → Bölme Sonra iki sayı al. Switch kullanarak işlemi gerçekleştir.

            // Console.Write(
            // """
            // 1 → Toplama
            // 2 → Çıkarma
            // 3 → Çarpma
            // 4 → Bölme
            // Lütfen Bir İşlem Numarası Giriniz: 
            // """
            // );
            // int number = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Bir Sayı Giriniz: ");
            // int number1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Bir Sayı Daha Giriniz: ");
            // int number2 = Convert.ToInt32(Console.ReadLine());

            // int result;

            // string message = 
            // $"""
            // İşlem: {number}
            // Sayı 1: {number1}
            // Sayı 2: {number2}
            // """;

            // switch (number)
            // {
            //     case 1:
            //         result = number1 + number2;
            //         Console.WriteLine(
            //             $"""
            //             {message}
            //             Sonuç: {result}
            //             """
            //         );
            //         break;
            //     case 2:
            //         result = number1 - number2;
            //         Console.WriteLine(
            //             $"""
            //             {message}
            //             Sonuç: {result}
            //             """
            //         );
            //         break;
            //     case 3:
            //         result = number1 * number2;
            //         Console.WriteLine(
            //             $"""
            //             {message}
            //             Sonuç: {result}
            //             """
            //         );
            //         break;
            //     case 4:
            //         if (number2 == 0)
            //         {
            //             Console.WriteLine("Herhangi bir sayının 0'a bölümü tanımsızdır");
            //         } else
            //         {
            //             result = number1 / number2;
            //            Console.WriteLine(
            //             $"""
            //             {message}
            //             Sonuç: {result}
            //             """
            //         );
            //         }
            //         break;
            //     default:
            //         Console.WriteLine("Hatalı Giriş");
            //         break;
                    
            // }

            //? Ek Task 🎮 (Unity Hazırlığı) Bir RPG karakter sınıfı seçme sistemi yap. Kullanıcıdan: 1 → Warrior 2 → Mage 3 → Archer 4 → Assassin seçmesini iste. Switch ile: Warrior seçildi. Başlangıç Canı: 150 gibi bilgiler yazdır.

            // Console.Write(
            //     """
            //     1 → Warrior
            //     2 → Mage
            //     3 → Archer
            //     4 → Assassin
            //     Bir Karakter Sınıfı Seçiniz: 
            //     """
            // );
            // int numberOfChar = Convert.ToInt32(Console.ReadLine());

            // string character = numberOfChar == 1 ? "Warrior" : numberOfChar == 2 ? "Mage" : numberOfChar == 3 ? "Archer" : numberOfChar == 4 ? "Assassin" : "Hatalı Seçim";
            // int defaultHealth = numberOfChar == 1 ? 150 : numberOfChar == 2 ? 80 : numberOfChar == 3 ? 100 : numberOfChar == 4 ? 90 : 0;
            // string message = 
            //     $"""
            //     {character} seçildi.
            //     Başlangıç Canı: {defaultHealth}
            //     """;

            // Console.WriteLine(message);

            //* Switch İle Çözüm

            // string charType;
            // int health;     

            // switch (numberOfChar)
            // {
            //     case 1:
            //         charType = "Warrior";
            //         health = 150;
            //         Console.WriteLine(
            //             $"""
            //             Karakter: {charType}
            //             Başlangıç Canı: {health}
            //             """
            //         );
            //         break;
            //     case 2:
            //         charType = "Mage";
            //         health = 80;
            //         Console.WriteLine(
            //             $"""
            //             Karakter: {charType}
            //             Başlangıç Canı: {health}
            //             """
            //         );
            //         break;
            //     case 3:
            //         charType = "Archer";
            //         health = 100;
            //         Console.WriteLine(
            //             $"""
            //             Karakter: {charType}
            //             Başlangıç Canı: {health}
            //             """
            //         );
            //         break;
            //     case 4:
            //         charType = "Assassin";
            //         health = 90;
            //         Console.WriteLine(
            //             $"""
            //             Karakter: {charType}
            //             Başlangıç Canı: {health}
            //             """
            //         );
            //         break;
            //     default:
            //         Console.WriteLine("Hatalı Seçim");
            //         break;
            // }

            //? Ek Task 🚀 (Switch'i Pekiştirme) Bir restoran sipariş sistemi yap. Menü: 1 → Hamburger 2 → Pizza 3 → Döner 4 → Tavuk Pilav Fiyatlar: Hamburger   → 250  Pizza → 300 TL Döner → 200 TL Tavuk Pilav → 180 TL Switch kullanarak: Seçilen Ürün: Fiyat: bilgisini yazdır. Bonus 🎯 Sipariş adedini de kullanıcıdan al. Sonuçta: Ürün: Birim Fiyat: Adet: Toplam: hesapla.

            Console.Write(
                """
                1 → Hamburger
                2 → Pizza
                3 → Döner
                4 → Tavuk Pilav
                Bir Menü Seçiniz: 
                """
            );
            int numberOfMenu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen adet giriniz: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity <= 0)
                {
                Console.WriteLine("Geçersiz adet.");
                return;
                }

            string menu = "";
            decimal price = 0;
            

            switch (numberOfMenu)
            {
                case 1:
                    menu = "Hamburger";
                    price = 250;
                    break;
                case 2:
                    menu = "Pizza";
                    price = 300;
                    break;
                case 3:
                    menu = "Döner";
                    price = 200;
                    break;
                case 4:
                    menu = "Tavuk Pilav";
                    price = 180;
                    break;
                default:
                    Console.WriteLine("Hatalı Menü Seçimi");
                    return;
            }
            decimal totalPrice = price * quantity;
            Console.WriteLine(
                $"""
                Menü: {menu}
                Birim Fiyat: {price:C}
                Adet: {quantity}
                Toplam Fiyat: {totalPrice:C}
                """
            );
        }
    }
}