namespace MyFirstProject.Lessons
{
    public static class Lesson06_DataTypes
    {
        public static void Run()
        {
            //? Mini Challenge 🚀 Şunlar için uygun veri tiplerini seç: Oyuncunun canı,Dünya nüfusu,Ürün fiyatı,Oyuncu hareket hızı,Kullanıcı aktif mi?,Harf notu,Telefon numarası.Sonra neden o veri tipini seçtiğini açıklamaya çalış

            int healthy = 100;
            Console.WriteLine($"Oyuncunun Canı: {healthy}");

            long worldPopulation = 8245000000L;
            Console.WriteLine($"Dünya Nüfusu: {worldPopulation}");

            decimal productPrice = 30000m;
            Console.WriteLine($"Ürün Fiyatı: {productPrice:C}");

            float dexterity = 76.6f;
            Console.WriteLine($"Oyuncunun Hızı: {dexterity}");

            bool isActive = true;
            string status = isActive ? "Oyuncu Online" : "Oyuncu Offline";
            Console.WriteLine($"Oyuncunun Durumu: {status}");

            char gradeLetter = 'A';
            Console.WriteLine($"Öğrencinin Harf Notu: {gradeLetter}");

            string phoneNumber = "+90(532)4235820";
            Console.WriteLine($"Telefon Numarası: {phoneNumber}"); 
        
        }
    }
}