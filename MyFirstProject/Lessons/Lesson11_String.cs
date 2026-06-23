namespace MyFirstProject.Lessons
{
    public static class Lesson11_String
    {
        public static void Run()
        {
            //? Mini Challenge 🚀 Kullanıcıdan: ad, soyad, şehir, yaş al. Sonra: tam ad oluştur. string interpolation kullan.kullanıcıya şöyle mesaj göster: Merhaba Celal Binay Çanakkale şehrinde yaşıyorsunuz. Yaşınız: 25. Ayrıca: yaş bilgisini int’e dönüştür 🙂

            Console.Write("Adınız: ");
            string? name =
                Console.ReadLine();

            Console.Write("Soyadınız: ");
            string? surname =
                Console.ReadLine();

            Console.Write("Yaşadığınız Şehir: ");
            string? city = 
                Console.ReadLine();

            Console.Write("Yaşınız: ");
            var age = 
                Convert.ToInt32(Console.ReadLine());

            string fullName = 
                $"{name} {surname}";

            string message = 
                $"Merhaba {fullName}\n" +
                $"{city} şehrinde yaşıyorsunuz.\n" +
                $"Yaşınız: {age}";

            Console.WriteLine(message);
        }
    }
}