namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson13_StringPractise
    {
        public static void Run()
        {
            string course = ".NET10 ile C# Programlama Dili";

            // //? Kaç karaktere sahip? Hepsini küçük harf yap. '.' ile mi başlıyor? C# bilgisinin konumu nedir? 'C#' bilgisini içeriyor mu?'Dili' yerine 'Dersleri' yazınız.

            int characterCount = 
                course.Length;
            Console.WriteLine(
                $"Karakter Sayısı: {characterCount}"
            );

            string lowerCase =
                course.ToLower();
            Console.WriteLine(
                $"Küçük harf: {lowerCase}"
            );

            bool isStartsWithDot = 
                course.StartsWith('.');
            Console.WriteLine(
                $"Cümle '.' ile {(isStartsWithDot == true ? "başlıyor" : "başlamıyor")}"
            );

            int whereIsCSharp =
                course.IndexOf("C#");
            Console.WriteLine(
                $"'C#' değerinin cümle içindeki konumu {whereIsCSharp} indexi ile başlar"
            );

            bool isContainCSharp =
                course.Contains("C#");
            Console.WriteLine(
                $"Cümle 'C#' değerini {(isContainCSharp == true ? "içeriyor" : "içermiyor")}"
            );

            string updatedCourseName =
                course.Replace("Dili","Dersleri");
            Console.WriteLine(
                $"Kursun güncel adı: {updatedCourseName}"
            );
        }
    }
}