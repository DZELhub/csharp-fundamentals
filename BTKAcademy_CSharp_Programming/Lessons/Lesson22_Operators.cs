namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson22_Operators
    {
        public static void Run()
        {
            int a = 10;
            int b = 5;
            int c = 21;

            // int result = a + b;
            // int result = a - b;
            // int result = a * b;
            // int result = a / b;
            int result = (a + b) * c;
            // int result = a % b;
            // int result = c % b;
            // int result = a++;
            // int result = ++a;

            Console.WriteLine(result);

            //? Mini Challenge 1 🚀 Bir ürün fiyatı oluştur: ✅ KDV ekle ✅ indirim uygula ✅ son fiyatı hesapla

            decimal price = 10000m;
            decimal taxRate = 0.18m;
            decimal discountRate = 0.20m;

            decimal priceWithTax = price + (price * taxRate);
            decimal discountedPrice = priceWithTax - (priceWithTax * discountRate);

            Console.WriteLine(
                $"Fiyat: {price:C}\n" +
                $"KDV Oranı: {taxRate:P}\n" +
                $"KDV Dahil Fiyat: {priceWithTax:C}\n" +
                $"İndirim Oranı: {discountRate:P}\n" +
                $"İndirimli Fiyat: {discountedPrice:C}"

            );

            //? Mini Challenge 2 🚀 Bir sayı oluştur. Sonra: ✅ çift mi tek mi kontrol et (%) ✅ 5’e tam bölünüyor mu kontrol et ✅ sayıyı 1 artır ✅ sayıyı 1 azalt

            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            string oddEven = number % 2 == 0 ? "Çift" : "Tek";
            string multipleOf5 = number % 5 == 0 ? "bölünür" : "bölünmez";
            int addition1 = number+1;
            Console.WriteLine($"{number}+1= {addition1}");
            int minus1 = number-1;
            Console.WriteLine($"{number}-1= {minus1}");
            

            Console.WriteLine(
                $"Sayı {oddEven}\n" +
                $"Sayı 5'e tam {multipleOf5}\n"      
            );
        }
    }
}