namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson15_Array
    {
        public static void Run()
        {
            //? 5 elemanlı bir string dizisi oluştur: şehir isimleri ekle ve tüm elemanları yazdır.

            string[] cities = new string[5];

            cities[0] = "Sarajevo";
            cities[1] = "Budapest";
            cities[2] = "Moscow";
            cities[3] = "Minsk";
            cities[4] = "İstanbul";

            Console.WriteLine(
                $"Şehir 1: {cities[0]}\n" +
                $"Şehir 2: {cities[1]}\n" +
                $"Şehir 3: {cities[2]}\n" +
                $"Şehir 4: {cities[3]}\n" +
                $"Şehir 5: {cities[4]}\n" 
            );

            //? 3 elemanlı int dizisi oluştur. Notları ekle ve ortalamayı hesapla.

            int[] grades = [60, 80, 90];
            int gradeCount = grades.Length;
            int average = (grades[0] + grades[1] + grades[2]) / gradeCount;
            Console.WriteLine(
                $"Not 1: {grades[0]} \n" +
                $"Not 2: {grades[1]} \n" +
                $"Not 3: {grades[2]} \n" +
                $"Ortalama: {average}" 
            );

            //? 2x2 çok boyutlu dizi oluştur: tüm elemanları tek tek yazdır.

            int[,] numbers = new int[2,2];

            numbers[0,0] = 1;
            numbers[0,1] = 2;
            numbers[1,0] = 3;
            numbers[1,1] = 4; 

            Console.WriteLine(
                $"{numbers[0,0]} {numbers[0,1]}\n" +
                $"{numbers[1,0]} {numbers[1,1]}"
            );
        }
    }
}