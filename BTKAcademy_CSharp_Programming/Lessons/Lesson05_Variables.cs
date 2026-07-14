namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson05_Variables
    {
        public static void Run()
        {
            //? Uygulama 1: Bir öğrencinin aşağıdaki bilgileri için gerekli değişkenleri oluşturunuz. Öğrenci Adı, Öğrenci Soyadı, Öğrenci Ad ve Soyad, Öğrenci Numarası, Öğrenci Cinsiyeti, Öğrenci TC Kimlik, Öğrenci Doğum Yılı, Öğrenci Adres, Öğrenci Yaşı

            string name = "Celal Selim";
            string surname = "Binay";
            string fullName = $"{name} {surname}";
            string schoolNumber = "1330";
            bool isMale = true;
            string gender = isMale ? "Erkek" : "Kadın";
            string identityNumber = "12121212122";
            int birthYear = 1988;
            string adress = "Çanakkale";
            int age = DateTime.Now.Year - birthYear;

            Console.WriteLine($"Adı:{name}\nSoyadı:{surname}\nTam Adı: {fullName}\nOkul Numarası: {schoolNumber}\nCinsiyeti: {gender}\nTC Kimlik No: {identityNumber}\nDoğum Tarihi: {birthYear}\nAdres Bilgisi: {adress}\nYaşı: {age}");

            //? Uygulama 2: Aşağıdaki ürünlerin toplam bilgisini hesaplayınız. Ürün 1: 50 TL, Ürün 2: 60.5 TL, Ürün 3: 356.45 TL

            decimal productPrice1 = 50m;
            decimal productPrice2 = 60.5m;
            decimal productPrice3 = 356.45m;
            decimal totalPrice = productPrice1 + productPrice2 + productPrice3;

            Console.WriteLine($"Toplam Tutar: {totalPrice:C}");
            
        }
    }
}