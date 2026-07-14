namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson31_IfElse
    {
        public static void Run()
        {
            // string username = "DZEL";
            // string password = "12345";

            // if (username != "DZEL") { Console.WriteLine("Kullanıcı adı yanlış"); 
            // } else if(password != "12345") {
            // Console.WriteLine("Parola yanlış");
            // } else {
            // Console.WriteLine("Merhaba DZEL");
            // }

            // int x = 10;
            // int y = 20;

            // if (x > y) {
            // Console.WriteLine("x y'den büyük");
            // } else if (x == y) {
            // Console.WriteLine("x y'ye eşit"); 
            // } else {
            // Console.WriteLine("x y'den küçük"); 
            // }

            //? Görev 1. Kullanıcıdan bir not al. Kurallar: 90-100 => AA 80-89  => BA 70-79  => BB 60-69  => CB 50-59  => CC 0-49   => FF if - else if - else kullan.

            // Console.Write("Notunuz: ");
            // int grade = Convert.ToInt32(Console.ReadLine());

            // if (90 <= grade && grade <= 100)
            //     {
            //         Console.WriteLine("Harf notunuz: AA");
            //     } else if (80 <= grade && grade < 90)
            //     {
            //         Console.WriteLine("Harf notunuz: BA");
            //     } else if (70 <= grade && grade < 80)
            //     {
            //         Console.WriteLine("Harf notunuz: BB");
            //     } else if (60 <= grade && grade < 70)
            //     {
            //         Console.WriteLine("Harf notunuz: CB");
            //     } else if (50 <= grade && grade < 60)
            //     {
            //         Console.WriteLine("Harf notunuz: CC");
            //     } else if (0 <= grade & grade < 50)
            //     {
            //         Console.WriteLine("Harf notunuz: FF");
            //     } else
            //     {
            //         Console.WriteLine("Hatalı Giriş");
            //     }

            //? Görev 2: Kullanıcıdan bir ay numarası al. 12,1,2 => Kış 3,4,5 => İlkbahar 6,7,8 => Yaz 9,10,11 => Sonbahar  if - else if - else ile çöz.

            // Console.Write(
            //     """
            //     12, 1, 2 → Kış
            //     3, 4, 5 → İlkbahar
            //     6, 7, 8 → Yaz
            //     9, 10, 11 → Sonbahar

            //     Bir Ay Numarası Giriniz: 
            //     """
            // );
            // int monthNumber = Convert.ToInt32(Console.ReadLine());

            // if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
            //     {
            //         Console.WriteLine("Kış Mevsimi");
            //     } else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)
            //     {
            //         Console.WriteLine("İlkbahar Mevsimi");
            //     } else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8)
            //     {
            //         Console.WriteLine("Yaz Mevsimi");
            //     } else if (monthNumber == 9 || monthNumber == 10 || monthNumber == 11)
            //     {
            //         Console.WriteLine("Sonbahar Mevsimi");
            //     } else
            //     {
            //         Console.WriteLine("Hatalı Giriş");
            //     }

            //? Görev 3 (Biraz Daha Zor) Kullanıcıdan yaş al. 0-12   => Çocuk 13-17  => Genç 18-64  => Yetişkin 65+    => Yaşlı Negatif girerse: Geçersiz yaş yazdır.

            // Console.Write("Yaşınız: ");
            // int age = Convert.ToInt32(Console.ReadLine());

            // if (age >= 65)
            //     {
            //         Console.WriteLine("Yaşlı");
            //     } else if (18 <= age && age < 65)
            //     {
            //         Console.WriteLine("Yetişkin");
            //     } else if (13 <= age && age < 18)
            //     {
            //         Console.WriteLine("Genç");
            //     } else if (0 <= age && age < 13)
            //     {
            //         Console.WriteLine("Çocuk");
            //     } else
            //     {
            //         Console.WriteLine("Geçersiz Yaş");
            //     }

            //? Ek Task 🚀 (Biraz Daha Gerçek Hayat) Bir e-ticaret indirim sistemi yaz: decimal totalPrice; Kurallar: 0 - 999 TL => İndirim yok | 1000 - 4999 TL  => %5 indirim | 5000 - 9999 TL  => %10 indirim | 10000+ TL => %15 indirim. Sonuçta: İndirim oranını yazdır İndirim tutarını yazdır Ödenecek tutarı yazdır

            // Console.Write("Tutar Giriniz: ");
            // decimal price = Convert.ToDecimal(Console.ReadLine());

            // if (price >= 10000)
            //     {
            //         decimal discountRate = 0.15m;
            //         decimal discountAmount = price * discountRate;
            //         price -= discountAmount;
            //         Console.WriteLine(
            //             $"""
            //             İndirim Oranı: {discountRate:P}
            //             İndirim Tutarı: {discountAmount:C}
            //             Ödenecek Tutar: {price:C}
            //             """
            //         );
            //     } else if (5000 <= price && price < 10000)
            //     {
            //         decimal discountRate = 0.10m;
            //         decimal discountAmount = price * discountRate;
            //         price -= discountAmount;
            //         Console.WriteLine(
            //             $"""
            //             İndirim Oranı: {discountRate:P}
            //             İndirim Tutarı: {discountAmount:C}
            //             Ödenecek Tutar: {price:C}
            //             """
            //         );
            //     } else if (1000 <= price && price < 5000)
            //     {
            //         decimal discountRate = 0.05m;
            //         decimal discountAmount = price * discountRate;
            //         price -= discountAmount;
            //         Console.WriteLine(
            //             $"""
            //             İndirim Oranı: {discountRate:P}
            //             İndirim Tutarı: {discountAmount:C}
            //             Ödenecek Tutar: {price:C}
            //             """
            //         );
            //     } else if (0 <= price && price < 1000)
            //     {
            //         Console.WriteLine(
            //             $"""
            //             İndirim Yok
            //             Ödenecek Tutar: {price:C}
            //             """
            //         );
            //     } else
            //     {
            //         Console.WriteLine("Hatalı Giriş");
            //     }

            //? Bir sinema bileti sistemi yap. Kurallar: 0-12 yaş  => 100 TL | 13-17 yaş => 150 TL | 18-64 yaş => 250 TL | 65+ yaş   => 120 TL. Sonra: Öğrenci mi? (E/H) Eğer öğrenciyse: %20 indirim. Sonuçta ekrana yaz: Yaş: Öğrenci Durumu: Normal Fiyat: İndirim: Ödenecek Tutar:

            Console.Write("Yaşınız: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Öğrencilik Durumu(E/H): ");
            char studentStatus = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

            decimal price = age >= 65 ? 120 : 18 <= age && age < 65 ? 250 : 13 <= age && age < 18 ? 150 : 0 <= age && age < 13 ? 100 : 0;
            decimal discountRate = 0.20m;
            decimal discountAmount = price * discountRate;

            if (age >= 65)
                { 
                    if (studentStatus == 'E')
                    {
                        decimal discountedPrice = price - discountAmount;
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            İndirim: {discountAmount:C}
                            İndirimli Fiyat: {discountedPrice:C}
                            """
                        );
                    } else
                    {
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            """
                        );
                    }
                } else if (18 <= age && age < 65)
                {
                    price = 250m;
                    if (studentStatus == 'E')
                    {
                        decimal discountedPrice = price - discountAmount;
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            İndirim: {discountAmount:C}
                            İndirimli Fiyat: {discountedPrice:C}
                            """
                        );
                    } else
                    {
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            """
                        );
                    }
                } else if (13 <= age && age < 18)
                {
                    price = 150m;
                    if (studentStatus == 'E')
                    {
                        decimal discountedPrice = price - discountAmount;
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            İndirim: {discountAmount:C}
                            İndirimli Fiyat: {discountedPrice:C}
                            """
                        );
                    } else
                    {
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            """
                        );
                    }
                } else if (0 <= age && age < 12)
                {
                    price = 100m;
                    if (studentStatus == 'E')
                    {
                        decimal discountedPrice = price - discountAmount;
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            İndirim: {discountAmount:C}
                            İndirimli Fiyat: {discountedPrice:C}
                            """
                        );
                    } else
                    {
                        Console.WriteLine(
                            $"""
                            Yaş: {age}
                            Öğrencilik Durumu: {studentStatus}
                            Normal Fiyat: {price:C}
                            """
                        );
                    }
                } else
                {
                    Console.WriteLine("Hatalı Giriş");
                }
            }
    }
}