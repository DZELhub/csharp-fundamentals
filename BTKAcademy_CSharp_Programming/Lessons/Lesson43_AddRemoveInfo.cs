namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson43_AddRemoveInfo
    {
        public static void Run()
        {
        using(StreamWriter sw = File.CreateText("./fileManagement/readFile.txt")) { sw.WriteLine("Birinci Satır"); sw.WriteLine("İkinci Satır"); }

        foreach (var line in File.ReadLines("./fileManagement/readFile.txt"))
            {
                Console.WriteLine(line);
            }

        using(StreamWriter sw = File.AppendText("./fileManagement/readFile.txt")) { sw.WriteLine("Üçüncü Satır"); sw.WriteLine("Dördüncü Satır"); }

        foreach (var line in File.ReadLines("./fileManagement/readFile.txt"))
            {
                Console.WriteLine(line);
            }

        File.WriteAllText("./fileManagement/readFile.txt", "Selam, Tüm İçeriği Sildim.");
        
        using (StreamReader reader = File.OpenText("./fileManagement/readFile.txt"))
        Console.WriteLine(reader.ReadLine());

        File.AppendAllText("./fileManagement/readFile.txt","İçeriğe Ekleme Yaptım.");
        foreach (string line in File.ReadLines("./fileManagement/readFile.txt"))
        {
            Console.WriteLine(line);
        }
    }
    }
}