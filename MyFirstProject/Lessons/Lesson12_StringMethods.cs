namespace MyFirstProject.Lessons
{
    public static class Lesson12_StringMethods
    {
        public static void Run()
        {
            //? Kullanıcıdan cümle al. Kaç karakter, Büyük harf versiyonu, Küçük harf versiyonu, içinde "C#" geçiyor mu, ilk 5 karakter, boşluk temizle.

            Console.Write("Bir Cümle Giriniz: ");
            string? sentence = 
                Console.ReadLine();
            Console.WriteLine(sentence);

            int letter = 
               sentence.Length;
            Console.WriteLine(letter);

            string upperCase = 
                sentence.ToUpper();
            Console.WriteLine(upperCase);

            string lowerCase =
                sentence.ToLower();
            Console.WriteLine(lowerCase);

            bool contain = 
                sentence.Contains("C#");
            string message = $"Cümle içinde 'C#' {(contain ? "bulunuyor" : "bulunmuyor")}";
            Console.WriteLine(message);

            string firstFiveChar =
                sentence.Substring(0, 5);
            Console.WriteLine(firstFiveChar);

            string removeSpace =
                sentence.Trim();
            Console.WriteLine(removeSpace);
        }
    }
}