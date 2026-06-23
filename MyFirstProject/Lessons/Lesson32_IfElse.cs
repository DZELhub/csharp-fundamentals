namespace MyFirstProject.Lessons
{
    public static class Lesson32_IfElse
    {
        public static void Run()
        {
            //? Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.

            // Console.Write("Bir Sayı Giriniz: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Bir İşlem Seçiniz(+,-,x,/): ");
            // char operation = (Console.ReadLine() ?? string.Empty).FirstOrDefault();
            // Console.Write("Bir Sayı Daha Giriniz: ");
            // int number2 = Convert.ToInt32(Console.ReadLine());

            // if (operation == '+')
            //     {
            //         int result = number + number2;
            //         Console.WriteLine(
            //             $"{number} {operation} {number2} = {result}"
            //         );
            //     } else if (operation == '-')
            //     {
            //         int result = number - number2;
            //         Console.WriteLine(
            //             $"{number} {operation} {number2} = {result}"
            //         );
            //     } else if (operation == 'x')
            //     {
            //         int result = number * number2;
            //         Console.WriteLine(
            //             $"{number} {operation} {number2} = {result}"
            //         );
            //     } else if (operation == '/')
            //     {
            //         int result = number / number2;
            //         Console.WriteLine(
            //             $"{number} {operation} {number2} = {result}"
            //         );
            //     } else
            //     {
            //         Console.WriteLine("Hatalı İşlem Seçimi. İşlem Sonlandırıldı");
            //     }
            
            //? Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazınız. 0 - 24 → 0 | 25 - 44 → 1 | 45 - 54 → 2 | 55 - 69 → 3 | 70 - 84 → 4 | 85 - 100 → 5

            // Console.Write("Birinci Yazılı Notu: ");
            // int exam1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("İkinci Yazılı Notu: ");
            // int exam2 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Sözlü Notu: ");
            // int oralExam = Convert.ToInt32(Console.ReadLine());

            // int averageGrade = (exam1 + exam2 + oralExam) / 3;

            // if (85 <= averageGrade && averageGrade <= 100)
            //     {
            //         Console.WriteLine(
            //             $"""
            //             Not Ortlamanız: {averageGrade}
            //             Dönem Sonu Notunuz: 5
            //             """
            //         );
            //     } else if (70 <= averageGrade && averageGrade < 85) 
            //         {
            //             Console.WriteLine(
            //                 $"""
            //                 Not Ortlamanız: {averageGrade}
            //                 Dönem Sonu Notunuz: 4
            //                 """
            //             );
            //             } else if (55 <= averageGrade && averageGrade < 70) 
            //             {
            //                 Console.WriteLine(
            //                     $"""
            //                     Not Ortlamanız: {averageGrade}
            //                     Dönem Sonu Notunuz: 3
            //                     """
            //                 );
            //             } else if (45 <= averageGrade && averageGrade < 55) 
            //             {
            //                 Console.WriteLine(
            //                     $"""
            //                     Not Ortlamanız: {averageGrade}
            //                     Dönem Sonu Notunuz: 2
            //                     """
            //                 );
            //             } else if (25 <= averageGrade && averageGrade < 45) 
            //             {
            //                 Console.WriteLine(
            //                     $"""
            //                     Not Ortlamanız: {averageGrade}
            //                     Dönem Sonu Notunuz: 1
            //                     """
            //                 );
            //             } else if (0 <= averageGrade && averageGrade < 25) 
            //             {
            //                 Console.WriteLine(
            //                     $"""
            //                     Not Ortlamanız: {averageGrade}
            //                     Dönem Sonu Notunuz: 0
            //                     """
            //                 );
            //             } else { 
            //                 Console.WriteLine("Not Girişinde Hata Yaptınız. Ortalama Hesaplanamadı.");
            //             }

            //? Girilen 2 sayıdan en büyüğünü bulunuz.

            // Console.Write("Bir Sayı Giriniz: ");
            // int number1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Bir Sayı Daha Giriniz: ");
            // int number2 = Convert.ToInt32(Console.ReadLine());

            // if (number1 > number2)
            // {
            //     Console.WriteLine($"{number1} daha büyüktür");
            // }
            // else if (number2 > number1)
            // {
            //     Console.WriteLine($"{number2} daha büyüktür");
            // }
            // else
            // {
            //     Console.WriteLine("Sayılar eşit");
            // }

            //? Ek Task 🚀 Bu konu için sana bir görev daha bırakıyorum: Öğrenci Burs Sistemi Kullanıcıdan: Not Ortalaması Devamsızlık Sayısı al. Ortalama >= 90 ve devamsızlık <= 3 → Tam Burs | Ortalama >= 75 ve devamsızlık <= 5 → Yarım Burs | Ortalama >= 60 ve devamsızlık <= 8 → Çeyrek Burs | Diğer durumlar → Burs Yok. Ekrana: Ortalama: Devamsızlık: Burs Durumu: yazdır.

            // Console.Write("Not Ortalamanız: ");
            // int averageGrade = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Devamsızlık Sayınız: ");
            // int absence = Convert.ToInt32(Console.ReadLine());

            // string scholarship;

            // if (averageGrade < 0 || absence < 0)
            //     {
            //         Console.WriteLine("Not Ortalaması / Devamsızlık Sıfırdan Küçük Olamaz.");
            //     } else
            //     {
            //         if (averageGrade >= 90 && absence <= 3)
            //         {
            //             scholarship = "Tam Burs";
            //         } else if (averageGrade >= 75 && absence <= 5)
            //         {
            //             scholarship = "Yarım Burs";
            //         } else if (averageGrade >= 60 && absence <= 8)
            //         {
            //             scholarship = "Çeyrek Burs";
            //         } else
            //         {
            //             scholarship = "Burs Yok";
            //         }
            //         Console.WriteLine(
            //             $"""
            //             Not Ortalaması: {averageGrade}
            //             Devamsızlık: {absence}
            //             Burs Durumu: {scholarship}
            //             """
            //         );
            //     }

            //? Kargo Ücreti Hesaplama Sistemi. Kullanıcıdan: Sipariş Tutarı Premium Üye mi? (E/H) al. Kurallar: 1000 TL ve üzeri → Kargo Ücretsiz | Premium üyeler → Her durumda Kargo Ücretsiz | Diğerleri → 99 TL kargo. Ekrana: Sipariş Tutarı: Premium Üye: Kargo Ücreti: Toplam Ödeme: yazdır.

            Console.Write("Sipariş Tutarınız: ");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Premium Üyelik (E/H): ");
            char premiumMember = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

            decimal shippingFee = 0m;
            decimal totalCost = 0m;
            string premiumStatus = premiumMember == 'E' ? "Üyelik Var" : "Üyelik Yok";

            if (cost <= 0)
                {
                    Console.WriteLine("Sipariş Tutarı 0₺'den az olamaz");
                } else
                {
                    if (cost < 1000 && premiumMember != 'E')
                        {
                            shippingFee = 99m;
                            totalCost = cost + shippingFee;
                        } else if (cost < 1000 && premiumMember =='E' || cost >= 1000)
                        {
                            shippingFee = 0m;
                            totalCost = cost + shippingFee;
                        } else
                        {
                            Console.WriteLine("Hatalı Giriş");
                        }
                        Console.WriteLine(
                        $"""
                        Sipariş Tutarı: {cost:C} 
                        Premium Üye: {premiumStatus}
                        Kargo Ücreti: {shippingFee:C}
                        Toplam Ödeme: {totalCost:C}
                        """
                    );
                }
        }
    }
}