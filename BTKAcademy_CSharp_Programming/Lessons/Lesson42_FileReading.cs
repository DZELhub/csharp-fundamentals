namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson42_FileReading
    {
        public static void Run()
        {
            // StreamReader reading = File.OpenText("./fileManagement/readFile.txt");
            // Console.WriteLine(reading.ReadLine()); //* Sadece tek satır okur

            // using (StreamReader sr = File.OpenText("./fileManagement/readFile.txt")) //* Tüm İçeriği Okur
            // {
            //     string s;
            //         while ((s = sr.ReadLine()) != null)
            //         {
            //             Console.WriteLine(s);
            //         }
            // }

            // string sonuc = File.ReadAllText("./fileManagement/readFile.txt"); //* BP - Özellikle Küçük Dosyalar
            // Console.WriteLine(sonuc);

            // foreach (var line in File.ReadLines("./fileManagement/readFile.txt")) //* BP - Orta Boyutlu Dosyalar
            //     {
            //         Console.WriteLine(line);
            //     }

            //? Görev 1. Dosyadan okunan: → kaç satır var? → yazdır

            // int counter = 0;

            // foreach (string line in File.ReadLines("./fileManagement/readFile.txt"))
            // {
            //     counter ++;
            // }
            // Console.WriteLine($"Okunan Satır: {counter}");

            //? Dosyada: → "error" geçen satırları yazdır

            // foreach (string line in File.ReadLines("./fileManagement/readFile.txt"))
            // {
            //     if (line.ToLower().Contains("error")) Console.WriteLine(line);
            // }

            //? Görev 3 (Unity Mantığı 🎮) enemy.txt: Goblin Orc Troll → dosyadan düşmanları oku → foreach ile yazdır

            int number = 0;
            foreach (string line in File.ReadLines("./fileManagement/enemy.txt"))
            {
                number ++;
                Console.WriteLine($"{number}. Enemy: {line}");
            }
        }
    }
}