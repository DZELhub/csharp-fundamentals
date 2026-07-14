namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson36_ForLoopExercise
    {
        public static void Run()
        {
            //? "1-100" arasındaki sayıların toplamı

            // int sum = 0;

            // for (int i = 1; i <= 100; i++)
            // {
            //     sum += i;
            // }
            // Console.WriteLine(sum);

            //? Klavyeden girilen başlangıç ve bitiş değerleri arasındaki sayıların toplamı

            // Console.Write("Başlangıç Değeri Giriniz: ");
            // int startNumber = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Bitiş Değeri Giriniz: ");
            // int endNumber = Convert.ToInt32(Console.ReadLine());

            // int sum = 0;

            // for (int i = startNumber; i <= endNumber; i++)
            // {
            //     sum += i;
            // }
            // Console.WriteLine(sum);

            //? {"ali","veli","mehmet","ahmet","hikmet"} dizisindeki tüm elemanları yazdır

            // string[] names = {"ali","veli","mehmet","ahmet","hikmet"};

            // for (int i = 0; i < names.Length; i++)
            // {
            //     Console.WriteLine(names[i]);
            // }

            //? {1,3,4,34,41,56,89} dizisindeki sayılardan hangileri 3'ün katı?

            // int[] numbers = {1,3,4,34,41,56,89};

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     if (numbers[i] % 3 == 0)
            //     {
            //         Console.WriteLine(numbers[i]);
            //     }
            // }

            //? Görev 1 (Orta Seviye) 1–100 arası: → hem 3’e hem 5’e bölünenleri yazdır

            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         Console.WriteLine(
            //             $"{i} hem 3'e hem 5'e bölünür"
            //         );
            //     }
            // }

            //? Görev 2 (Biraz Zor) Bir dizi: int[] numbers = {10, 25, 33, 47, 50} → en büyük sayıyı bul → en küçük sayıyı bul

            // int[] numbers = {10, 25, 33, 47, 50};

            // int biggest = numbers[0];
            // int smallest = numbers[0];

            // for (int a = 0; a <= numbers.Length -1; a++)
            // {
            //     if (numbers[a] < smallest) {
            //         smallest = numbers[a];
            //     }
            //     if (numbers[a] > biggest)
            //     {
            //         biggest = numbers[a];
            //     }
            // }

            // Console.WriteLine(
            //     $"""
            //     En Büyük: {biggest}
            //     En Küçük: {smallest}
            //     """
            // );

            //? Görev 3 (Unity Mantığı 🎮) 5 düşman var her biri için: → random 10–30 can → ekrana yazdır

            // string[] enemies = {"Enemy 1", "Enemy 2", "Enemy 3", "Enemy 4", "Enemy 5"};
            // var rnd = new Random();

            // for (int i = 0; i <= enemies.Length - 1; i ++)
            // {
            //     int health = rnd.Next(15,31);
            //     Console.WriteLine(
            //         $"""
            //         {enemies[i]} Canı: {health};
            //         """
            //     );
            // }

            //? Mini Upgrade Task: Şunu yap: 5 düşman: → random can → en güçlü düşmanı bul (max HP) → ismini yazdır

              string[] enemies = {"Enemy 1", "Enemy 2", "Enemy 3", "Enemy 4", "Enemy 5"};
              int[] health = new int[5];
              var rnd = new Random();
              int power = 0;
              string powerfull = "";

              for (int i = 0; i <= enemies.Length - 1; i ++)
                {
                    
                    int hp = rnd.Next(10,31);
                    health[i] = hp;
                    Console.WriteLine($"{enemies[i]} → {health[i]} HP");
                    if (health[i] >= power)
                {
                    power = health[i];
                    powerfull = enemies[i];
                }
                }
                Console.WriteLine(
                        $"""
                        En Güçlü Düşman
                        {powerfull}: {power} HP
                        """
                    );
        }
    }
}