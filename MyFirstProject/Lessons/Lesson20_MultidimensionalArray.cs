namespace MyFirstProject.Lessons
{
    public static class Lesson20_MultidimensionalArray
    {
        public static void Run()
        {
            string[] students = {"Selim","Hande","Yüsra"};
            decimal [,] grades = new decimal[3,3];
            // Selim
            grades[0,0] = 50m;
            grades[0,1] = 60m;
            grades[0,2] = 70m;
            // Hande
            grades[1,0] = 60m;
            grades[1,1] = 80m;
            grades[1,2] = 90m;
            // Yüsra
            grades[2,0] = 50m;
            grades[2,1] = 70m;
            grades[2,2] = 30m;
            // Average Calculation
            decimal averageGrade1 = (grades[0,0] + grades[0,1] + grades[0,2]) / 3;
            decimal averageGrade2 = (grades[1,0] + grades[1,1] + grades[1,2]) / 3;
            decimal averageGrade3 = (grades[2,0] + grades[2,1] + grades[2,2]) / 3;

            Console.WriteLine(
                $"{students[0]} isimli öğrencinin not ortalaması: {averageGrade1}\n" +
                $"{students[1]} isimli öğrencinin not ortalaması: {averageGrade2}\n" +
                $"{students[2]} isimli öğrencinin not ortalaması: {averageGrade3}"
            );

            //? Mini Challenge 1 🚀 3 öğrenci için: ✅ 2 sınav notu gir ✅ her öğrencinin ortalamasını hesapla ✅ geçen/kalan bilgisini yazdır.

            string[] students1 = {"Selim","Hande","Yüsra"};
            decimal[,] grades1 = new decimal[3,2];

            // Selim
            grades1[0,0] = 45m;
            grades1[0,1] = 50m;
            // Hande
            grades1[1,0] = 90;
            grades1[1,1] = 100;
            // Yüsra
            grades1[2,0] = 100;
            grades1[2,1] = 90;

            for (int i = 0; i < students1.Length; i++)
            {
                decimal total1 = 0;
                for (int j = 0; j < 2; j++)
                {
                    total1 += grades[i,j];
                }
                decimal average = total1 / 2;

                Console.WriteLine(
                    $"{students1[i]} : " +
                    $"{average}\n" +
                    $"{students1[i]} Dersten {(average < 50 ? "Kaldı":"Geçti")}"
                );
                
            }

            //? Mini Challenge 2 🚀 2x3 int dizisi oluştur: 1 2 3 4 5 6 Sonra: ✅ tüm elemanları yazdır ✅ bütün sayıların toplamını hesapla ✅ en büyük sayıyı bul

            int[,] numbers = new int[2,3];
            
            // First Line
            numbers[0,0] = 1;
            numbers[0,1] = 2;
            numbers[0,2] = 3;
            // Second Line
            numbers[1,0] = 4;
            numbers[1,1] = 5;
            numbers[1,2] = 6;

            int total = 0;
            int biggestNumber = numbers[0,0];
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                total += number;
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine(
                $"Toplam: {total}\n" +
                $"En Büyük Numara: {biggestNumber}"
            );
        }
    }
}