namespace MyFirstProject.Lessons
{
    public static class Lesson41_Foreach
    {
        public static void Run()
        {
            // string name = "Celal";
            // for (int i = 0; i < name.Length; i++) {
            // Console.WriteLine(name[i]);}

            // foreach(char letter in name) {
            // Console.WriteLine(letter);}

            // int[] numbers = {10, 20, 40, 45};

            // foreach(int number in numbers) {
            // if (number == 20) continue;
            // Console.WriteLine(number);}

            // foreach(int number in numbers) {
            // if (number == 20) break;
            // Console.WriteLine(number);}

            //? Bir int dizisi oluştur: int[] numbers = {10, 25, 30, 45, 60} → sadece 30’dan büyük sayıları yazdır

            // int[] numbers = {10, 25, 30, 45, 60};

            // foreach (int number in numbers)
            // {
            //     if (number > 30) Console.WriteLine(number);
            // }

            //? Bir string dizisi oluştur: string[] names = {"Ali", "Veli", "Ayşe", "Ahmet"} → sadece "A" ile başlayanları yazdır

            // string[] names = {"Ali", "Veli", "Ayşe", "Ahmet"};

            // foreach (string name in names)
            //     {
            //         if (name.StartsWith("A")) Console.WriteLine(name);
            //     }

            // foreach (string name in names)
            //     {
            //         if (name[0] == 'A') Console.WriteLine(name);
            //     }

            //? int[] numbers = {5, 10, 15, 20, 25} → sadece çift sayıların toplamını bul

            // int[] numbers = {5, 10, 15, 20, 25};
            // int sum = 0;

            // foreach (int number in numbers)
            //     {
            //         if (number % 2 == 0)
            //         {
            //             sum += number;
            //         }
            //     }
            // Console.WriteLine(sum);

            //? int[] numbers = {12, 45, 3, 78, 34} → en küçük sayıyı bul → en büyük sayıyı bul

            // int[] numbers = {12, 45, 3, 78, 34};
            // int maxNumber = 0;
            // int minNumber = 99999;

            // foreach (int number in numbers)
            //     {
            //         if (number > maxNumber)
            //         {
            //             maxNumber = number;
            //         }
            //         if (number < minNumber)
            //         {
            //             minNumber = number;
            //         }
            //     }
            //     Console.WriteLine(maxNumber);
            //     Console.WriteLine(minNumber);

            //? string[] enemies = {"Goblin", "Orc", "Troll"} → her düşman için: "X saldırıya uğradı!" yazdır

            // string[] enemies = {"Goblin", "Orc", "Troll"};

            // foreach (string enemy in enemies)
            //     {
            //         Console.WriteLine();
            //     }

            //? int[] enemyHealth = {100, 80, 120} → her düşmandan 20 can düş → yeni canları yazdır

            // int[] enemyHealth = {100, 80, 120};

            // foreach (int health in enemyHealth)
            //     {
            //         Console.WriteLine(
            //             $"""
            //             Hasar Öncesi Can: {health}
            //             Hasar Sonrası Can: {health - 20}
            //             """
            //         );
            //     }

            //? int[] numbers = {3, 7, 12, 18, 21, 24} → 3’e bölünen kaç sayı var? → yazdır

            // int[] numbers = {3, 7, 12, 18, 21, 24};
            // int counter = 0;

            // foreach (int number in numbers)
            //     {
            //         if (number % 3 == 0) counter ++;
            //     }
            // Console.WriteLine($"3'e tam bölünen sayı adedi: {counter}");

            //? string[] products = {"Laptop", "Mouse", "Keyboard", "Monitor", "Screen", "Wifi Adapter"} → içinde "o" harfi geçenleri yazdır

            string[] products = {"Laptop", "Mouse", "Keyboard", "Monitor", "Screen", "Wifi Adapter"};

            foreach (string product in products)
                {
                    if (product.Contains("o")) Console.WriteLine(product);
                }
            }
    }
}