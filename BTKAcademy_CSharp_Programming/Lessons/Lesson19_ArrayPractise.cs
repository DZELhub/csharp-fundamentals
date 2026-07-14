namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson19_ArrayPractise
    {
        public static void Run()
        {
            //? Öğrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 Öğrenci). Öğrenciler dizisi kaç elemanlıdır yazdırınız. İlk 2 öğrencinin ad ve not bilgisini yazdırınız. Tüm öğrencilerin not ortalaması nedir?

            Console.Write("1. Öğrenci: ");
            string? student1 = Console.ReadLine();
            Console.Write("1. Not: ");
            int grade1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("2. Öğrenci: ");
            string? student2 = Console.ReadLine();
            Console.Write("2. Not: ");
            int grade2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Öğrenci: ");
            string? student3 = Console.ReadLine();
            Console.Write("3. Not: ");
            int grade3 = Convert.ToInt32(Console.ReadLine());


            string[] students = {student1 ?? string.Empty, student2 ?? string.Empty, student3 ?? string.Empty};
            int[] grades = {grade1, grade2, grade3};

            Console.WriteLine(
                $"Öğrenciler dizisinin uzunluğu: {students.Length}"
            );

            Console.WriteLine(
                $"1. Öğrencinin Adı: {students[0]}\n" +
                $"1. Öğrencinin Notu: {grades[0]}\n" +
                $"2. Öğrencinin Adı: {students[1]}\n" +
                $"2. Öğrencinin Notu: {grades[1]}"
            );

            double total = 0;
            foreach (var grade in grades)
            {
                total += grade;
            }
            Console.WriteLine(
                $"Öğrencilerin Not Ortalaması: {total / grades.Length}"
            );

            //? Görev 1) 5 ürün adı ve fiyatı al: string[] products, decimal[] prices oluştur. Sonra: ✅ tüm ürünleri listele ✅ en pahalı ürünü bul ✅ ortalama fiyatı hesapla

            string[] products = {"Iphone","Samsung","Vestel","Huawei","GM"};
            decimal[] prices = {90000m, 75000m, 35000m, 55000m, 60000m};

            for (int i = 0; i < products.Length && i < prices.Length; i++)
            {
                Console.WriteLine($"{products[i]} : {prices[i]:C}");
            }
            
            decimal expensive = 0m;
            string product = "";
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > expensive)
                {
                    expensive = prices[i];
                    product = products[i];
                }
            }
            Console.WriteLine(
                $"En Pahalı Ürün:\n" +
                $"{product} : {expensive:C}"
            );

            decimal total1 = 0m;
            foreach (var price in prices)
            {
                total1 += price;
            }
            Console.WriteLine(
                $"Ortalama Fiyat: {total / prices.Length:C}"
            );
            
            //? Görev 2 🚀 Bir cümle al. Sonra: ✅ Split() ile kelimelere ayır ✅ alfabetik sırala (Array.Sort) ✅ ters çevir (Array.Reverse) ✅ tekrar yazdır

            Console.Write("Lütfen bir cümle giriniz: ");
            string? sentence = Console.ReadLine();
            string cleanSentence = (sentence ?? "").Trim();

            string[] words = (cleanSentence ?? "").Split(" ");
            
            Array.Sort(words);
            Console.WriteLine("Alfabetik Düzen:");
            foreach (var word in words)
            {
                Console.WriteLine(
                    word
                );
            }

            Array.Reverse(words);
            Console.WriteLine("Ters Düzen:");
            foreach (var word in words)
            {
                Console.WriteLine(
                    word
                );
            }
        }
    }
}