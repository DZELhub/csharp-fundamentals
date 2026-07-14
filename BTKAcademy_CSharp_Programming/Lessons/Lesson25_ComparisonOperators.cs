namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson25_ComparisonOperators
    {
        public static void Run()
        {
            int a = 5, b = 5, c = 10, d = 3;

            bool result = a == b;
            Console.WriteLine(result);
            bool result2 = c == d;
            Console.WriteLine(result2);

            string userName = "DZEL";
            string password = "sHy889122";

            bool result3 = userName == "DZELAL";
            bool result4 = password == "sHy889122";

            string permission1 = result3 ? "Kullanıcı Adı Doğru" : "Kullanıcı Adı Yanlış"; 
            Console.WriteLine(permission1);
            string permission2 = !result4 ? "Şifre Yanlış" : "Şifre Doğru";
            Console.WriteLine(permission2);

            string permission = result3 ? "Kullanıcı Adı Doğru": !result4 ? "Şifre Yanlış" : "Kullanıcı Adı Yanlış, Şifre Doğru";
            Console.WriteLine(permission);

            Console.WriteLine(result3);
            Console.WriteLine(result4);

            bool result5 = a!= b;
            bool result6 = b >= d;
            bool result7 = a > c;
            
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);

            //? Mini Challenge 1 🚀 Bir öğrencinin notunu tanımla: int grade = 75; Sonra: not 50'den büyük mü? not 100'e eşit mi? not 0'dan küçük mü? Sonuçları ekrana yazdır.

            Console.Write("Lütfen Notunuzu Giriniz: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            bool greaterThan50 = grade > 50;
            string greaterResult = greaterThan50 ? "50'den Büyüktür": "50'den Küçüktür";
            bool equalTo100 = grade == 100;
            string equalResult = equalTo100 ? "100'e Eşittir" : "100'e Eşit Değildir";
            bool lessThanZero = grade < 0;
            string lessResult = lessThanZero ? "0'dan Küçüktür" : "0'dan Büyüktür";

            Console.WriteLine(
                $"""
                Notunuz: {grade};
                {greaterResult}
                {equalResult}
                {lessResult}
                """
            );

            //? Mini Challenge 2 🚀 Kullanıcı adı ve şifre oluştur: string userName = "celal"; string password = "12345"; Sonra: string enteredUserName string enteredPassword oluştur. Karşılaştır: == kullan. Şunları yazdır: Kullanıcı adı doğru mu? Şifre doğru mu? İkisi de doğru mu?

            string userName1 = "celal"; 
            string password1 = "12345";

            Console.Write("Kullanıcı Adınız: ");
            string enteredUserName = Console.ReadLine() ?? string.Empty;

            Console.Write("Şifreniz: ");
            string enteredPassword = Console.ReadLine() ?? string.Empty;

            bool userNameControl = enteredUserName == userName1;
            bool passwordControl = enteredPassword == password1;
            bool permissionControl = enteredUserName == userName1 && enteredPassword == password1;

            string userNameStatus = userNameControl ? "Doğru" : "Hatalı";
            string passwordStatus = passwordControl ? "Doğru" : "Hatalı";
            string permissionStatus = permissionControl ? "Kullanıcı Adı ve Şifre Doğru" : "Kullanıcı Adı veya Şifre Hatalı";

            Console.WriteLine(
                $"""
                Girdiğiniz Kullanıcı Adı: {enteredUserName}
                Girdiğiniz Şifre: {enteredPassword}
                Kullanıcı Adınız {userNameStatus}
                Şifreniz {passwordStatus}
                Giriş Bilgileriniz: {permissionStatus}
                """
            );

            //? Ek Pratik 🚀 Bu konu için sana bir görev daha bırakıyorum: int age = 19; Şunları kontrol et: Yaş 18 veya daha büyük mü? Yaş 65'ten küçük mü? Yaş tam olarak 30 mu? Yaş 18 ile 65 arasında mı? Sonuçları bool olarak ekrana yazdır.

            Console.Write("Yaşınız: ");
            int age = Convert.ToInt32(Console.ReadLine());

            bool greaterThan18 = age >= 18;
            string graterControl = greaterThan18 ? "Büyük veya Eşit" : "Küçük";
            bool lessThan65 = age < 65;
            string lessControl = lessThan65 ? "Küçük" : "Büyük veya Eşit";
            bool equalTo30 = age == 30;
            string equalControl = equalTo30 ? "Eşit" : "Eşit Değil";
            bool rangeOf18to65 = age > 18 && age < 65;
            string rangeControl = rangeOf18to65 ? "Arasında" : "Arasında Değil";

            // Bool Answer
            Console.WriteLine(
                $"""
                Yaşınız 18'den Büyük veya Eşit Mi?: {greaterThan18}
                Yaşınız 65'ten Küçük Mü?: {lessThan65}
                Yaşınız 30'a Eşit Mi?: {equalTo30};
                Yaşınız 18 ile 65 Arasında Mı?: {rangeOf18to65}  
                """
            );

            // User Friendly Answer
            Console.WriteLine(
                $"""
                Yaşınız 18'den {graterControl}
                Yaşınız 65'ten {lessControl}
                Yaşınız 30'a {equalControl}
                Yaşınız 18 ile 65 {rangeControl}  
                """
            );

            //? Mini Geliştirme Görevi 🔥 Bunu bir üst seviyeye taşı: Yaşına göre kategori yaz: - 0–12 → Çocuk - 13–17 → Genç - 18–64 → Yetişkin - 65+ → Yaşlı

            Console.Write("Yaşınız: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            string ageCategory = age1 >= 0 && age1 <= 12 ? "Child" : age1 >= 13 && age1 <= 17 ? "Teen" : age1 >= 18 && age1 <= 64 ? "Adult" : age1 >= 65 && age1 <=100 ? "Old" : "Wrong Entry";

            Console.WriteLine(
                $"Yaş Kategoriniz: {ageCategory}"
            );
        }
    }
}