namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson24_AssignmentOperators
    {
        public static void Run()
        {
            int a = 5;
            int b = 10;

            a += b;
            a -= b;
            a *= b;
            a /= b;
            a %= b;

            Console.WriteLine(a);

            // //? Math

            double sonuc;

            sonuc = Math.Pow(2,3); // Üssünü alma
            sonuc = Math.Sqrt(25); // Karekök alma
            sonuc = Math.Abs(-10); // İşaret değiştirme
            sonuc = Math.Round(4.5); // Yuvarlama
            sonuc = Math.Ceiling(4.4); // Yukarı yuvarlama
            sonuc = Math.Floor(4.6); // Aşağı yuvarlama
            sonuc = Math.Max(10,20); // Büyük olan
            sonuc = Math.Min(30,40); // Küçük olan

            Console.WriteLine(sonuc);

            //? Mini Challenge 1 🚀: Bir ürün fiyatı tanımla: decimal price = 13749.99m; Sonra: ✅ %18 KDV ekle ✅ Sonucu 2 basamak yuvarla ✅ Ekrana yazdır

            decimal price = 13749.99m;
            decimal kdv = 0.18m;

            price += price*kdv;

            decimal roundedPrice = Math.Round(price,2);

            Console.WriteLine(roundedPrice);

            //? Mini Challenge 2 🚀: Kullanıcıdan iki sayı al. Sonra: ✅ Büyük olanı bul (Math.Max) ✅ Küçük olanı bul (Math.Min) ✅ Birinci sayının mutlak değerini bul (Math.Abs) ✅ Birinci sayının karekökünü hesapla (Math.Sqrt) Karekök almadan önce sayının negatif olup olmadığını kontrol etmeyi dene. Bu sana ileride if konusuna hazırlık yapacak.

            Console.Write("Bir Sayı Giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir Sayı Daha Giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int bigger = Math.Max(number1, number2);
            int smaller = Math.Min(number1, number2);
            int absoluteValue = Math.Abs(number1);

            bool isNegative = number1 < 0;
            string status = isNegative == false ? "Pozitif" : "Negatif";
            string squareRoot = isNegative ? "Hesaplanamaz" : Math.Sqrt(number1).ToString();

            Console.WriteLine(
                $"Büyük Sayı: {bigger}\n" +
                $"Küçük Sayı: {smaller}\n" +
                $"Birinci Sayının Mutlak Değeri: {absoluteValue}\n" +
                $"Birinci Sayının Durumu: {status}\n" +
                $"Birinci Sayının Karekökü: {squareRoot}"
            );

            //? Kullanıcıdan bir sayı al. Sonra: karesini hesapla (Math.Pow) küpünü hesapla (Math.Pow) karekökünü hesapla (Math.Sqrt)

            Console.Write("Bir Sayı Giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double square = Math.Pow(number,2);
            double cube = Math.Pow(number, 3);
            double squareRoot1 = Math.Sqrt(number);

            Console.WriteLine(
                $"{number} sayısının;\n" +
                $"Karesi: {square}\n" +
                $"Küpü: {cube}\n" +
                $"Karekökü: {squareRoot1}"
            );

            //? Görev 2 🚀 Bir ürün fiyatı tanımla: decimal price = 23456.789m; Sonra: aşağı yuvarla (Math.Floor) yukarı yuvarla (Math.Ceiling) 2 basamak yuvarla (Math.Round(price, 2)) ve üç sonucu da karşılaştırarak yazdır.

            decimal price1 = 23456.789m;

            decimal floor = Math.Floor(price1);
            decimal ceiling = Math.Ceiling(price1);
            decimal roundedTwo = Math.Round(price1,2);

            Console.WriteLine(
                $"Ürün Fiyatı: {price1:C}\n" +
                $"Aşağı Yuvarlanmış Fiyat: {floor:C}\n" +
                $"Yukarı Yuvarlanmış Fiyat: {ceiling:C}\n" +
                $"2 Basamak Yuvarlanmış Fiyat: {roundedTwo:C}"
            );

            //? Görev 1 🚀 Bir öğrencinin: double vize = 67.4; double final = 78.8; notları olsun. Ortalama hesapla Sonucu Math.Round(..., 1) ile 1 basamağa yuvarla Ekrana yazdır

            double midtermExam = 67.4;
            double finalExam = 78.8;

            double averageGrade = (midtermExam + finalExam) / 2;

            double roundedGrade = Math.Round(averageGrade, 1);

            Console.WriteLine(
                $"""
                Vize Notu: {midtermExam}
                Final Notu: {finalExam}
                Not Ortalaması: {averageGrade}
                Yuvarlanmış Ortalama: {roundedGrade}
                """
            );

            //? Görev 2 🚀 Kullanıcıdan bir sayı al. Mutlak değerini bul Karesini bul Sayının 3 ile bölümünden kalanı bul (%) Sayıyı 5 artır (+=) Son sonucu ekrana yazdır

            Console.Write("Bir Sayı Giriniz: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            double absoluteValue1 = Math.Abs(number3);
            double square2 = Math.Pow(number3,2);
            double moduloBy3 = number3 % 3;
            int increasedNumber =
            number3;
            increasedNumber += 5;

            Console.WriteLine(
                $"""
                Girilen Değer: {number3}
                Mutlak Değer: {absoluteValue1}
                Karesi: {square2}
                3 ile bölümünden kalan: {moduloBy3};
                5 artırılmış hali: {increasedNumber}
                """
            );

            //? Mini Challenge 3 🚀 Bir ürün için: decimal price = 18599.95m; Tanımla. Sonra: %18 KDV ekle %10 indirim uygula Sonucu 2 basamak yuvarla İndirim tutarını hesapla KDV tutarını hesapla Hepsini ekrana yazdır.

            decimal price2 = 18599.95m;
            decimal taxRate = 0.18m;
            decimal taxAmount = price2 * taxRate;
            decimal priceWithTax = price2; 
            priceWithTax += taxAmount;
            decimal discountRate = 0.10m;
            decimal discountAmount = priceWithTax * discountRate;
            decimal discountedPrice = priceWithTax; 
            discountedPrice -= discountAmount;
            double roundedTwo1 = Math.Round(Convert.ToDouble(discountedPrice), 2);

            Console.WriteLine(
                $"""
                Ürün Fiyatı: {price2:C}
                Vergi Oranı: {taxRate:P}
                Vergi Tutarı: {taxAmount:C}
                Vergi Dahil Fiyat: {priceWithTax:C}
                İndirim Oranı: {discountRate:P}
                İndirim Tutarı: {discountAmount:C}
                İndirimli Fiyat: {discountedPrice:C}
                2 Basamak Yuvarlanmış Fiyat: {roundedTwo1:C}
                """
            );
        }
    }
}