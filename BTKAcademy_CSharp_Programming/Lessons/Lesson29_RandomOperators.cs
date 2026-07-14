namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson29_RandomOperators
    {
        public static void Run()
        {
            var rnd = new Random();

            int number = rnd.Next();
            Console.WriteLine(number);

            int number1 = rnd.Next(100);
            Console.WriteLine(number1);

            int number2 = rnd.Next(50, 100);
            Console.WriteLine(number2);

            string[] teams = {"Fenerbahçe", "Galatasaray", "Beşiktaş", "Trabzonspor"};
            var rnd1 = new Random();
            int number3 = rnd1.Next(3);
            Console.WriteLine(teams[number3]);

            //? Mini Challenge 1 🚀 Bir zar simülasyonu yap. Random rnd2 = new(); Kullanarak: 1 ile 6 arasında sayı üret. Sonucu ekrana yazdır

            Random rnd2 = new();

            int dice = rnd2.Next(1,7);

            Console.WriteLine(
                $"Attığınız Zar: {dice}"
            );

            //? Mini Challenge 2 🚀 Bir ödül sistemi yap. string[] rewards = {"Altın", "Elmas", "Kılıç", "Zırh", "İksir"}; Rastgele bir ödül seç.

            Random rnd3 = new();
            string[] rewards = {"Altın", "Elmas", "Kılıç", "Zırh", "İksir"};
            int indexNumber = rnd3.Next(rewards.Length);

            Console.WriteLine(
                $"Ödülünüz: {rewards[indexNumber]}"
            );

            //? Ek Görev (Unity Hazırlığı) 🎮 Bir RPG karakterine rastgele hasar ver: int health = 100; Rastgele: 10 - 30 arası hasar üret. Sonra: health -= damage; yap.
            
            int health = 100;

            Random rnd4 = new();
            int damage = rnd4.Next(10, 31);

            int remainingHealth = health - damage;

            Console.WriteLine(
                $"""
                Karakter {damage} hasar aldı.
                Kalan can: {remainingHealth}
                """
            );

            //? Ek Görev 🚀 (Biraz Daha Gerçekçi) Bir RPG sandığı oluştur: string[] items = { "Kılıç", "Zırh", "Altın", "İksir", "Yüzük" }; Görev: Rastgele bir eşya ver Eğer eşya "Altın" ise 100 altın kazandın yazdır. Eğer eşya "İksir" ise Canın 20 arttı yazdır. Diğer eşyalar için Yeni eşya bulundu: Kılıç şeklinde yazdır.

            Random rnd5 = new();
            string[] items = { "Kılıç", "Zırh", "Altın", "İksir", "Yüzük" };
            int indexNumber1 = rnd5.Next(items.Length);

            if (items[indexNumber1] == "Altın")
            {
                Console.WriteLine($"100 {items[indexNumber1]} kazandın");
            } else if (items[indexNumber1] == "İksir")
            {
                Console.WriteLine($"Canın 20 arttı");
            } else
            {
                Console.WriteLine($"Yeni Eşya Bulundu: {items[indexNumber1]}");
            }

            //? Ek Görev 2 🎮 (Unity Mantığı) int enemyHealth = 100; Rastgele: 15-40 arası hasar vur. Sonra: enemyHealth -= damage; Eğer can: 0 veya altına düşerse Düşman öldü! yazdır. Değilse: Düşmanın kalan canı: X yazdır.

            Random rnd6 = new();
            int enemyHealth = 100;

            while (enemyHealth > 0) {
            
            int damage1 = rnd6.Next(15, 41);
            enemyHealth -= damage1;
            Console.WriteLine($"Vurulan Hasar: {damage1}");

                if (enemyHealth > 0)
                {
                    Console.WriteLine($"Kalan Can: {enemyHealth}");
                }
                else
                {
                    Console.WriteLine("Düşman Öldü!");
                }
            }
        }
    }
}