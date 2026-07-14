namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson10_NullableTypes
    {
        public static void Run()
        {
            //? Bir çalışan sistemi oluştur: Ad, departman, maaş. Maaş bilgisi boş olabilir. Maaşı yazdır, GetValueOrDefault() kullan, ?? operatörü kullan. Kullanıcı dostu çıktı üret.

            string name = "Celal";
            string department = "Game Developing";
            decimal? salary = null;
            string hasSalary = salary == null ? "Maaş Bilgisi Yok" : "0";

            Console.WriteLine(salary.GetValueOrDefault());
            Console.WriteLine(salary ?? 0);
            Console.WriteLine($"Ad: {name}\nDepartman: {department}\nMaaş: {hasSalary}");

            //? Mini Challenge 🚀 Şimdi sistemi geliştir: Bir ürün oluştur: ürün adı, stok miktarı, indirim oranı. Ama: indirim oranı boş olabilir. Sonra: indirim varsa fiyat hesapla yoksa “İndirim Yok” yazdır. ?? nullable ternary birlikte kullan 🙂

            string? productName = "Samsung A30";
            int? stockAmount = 200;
            decimal? price = 50000m;
            float? discountRate = 0.20f;

            Console.WriteLine($"Ürün Adı: {(productName == null ? "Ürün Adı Girilmemiş":productName)}\nStok Miktarı: {stockAmount ?? 0}\nBirim Fiyatı: {price.GetValueOrDefault():C}\nİndirim Oranı: {discountRate ?? 0}\nİndirimli Fiyat: {(discountRate == null ? "İndirim Yok": price - price * Convert.ToDecimal(discountRate)):C}");
        }
    }
}