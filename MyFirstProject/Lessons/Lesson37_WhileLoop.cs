namespace MyFirstProject.Lessons
{
    public static class Lesson37_WhileLoop
    {
        public static void Run()
        {
            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int a = 0;
            // while(a <= 10)
            // {
            //     Console.WriteLine(a);
            //     a ++;
            // };

            // string[] names = {"ali","veli","ahmet"};

            // int b = 0;

            // while (b < names.Length)
            // {
            //     Console.WriteLine(names[b]);
            //     b++;
            // }

            // char option = 'e';
            // int counter = 1;
            // int sum = 0;

            // while (option == 'e')
            // {
            //     Console.Write($"{counter}. sayı: ");
            //     sum += Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Devam Etmek İstiyor Musunuz?(e/h): ");
            //     option = Convert.ToChar(Console.ReadLine());

            //     counter ++;
            // }
            // Console.WriteLine($"{counter-1} adet sayının toplamı: {sum}");

            //? Görev 1: Kullanıcı sayı girsin, 0 girene kadar devam etsin. Toplamı yazdır

            // int exit = 1;
            // int sum = 0;

            // while (exit != 0)
            // {
            //     Console.Write("Sayı Giriniz: ");
            //     int number = Convert.ToInt32(Console.ReadLine());
            //     exit = number;
            //     sum += number;
            // }
            // Console.WriteLine(sum);

            //? Görev 2 (Unity Mantığı 🎮) Karakter canı: 100 Random hasar ver Can 0 olana kadar while ile devam et

            // int health = 100;
            // Console.WriteLine($"Başlangıç Canı: {health}");
            // var rnd = new Random();
            // int count = 0;

            // while (health > 0)
            // {   
            //     count ++;
            //     int damage = rnd.Next(101);
            //     health -= damage;
            //     Console.WriteLine(
            //         $"""
            //         {count}. Tur
            //         Alınan Hasar: {damage}
            //         Kalan Can: {(health < 0 ? 0 : health)}
            //         """
            //     );
            // }
            // Console.WriteLine("Kaybettiniz");

            //? Görev 3 (Bir Tık Zor): Kullanıcıdan sayı al Negatif girene kadar devam et Girilen en büyük sayıyı bul

            
            // int number = 0;
            // int maxNumber = 0;
            
            // while (number >= 0)
            // {
            //     Console.Write("Bir Sayı Giriniz: ");
            //     number = Convert.ToInt32(Console.ReadLine());
            
            //     if (number > maxNumber)
            //     {
            //         maxNumber = number;
            //     }
                
            // }
            // Console.WriteLine($"Girilen En Büyük Sayı: {maxNumber}");

            //? Görev 4: Bir Sonraki Seviye: Girilen: → en büyük → en küçük → ortalama 👉 Tek while içinde çöz

            int number;
            int minNumber = 100000;
            int maxNumber = 0;
            int sum = 0;
            int counter = 0;
            

            while (true)
            {
                Console.Write("Bir Sayı Giriniz (Çıkış İçin Negatif Değer): ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0) break;
                sum += number;
                counter ++;
                if (number < minNumber) minNumber = number;
                else if (number > maxNumber) maxNumber = number;
            }

            double avgNumber = (double)sum / counter;

            Console.WriteLine(
                $"""
                Girilen Sayı: {counter}
                En Küçük Sayı: {minNumber}
                Ortalama: {avgNumber}
                En Büyük Sayı: {maxNumber}
                """
            );
        }
    }
}