namespace MyFirstProject.Lessons
{
    public static class Lesson04_Variables
    {
        public static void Run()
        {
            //? Mini Challenge 🚀 Bir öğrenci sistemi oluştur: Şunları değişkenlerde tut: öğrenci adı, okul numarası, yaş, aktif öğrenci mi?, not ortalaması. Sonra hepsini ekrana yazdır.

            string studentName = "Dzelal Sokolovic";
            string schoolNumber = "302";
            int age = 18;
            bool activeStudent = true;
            double averagePoint = 85.3;

            Console.WriteLine( $"{studentName} isimli {schoolNumber} numaralı öğrenci, {age} yaşında olup. Not ortalaması {averagePoint} olmakla birlikte aktif öğrencilik durumu: {activeStudent}");
        }
    }
}