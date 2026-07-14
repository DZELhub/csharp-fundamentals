namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson35_ForLoop
    {
        public static void Run()
        {   
            // for (int i = 1; i <= 100; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //? Görev 1. 1–100 arası: sadece tek sayıları yazdır

            // for (int i = 1; i<=100; i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //? Görev 2. 1–100 arası: sayıların toplamını bul

            // int sum = 0;
            // for (int i = 1; i <= 100; i++)
            // {
            //     sum += i;
            // }
            // Console.WriteLine(sum);

            //? Görev 3 (Unity Mantığı 🎮). int health = 100; 10 tur boyunca: her turda 5 hasar ver, kalan canı yazdır.

            // int health = 100;

            // for (int i = 1; i <= 10; i++)
            // {
            //     health -= 5;
            // }
            // Console.WriteLine(
            //     $"Kalan Can: {health}"
            // );
            
            //? Sonraki Seviye Task: Hasar Sistemi Geliştirme: Başlangıç can: 100 Her tur: random 5–15 hasar Can 0 olunca dur 👉 Random + for + if birleşimi

            int health = 100;
            Console.WriteLine(
                $"Başlangıç Canı: {health}"
            );
           var rnd = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int damage = rnd.Next(5, 16);

                health -= damage;

                Console.WriteLine(
                    $"""
                    {i}. Tur
                    Alınan Hasar: {damage}
                    Kalan Can: {(health <= 0 ? 0 : health)}
                    """
                );

                if (health <= 0)
                {
                    Console.WriteLine("Kaybettiniz...");
                    break;
                }
            }
        }
    }
}