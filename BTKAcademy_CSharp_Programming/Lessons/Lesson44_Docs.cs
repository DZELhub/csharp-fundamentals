namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson44_Docs
    {
        public static void Run()
        {
            // Directory.CreateDirectory("newFile"); // Doğrudan proje içinde oluşturur

            // Directory.CreateDirectory("./fileManagement/newFile"); // İlgili yolda klasör oluşturur

            // Directory.Delete("newFile"); // Yoldaki klasörü siler

            // if (Directory.Exists("newFile"))
            //     {
            //         Directory.Delete("newFile");
            //     } else
            //     {
            //         Console.WriteLine("Klasör Silinemedi ya da Çoktan Silinmiş");
            //     }

            //* Bilgisayarın herhangi bir yerinde oluşturmak için

            // string path = @"C:\Users\ASUS\Desktop\NewFile";
            // Directory.CreateDirectory(path);

            //? Görev 1: Logs klasörü oluştur → yoksa oluştur → varsa mesaj yaz
            //? Görev 2: Logs içine → log.txt oluştur → içine "Program başladı" yaz
            //? Görev 3 (OYUN SEVİYESİ) Saves klasörü oluştur → içine player.txt oluştur → içine HP:100 yaz
            //? Görev 4 (ZOR) Eğer Saves klasörü varsa: → içindeki tüm dosyaları listele

            string basePath = Path.Combine("DZEL", "game");
            string logsPath = Path.Combine(basePath, "logs");
            string savesPath = Path.Combine(basePath, "saves");

            string logFile = Path.Combine(logsPath, "log.txt");
            string playerFile = Path.Combine(savesPath, "player.txt");

            // Logs
            if (!Directory.Exists(logsPath))
            {
                Directory.CreateDirectory(logsPath);
            }

            File.AppendAllText(logFile, "Program Başladı\n");

            // Saves
            if (!Directory.Exists(savesPath))
            {
                Directory.CreateDirectory(savesPath);
            }

            if (!File.Exists(playerFile))
            {
                File.WriteAllText(playerFile, "HP: 100");
            }

            // Listeleme
            Console.WriteLine("Save dosyaları:");

            foreach (var file in Directory.GetFiles(savesPath))
            {
                Console.WriteLine(file);
            }
            }
    }
}