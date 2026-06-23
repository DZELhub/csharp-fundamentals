namespace MyFirstProject.Lessons
{
    public static class Lesson38_BreakContinue
    {
        public static void Run()
        {
            // string name = "Celal Selim";

            // for (int i = 0; i < name.Length; i++)
            // {
            //     if (name[i] == ' ') continue;
                
            //     Console.WriteLine(name[i]);
            // }

            // for (int a = 0; a < name.Length; a++)
            // {
            //     if (name[a] == ' ') break;
                
            //     Console.WriteLine(name[a]);
            // }

            // int x = 0;

            // while (x <= 20)
            // {
            //     x++;
            //     if (x % 2 == 1) continue;
            //     Console.WriteLine(x);
                
            // }

            //? Görev 1: 1–100 arası: → 3’e bölünenleri atla (continue) → diğerlerini yazdır

            // int num = 0;

            // while (num <= 99)
            // {
            //     num ++;
            //     if (num % 3 == 0) continue;
            //     Console.WriteLine(num);
            // }

            //? Kullanıcı sayı girsin → 0 girerse break → negatif girerse continue (yok say) → sadece pozitifleri topla

            // int sum = 0;

            // while (true)
            // {
            //     Console.Write("Sayı Giriniz(Çıkış için 0): ");
            //     int number = Convert.ToInt32(Console.ReadLine());
            //     if (number == 0) break;
            //     if (number < 0) continue;
            //     sum += number;
            // }
            // Console.WriteLine(sum);

            //? Görev 3 (Unity Mantığı 🎮) 10 tur: → random damage → eğer dodge olursa continue → can 0 olursa break

            var rnd = new Random();
            int health = 100;
            int count = 0;
            

            while (count <= 10)
            {
                
                int damage = rnd.Next(21);
                health -= damage;
                if (health <= 0) break;
                if (damage == 0) continue;
                count ++;
                Console.WriteLine(
                $"""
                {count}. Tur
                Alınan Hasar: {damage}
                Kalan Can: {health}
                """
            );
            }
        }
    }
}