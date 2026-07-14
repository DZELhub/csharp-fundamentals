namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson08_09_DataTypesConvertion
    {
        public static void Run()
        {
            
            //? Mini Challenge 🚀 Şunu yap: Kullanıcıdan: ad, yaş, matematik notu al. Ama: yaş → int, not → double veya decimal olarak dönüştür. Sonra şunu yazdır: Merhaba Celal Yaşınız: 25 Matematik Notunuz: 85.5. Ayrıca: not 50’den büyükse “Geçti” değilse “Kaldı” yazdır

            Console.Write("Adınız: ");
            string? name = Console.ReadLine();
            Console.Write("Yaşınız: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Matematik Notunuz: ");
            var mathGrade = Convert.ToDecimal(Console.ReadLine());
            string isPass = mathGrade >= 50 ? "Geçti" : "Kaldı";

            Console.WriteLine($"Merhaba {name} Yaşınız: {age} Notunuz: {mathGrade}. Dersten geçme durumunuz: {isPass}");

        }
    }
}