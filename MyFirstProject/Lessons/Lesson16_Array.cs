namespace MyFirstProject.Lessons
{
    public static class Lesson16_Array
    {
        public static void Run()
        {
            //? 5 elemanlı bir string dizisi oluştur. İçine: film isimleri ekle. Sonra: ✅ ilk filmi yazdır,✅ son filmi yazdır,✅ toplam kaç film olduğunu yazdır,✅ bütün film isimlerini tek tek yazdır.

            string[] movies = {"Lord of the Rings","Harry Potter","Shawshank Redemption", "John Wick","Matrix"};

            Console.WriteLine(
                $"İlk Film: {movies[0]}\n" +
                $"Son Film: {movies[movies.Length-1]}\n" +
                $"Film Sayısı: {movies.Length}"
            );

            Console.Write("Filmler: ");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //? Mini Challenge 2 — Kelime Analizi 🚀 Kullanıcıdan bir cümle al. Sonra: ✅ Split(" ") kullan ✅ kaç kelime olduğunu göster, ✅ ilk kelimeyi yazdı,✅ son kelimeyi yazdır, ✅ bütün kelimeleri tek tek yazdır

            Console.Write("Bir Cümle Yazınız: ");
            string? sentence = Console.ReadLine();

            string[] sentencesPart = sentence.Split(" ");

            int sentencesPartLength = sentencesPart.Length;

            string firstWord = sentencesPart[0];
            string lastWord = sentencesPart[sentencesPart.Length-1];

            Console.WriteLine(
                $"Kaç Kelime: {sentencesPartLength}\n" +
                $"İlk Kelime: {firstWord}\n" +
                $"Son Kelime: {lastWord}"
            );
            Console.WriteLine("\nKelimeler:");
            for (int i = 0; i < sentencesPart.Length; i++)
            {
                Console.WriteLine(
                    $"{i+1}. {sentencesPart[i]}"
                );
            }; 
        }
    }
}