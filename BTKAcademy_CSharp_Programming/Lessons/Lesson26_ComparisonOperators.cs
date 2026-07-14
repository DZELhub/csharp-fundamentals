namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson26_ComparisonOperators
    {
        public static void Run()
        {
            //? Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.

            Console.Write("Yaşınız: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string voteStatus = age >= 18 ? "Oy Kullanabilirsiniz" : "Oy Kullanamazsınız";

            Console.WriteLine(
                $"Oy Kullanma Durumunuz: {voteStatus}"
            );

            //? Klavyeden girilen sayının işaretini ve tek/çift durumunu kontrol ediniz.

            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string positiveNegative = number == 0 ? "0" : number > 0 ? "Pozitif" : "Negatif";
            string evenOdd = number == 0 ? "0": number % 2 == 0 ? "Çift Sayı" : "Tek Sayı";

            Console.WriteLine(
                $"""
                Girmiş olduğunuz sayı: {positiveNegative}
                Girmiş olduğunuz sayı: {evenOdd}
                """
            );
        }
    }
}