namespace MyFirstProject.Lessons
{
    public static class Lesson34_Ternary
    {
        public static void Run()
        {
            // int number = 9;

            // string result = (number % 2 == 0) ? "Çift Sayı" : "Tek Sayı";

            // Console.WriteLine(result);

            // string result2 = (number % 2 == 0) ? (number > 0) ? "Sayı Pozitif Çift" : "Sayı Negatif Çift" : (number > 0) ? "Sayı Pozitif Tek" : "Sayı Negatif Tek";

            // Console.WriteLine(result2);

            //? Ek Task 🚀 (Ternary Pekiştirme) Bir alışveriş sistemi yaz: decimal price = 1200; bool isMember = true; Kurallar: Üye ise %10 indirim Değilse indirim yok Ama sadece ternary kullan: decimal finalPrice = ? Sonra yazdır: Normal Fiyat: Üyelik: Ödenecek Tutar:

            // decimal price = 1200m;
            // bool isMember = true;
            // string membership = isMember ? "Var" : "Yok";
            // decimal discountRate = 0.10m;
            // decimal discountAmount = price * discountRate;

            // decimal finalPrice = 
            // isMember 
            //     ? price - discountAmount : price;

            // Console.WriteLine(
            //     $"""
            //     Normal Fiyat: {price:C}
            //     Üyelik: {membership}
            //     Ödecek Tutar: {finalPrice:C}
            //     """
            // );

            //? Mini Upgrade 🚀 (Bir Tık Zor) Aynı sistemi geliştir: decimal price = 1200; bool isMember = true; bool isHoliday = true; Kurallar: Üye → %10 indirim Tatil günü → ekstra %5 indirim Ama yine sadece ternary kullan. 👉 İpucu: decimal discount = ? şeklinde toplam indirimi hesaplamayı dene.

            // decimal price = 1200m;
            // bool isMember = true;
            // bool isHoliday = true;
            // string membership = isMember ? "Var" : "Yok";
            // string holidayStatus = isHoliday ? "Evet" : "Hayır";

            // decimal discountRate =
            //     (isMember ? 0.10m : 0m) +
            //     (isHoliday ? 0.05m : 0m);

            // decimal discount = price * discountRate;
            // decimal finalPrice = price - discount;

            // Console.WriteLine(
            //     $"""
            //     Normal Fiyat: {price:C}
            //     Üyelik Durumu: {membership}
            //     Tatil Mi?: {holidayStatus}
            //     Toplam Fiyat: {discount:C}
            //     Son Fiyat: {finalPrice:C}
            //     """
            // );

            //? 🚀 Bir Sonraki Seviye Task Şunu dene: Üye → %10 Tatil → %5 Kupon varsa → %7 👉 3 koşulu da sadece ternary ile çöz. Eğer toplam indirim %20'yi geçerse → maksimum %20 olsun.

            // decimal price = 1200m;
            // bool isMember = true;
            // bool isHoliday = true;
            // bool hasCupon = true;
            // string membership = isMember ? "Var" : "Yok";
            // string holidayStatus = isHoliday ? "Evet" : "Hayır";
            // string cuponStatus = hasCupon ? "Evet" : "Hayır";

            // decimal discountRate =
            //     (isMember ? 0.10m : 0m) +
            //     (isHoliday ? 0.05m : 0m) +
            //     (hasCupon ? 0.07m : 0m );

            // decimal discount = price * (discountRate > 0.20m ? 0.20m : discountRate);
            // decimal finalPrice = price - discount;

            // Console.WriteLine(
            //     $"""
            //     Normal Fiyat: {price:C}
            //     Üyelik Durumu: {membership}
            //     Tatil Mi?: {holidayStatus}
            //     Kupon Var Mı?: {cuponStatus}
            //     İndirimli Fiyat: {discount:C}
            //     Son Fiyat: {finalPrice:C}
            //     """
            // );

            //? //? 🚀 Bir Sonraki Seviye Task Şunu dene: Üye → %10 Tatil → %5 Kupon varsa → %7 👉 3 koşulu da sadece ternary ile çöz. Eğer toplam indirim %20'yi geçerse → maksimum %20 olsun. İndirimler çarpanlı olsun.

            decimal price = 1200m;

            bool isMember = true;
            bool isHoliday = true;
            bool hasCoupon = true;

            decimal finalPrice = price;

            finalPrice = isMember ? finalPrice * 0.90m : finalPrice;
            finalPrice = isHoliday ? finalPrice * 0.95m : finalPrice;
            finalPrice = hasCoupon ? finalPrice * 0.93m : finalPrice;

            decimal discount = price - finalPrice;

            Console.WriteLine(
            $"""
            Normal Fiyat: {price:C}
            İndirim: {discount:C}
            Son Fiyat: {finalPrice:C}
            """
            );
            }
    }
}