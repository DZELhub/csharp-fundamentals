namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson14_DateTime
    {
        public static void Run()
        {
            //? Mini Challenge 1 — Yaş Hesaplama: Kullanıcıdan: doğum yılını al. Sonra: mevcut yılı kullan, yaşını hesapla, ekrana yazdır.

            Console.Write(
                "Doğum Yılınız: "
            );
            var birthYear = Convert.ToInt32(Console.ReadLine());

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine(
                $"Doğum Yılınız: {birthYear}\n" +
                $"Yaşınız: {age}"
            );

            //? Bir etkinlik tarihi oluştur: DateTime eventDate = new DateTime(2026, 12, 31); Sonra: bu tarihe 30 gün ekle, 2 ay ekle,1 yıl ekle, ve sonuçları yazdır.

            DateTime eventDate = new DateTime(2026, 5, 9);
            DateTime updatedEventDate = eventDate.AddDays(30);
            DateTime updatedEventDate2 = updatedEventDate.AddMonths(2);
            DateTime updatedEventDate3 = updatedEventDate2.AddYears(1);

            Console.WriteLine(
                $"Etkinlik Tarihi: {eventDate}\n" +
                $"Etkinlik Tarihi Güncelleme 1: {updatedEventDate}\n" +
                $"Etkinlik Tarihi Güncelleme 2: {updatedEventDate2}\n" +
                $"Etkinlik Tarihi Güncelleme 3: {updatedEventDate3}" 
            );
        }
    }
}