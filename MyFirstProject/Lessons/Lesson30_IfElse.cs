namespace MyFirstProject.Lessons
{
    public static class Lesson30_IfElse
    {
        public static void Run()
        {
            // Console.WriteLine("Merhaba DZEL"); // Her zaman çalışsın istemiyorum

            // if (true) { Console.WriteLine("Merhaba DZEL"); } // true koşuluna bağlı, false olsa çalışmaz

            // if (5 > 3) {
            // Console.WriteLine("Merhaba DZEL");
            // }

            // var isLogin1 = true;

            // if (isLogin1) {
            // Console.WriteLine("Merhaba DZEL");
            // }

            // string userName = "DZEL";
            // string password = "12345";

            // var isLogin = userName == "DZEL" && password == "12345";

            // if (isLogin) {
            // Console.WriteLine("Merhaba DZEL");
            // } else {
            // Console.WriteLine("Giriş Başarısız");
            // }

            // if (userName == "DZEL") {
            //     if (password == "12345") {
            //         Console.WriteLine("Merhaba DZEL");
            //     } else {
            //         Console.WriteLine("Parola Yanlış");
            //     }
            // } else {
            //     Console.WriteLine("Kullanıcı Adı Yanlış");
            // }

            //? Mini Challenge 1 🚀 Kullanıcıdan yaş al. 18 veya üzeriyse: Ehliyet alabilirsiniz Değilse: Ehliyet alamazsınız.

            // Console.Write("Yaşınız: ");
            // int age = Convert.ToInt32(Console.ReadLine());

            // if (age >= 18)
            //     {
            //         Console.WriteLine("Ehliyet Alabilirsiniz");
            //     } else
            //     {
            //         Console.WriteLine("Ehliyet Alamazsınız");
            //     }

            //? Mini Challenge 2 🚀 Kullanıcıdan kullanıcı adı ve şifre al. Doğru bilgiler: string userName = "admin"; string password = "123"; Kontroller: Kullanıcı adı yanlışsa: Kullanıcı adı hatalı Şifre yanlışsa: Şifre hatalı İkisi de doğruysa: Giriş başarılı Bu görev özellikle iç içe if mantığını pekiştirir.

            // string userName = "admin"; 
            // string password = "123";

            // Console.Write("Kullanıcı Adı: ");
            // string enteredUserName = (Console.ReadLine() ?? string.Empty).ToLower().Trim();

            // Console.Write("Şifre: ");
            // string enteredPassword = Console.ReadLine() ?? string.Empty;

            // if (enteredUserName == userName)
            //     {
            //         if (enteredPassword == password)
            //         {
            //             Console.WriteLine("Giriş Başarılı");
            //         } else
            //         {
            //             Console.WriteLine("Şifre Hatalı");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine ("Kullanıcı Adı Hatalı");
            //     }

            //? Mini Challenge 3 🎮 (Unity Hazırlığı) int health = 40; Kontrol et: Can > 70 → Sağlıklı Can > 30 → Yaralı Can > 0 → Kritik Can <= 0 → Ölü Şimdilik iç içe if ile yapmaya çalış.

            // int health = 40;

            // if (health <= 0)
            //     {
            //         Console.WriteLine("Ölü");
            //     } else
            //     {
            //         if (health > 70)
            //         {
            //             Console.WriteLine("Sağlıklı");
            //         } else
            //         {
            //             if (health > 30)
            //             {
            //                 Console.WriteLine("Yaralı");
            //             } else
            //             {
            //                 Console.WriteLine("Kritik");
            //             }
            //         }
            //     }

            //? Ek Görev 🚀 Bir ATM sistemi yaz: string cardNumber = "1234"; string pin = "9999"; Kullanıcıdan kart numarası ve PIN iste. Kurallar Kart numarası yanlışsa: Kart bulunamadı Kart doğru, PIN yanlışsa: PIN hatalı İkisi de doğruysa: Giriş başarılı Bakiyeniz: 5000 TL

            // string cardNumber = "1234"; 
            // string pin = "9999";

            // Console.Write("Kart Numaranız: ");
            // string enteredCardNumber = Console.ReadLine() ?? string.Empty;

            // Console.Write("Pin Kodunuz: ");
            // string enteredPin = Console.ReadLine() ?? string.Empty;

            // if (enteredCardNumber == cardNumber)
            //     {
            //         if(enteredPin == pin)
            //         {
            //             Console.WriteLine(
            //                 """
            //                 Giriş Başarılı
            //                 Bakiyeniz 5000₺
            //                 """
            //             );
            //         } else
            //         {
            //             Console.WriteLine("Pin hatalı");
            //         }
            //     } else
            //     {
            //         Console.WriteLine("Kart numarası hatalı");
            //     }

            //? Ek Task 🚀 (Bir Tık Daha Gerçek ATM) Şimdi bunu geliştir: string cardNumber = "1234"; string pin = "9999"; decimal balance = 5000m; Giriş başarılı olursa: 1- Bakiye Görüntüle 2- Para Çek. Kullanıcı seçim yapsın. 1 seçerse → bakiye göster 2 seçerse → çekilecek tutarı iste bakiye yeterliyse parayı düş değilse "Yetersiz bakiye" yaz

            string cardNumber = "1234"; 
            string pin = "9999"; 
            decimal balance = 5000m;

            Console.Write("Kart Numaranız: ");
            string enteredCardNumber = Console.ReadLine() ?? string.Empty;

            Console.Write("Pin Kodunuz: ");
            string enteredPin = Console.ReadLine() ?? string.Empty;

            if (enteredCardNumber == cardNumber)
                {
                    if (enteredPin == pin)
                    {
                        Console.WriteLine(
                            """
                            Seçim Yapınız(1/2)
                            1- Bakiye Görüntüle
                            2- Para Çek
                            """
                        );
                        char option = (Console.ReadLine() ?? string.Empty).FirstOrDefault();
                        if (option == '1')
                        {
                            Console.WriteLine($"Güncel Bakiyeniz: {balance:C}");
                        } else
                        {
                            if (option == '2')
                            {
                                Console.Write("Çekmek İstediğiniz Tutar: ");
                                decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                                if (withdraw > balance)
                                {
                                    Console.WriteLine("Yetersiz bakiye");
                                } else
                                {
                                    balance -= withdraw;
                                    Console.WriteLine(
                                        $"{withdraw:C} çekildikten sonra hesabınızda kalan tutar: {balance:C}"
                                    );
                                }
                            }
                        }
                    } else
                    {
                        Console.WriteLine("Hatalı Pin");
                    } 
                } else
                {
                    Console.WriteLine("Kart Bulunamadı");
                }
            }
    }
}