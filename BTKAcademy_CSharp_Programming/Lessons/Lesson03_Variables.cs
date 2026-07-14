namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson03_Variables
    {
        public static void Run()
        {
            Console.WriteLine(5000);
            Console.WriteLine(4000);
            Console.WriteLine(2000);
            Console.WriteLine(5000);

            //? Kdv hesabı yapalım

            Console.WriteLine(5000 * 1.18);
            Console.WriteLine(4000 * 1.18);
            Console.WriteLine(2000 * 1.18);
            Console.WriteLine(5000 * 1.18);

            //* Peki ya 30 tane veri olsaydı? Her birini tek tek güncellemek zor olurdu. KDV oranı değişse her birinin hesaplaması zor olurdu.

            double kdvOrani = 0.18;

            Console.WriteLine(5000 * kdvOrani);
            Console.WriteLine(4000 * kdvOrani);
            Console.WriteLine(2000 * kdvOrani);
            Console.WriteLine(5000 * kdvOrani);

            //* Ürünler içinde ayrı ayrı değişken tanımlanabilir

            double urunA = 5000;
            double urunB = 4000;
            double urunC = 2000;
            double urunD = 5000;

            Console.WriteLine(urunA * kdvOrani);
            Console.WriteLine(urunB * kdvOrani);
            Console.WriteLine(urunC * kdvOrani);
            Console.WriteLine(urunD * kdvOrani);

            //? Şunu yap: 3 ürün oluştur → bir indirim oranı oluştur → ürünlerin indirimli fiyatını hesapla

            decimal discount = 0.20m;

            decimal laptop = 55000m;
            decimal laptopDiscount = laptop * discount;
            decimal laptopDiscountedPrice = laptop - laptopDiscount;

            decimal cellPhone = 45000m;
            decimal cellPhoneDiscount = cellPhone * discount;
            decimal cellPhoneDiscountedPrice = cellPhone - cellPhoneDiscount;

            decimal tv = 50000m;
            decimal tvDiscount = tv * discount;
            decimal tvDiscountedPrice = tv - tvDiscount;

            Console.WriteLine("Laptop Fiyatı: " + laptop);
            Console.WriteLine("Laptop İndirim Tutarı: " + laptopDiscount);
            Console.WriteLine("Laptop İndirimli Fiyatı: " + laptopDiscountedPrice);

            Console.WriteLine("Cep Telefonu Fiyatı: " + cellPhone);
            Console.WriteLine("Cep Telefonu İndirim Tutarı: " + cellPhoneDiscount);
            Console.WriteLine("Cep Telefonu İndirimli Fiyatı: " + cellPhoneDiscountedPrice);

            Console.WriteLine("TV Fiyatı: " + tv);
            Console.WriteLine("TV İndirim Tutarı: " + tvDiscount);
            Console.WriteLine("TV İndirimli Fiyatı: " + tvDiscountedPrice);

        }
    }
}