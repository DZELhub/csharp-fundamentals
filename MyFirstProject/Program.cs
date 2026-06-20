using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.IO.Pipelines;
using Microsoft.VisualBasic;

{//! DERS 1
// Console.WriteLine("Merhaba Celal");
// Console.WriteLine("Bugün C# Öğreniyorum");
// Console.WriteLine("Anlık çalıştırma aktif");
}
{//! DERS 2 - Değişken Nedir?
// int x = 10;
// int y = 20;
// int total = x + y;
// Console.WriteLine(total);

// string name = "Celal Selim";
// string surname = "Binay";
// string city = "Çanakkale";
// int age = 38;

// Console.WriteLine("Ad: "+name);
// Console.WriteLine("Soyad: "+surname);
// Console.WriteLine("Şehir: "+city);
// Console.WriteLine("Yaş: "+age);
}
//! DERS 3 - Neden Değişken Kullanırız?
{// Console.WriteLine(5000);
// Console.WriteLine(4000);
// Console.WriteLine(2000);
// Console.WriteLine(5000);

//? Kdv hesabı yapalım

// Console.WriteLine(5000 * 1.18);
// Console.WriteLine(4000 * 1.18);
// Console.WriteLine(2000 * 1.18);
// Console.WriteLine(5000 * 1.18);

//* Peki ya 30 tane veri olsaydı? Her birini tek tek güncellemek zor olurdu. KDV oranı değişse her birinin hesaplaması zor olurdu.

// double kdvOrani = 0.18;

// Console.WriteLine(5000 * kdvOrani);
// Console.WriteLine(4000 * kdvOrani);
// Console.WriteLine(2000 * kdvOrani);
// Console.WriteLine(5000 * kdvOrani);

//* Ürünler içinde ayrı ayrı değişken tanımlanabilir

// double urunA = 5000;
// double urunB = 4000;
// double urunC = 2000;
// double urunD = 5000;

// Console.WriteLine(urunA * kdvOrani);
// Console.WriteLine(urunB * kdvOrani);
// Console.WriteLine(urunC * kdvOrani);
// Console.WriteLine(urunD * kdvOrani);

//? Şunu yap: 3 ürün oluştur → bir indirim oranı oluştur → ürünlerin indirimli fiyatını hesapla

// decimal discount = 0.20m;

// decimal laptop = 55000m;
// decimal laptopDiscount = laptop * discount;
// decimal laptopDiscountedPrice = laptop - laptopDiscount;

// decimal cellPhone = 45000m;
// decimal cellPhoneDiscount = cellPhone * discount;
// decimal cellPhoneDiscountedPrice = cellPhone - cellPhoneDiscount;

// decimal tv = 50000m;
// decimal tvDiscount = tv * discount;
// decimal tvDiscountedPrice = tv - tvDiscount;

// Console.WriteLine("Laptop Fiyatı: " + laptop);
// Console.WriteLine("Laptop İndirim Tutarı: " + laptopDiscount);
// Console.WriteLine("Laptop İndirimli Fiyatı: " + laptopDiscountedPrice);

// Console.WriteLine("Cep Telefonu Fiyatı: " + cellPhone);
// Console.WriteLine("Cep Telefonu İndirim Tutarı: " + cellPhoneDiscount);
// Console.WriteLine("Cep Telefonu İndirimli Fiyatı: " + cellPhoneDiscountedPrice);

// Console.WriteLine("TV Fiyatı: " + tv);
// Console.WriteLine("TV İndirim Tutarı: " + tvDiscount);
// Console.WriteLine("TV İndirimli Fiyatı: " + tvDiscountedPrice);
}
{//! DERS 4 - Değişken Tanımlama
//? Mini Challenge 🚀 Bir öğrenci sistemi oluştur: Şunları değişkenlerde tut: öğrenci adı, okul numarası, yaş, aktif öğrenci mi?, not ortalaması. Sonra hepsini ekrana yazdır.

// string studentName = "Dzelal Sokolovic";
// string schoolNumber = "302";
// int age = 18;
// bool activeStudent = true;
// double averagePoint = 85.3;

// Console.WriteLine( $"{studentName} isimli {schoolNumber} numaralı öğrenci, {age} yaşında olup. Not ortalaması {averagePoint} olmakla birlikte aktif öğrencilik durumu: {activeStudent}");
}
//! DERS 5: Değişen Uygulama
{
//? Uygulama 1: Bir öğrencinin aşağıdaki bilgileri için gerekli değişkenleri oluşturunuz. Öğrenci Adı, Öğrenci Soyadı, Öğrenci Ad ve Soyad, Öğrenci Numarası, Öğrenci Cinsiyeti, Öğrenci TC Kimlik, Öğrenci Doğum Yılı, Öğrenci Adres, Öğrenci Yaşı

// string name = "Celal Selim";
// string surname = "Binay";
// string fullName = $"{name} {surname}";
// string schoolNumber = "1330";
// bool isMale = true;
// string gender = isMale ? "Erkek" : "Kadın";
// string identityNumber = "12121212122";
// int birthYear = 1988;
// string adress = "Çanakkale";
// int age = DateTime.Now.Year - birthYear;

// Console.WriteLine($"Adı:{name}\nSoyadı:{surname}\nTam Adı: {fullName}\nOkul Numarası: {schoolNumber}\nCinsiyeti: {gender}\nTC Kimlik No: {identityNumber}\nDoğum Tarihi: {birthYear}\nAdres Bilgisi: {adress}\nYaşı: {age}");

//? Uygulama 2: Aşağıdaki ürünlerin toplam bilgisini hesaplayınız. Ürün 1: 50 TL, Ürün 2: 60.5 TL, Ürün 3: 356.45 TL

// decimal productPrice1 = 50m;
// decimal productPrice2 = 60.5m;
// decimal productPrice3 = 356.45m;
// decimal totalPrice = productPrice1 + productPrice2 + productPrice3;

// Console.WriteLine($"Toplam Tutar: {totalPrice:C}");
}
//! DERS 6: Veri Tipleri
{
    // //? Mini Challenge 🚀 Şunlar için uygun veri tiplerini seç: Oyuncunun canı,Dünya nüfusu,Ürün fiyatı,Oyuncu hareket hızı,Kullanıcı aktif mi?,Harf notu,Telefon numarası.Sonra neden o veri tipini seçtiğini açıklamaya çalış

    // int healthy = 100;
    // Console.WriteLine($"Oyuncunun Canı: {healthy}");

    // long worldPopulation = 8245000000L;
    // Console.WriteLine($"Dünya Nüfusu: {worldPopulation}");

    // decimal productPrice = 30000m;
    // Console.WriteLine($"Ürün Fiyatı: {productPrice:C}");

    // float dexterity = 76.6f;
    // Console.WriteLine($"Oyuncunun Hızı: {dexterity}");

    // bool isActive = true;
    // string status = isActive ? "Oyuncu Online" : "Oyuncu Offline";
    // Console.WriteLine($"Oyuncunun Durumu: {status}");

    // char gradeLetter = 'A';
    // Console.WriteLine($"Öğrencinin Harf Notu: {gradeLetter}");

    // string phoneNumber = "+90(532)4235820";
    // Console.WriteLine($"Telefon Numarası: {phoneNumber}"); 
}
//! DERS 7: Veri Tipleri Uygulama
{
    //? Mini Challenge 🚀 Şunları yap: Bir byte değişken oluştur ve sınırı aşmayı dene. Bir float, double ve decimal değişken oluştur. Bir char ve bir string oluştur. Şunu test et: int a = 10; int b = a; b = 99; Sonra: a ve b değerlerini yazdır ve neden farklı olduklarını açıklamaya çalış.

    // byte number = 100;
    // Console.WriteLine(number);

    // byte number2 = 255;
    // Console.WriteLine(number2);

    // byte number3 = 256; // Çalışmaz çünkü sınırı aştık
    // Console.WriteLine(number3);

    // float number4 = 12.5f;
    // Console.WriteLine(number4);

    // double number5 = 122.500;
    // Console.WriteLine(number5);

    // decimal number6 = 135400m;
    // Console.WriteLine($"{number6:C}");

    // char letter = 'C';
    // Console.WriteLine(letter);

    // string fullName = "Celal Selim Binay";
    // Console.WriteLine(fullName);

    // int a = 10;
    // int b = a;
    // Console.WriteLine(a);
    // Console.WriteLine(b);
    // b = 99;
    // Console.WriteLine(b);
}
//! DERS 8 - 9: Veri Tipi Dönüşümü
{
    //? Mini Challenge 🚀 Şunu yap: Kullanıcıdan: ad, yaş, matematik notu al. Ama: yaş → int, not → double veya decimal olarak dönüştür. Sonra şunu yazdır: Merhaba Celal Yaşınız: 25 Matematik Notunuz: 85.5. Ayrıca: not 50’den büyükse “Geçti” değilse “Kaldı” yazdır

    // Console.Write("Adınız: ");
    // string? name = Console.ReadLine();
    // Console.Write("Yaşınız: ");
    // var age = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Matematik Notunuz: ");
    // var mathGrade = Convert.ToDecimal(Console.ReadLine());
    // string isPass = mathGrade >= 50 ? "Geçti" : "Kaldı";

    // Console.WriteLine($"Merhaba {name} Yaşınız: {age} Notunuz: {mathGrade}. Dersten geçme durumunuz: {isPass}");
}
//! DERS 10: Nullable Types
{
    //? Bir çalışan sistemi oluştur: Ad, departman, maaş. Maaş bilgisi boş olabilir. Maaşı yazdır, GetValueOrDefault() kullan, ?? operatörü kullan. Kullanıcı dostu çıktı üret.

    // string name = "Celal";
    // string department = "Game Developing";
    // decimal? salary = null;
    // string hasSalary = salary == null ? "Maaş Bilgisi Yok" : "0";

    // Console.WriteLine(salary.GetValueOrDefault());
    // Console.WriteLine(salary ?? 0);
    // Console.WriteLine($"Ad: {name}\nDepartman: {department}\nMaaş: {hasSalary}");

    //? Mini Challenge 🚀 Şimdi sistemi geliştir: Bir ürün oluştur: ürün adı, stok miktarı, indirim oranı. Ama: indirim oranı boş olabilir. Sonra: indirim varsa fiyat hesapla yoksa “İndirim Yok” yazdır. ?? nullable ternary birlikte kullan 🙂

    // string? productName = "Samsung A30";
    // int? stockAmount = 200;
    // decimal? price = 50000m;
    // float? discountRate = 0.20f;

    // Console.WriteLine($"Ürün Adı: {(productName == null ? "Ürün Adı Girilmemiş":productName)}\nStok Miktarı: {stockAmount ?? 0}\nBirim Fiyatı: {price.GetValueOrDefault():C}\nİndirim Oranı: {discountRate ?? 0}\nİndirimli Fiyat: {(discountRate == null ? "İndirim Yok": price - price * Convert.ToDecimal(discountRate)):C}");
}
//! DERS 11: String Nedir?
{
    //? Mini Challenge 🚀 Kullanıcıdan: ad, soyad, şehir, yaş al. Sonra: tam ad oluştur. string interpolation kullan.kullanıcıya şöyle mesaj göster: Merhaba Celal Binay Çanakkale şehrinde yaşıyorsunuz. Yaşınız: 25. Ayrıca: yaş bilgisini int’e dönüştür 🙂

    // Console.Write("Adınız: ");
    // string? name =
    //     Console.ReadLine();

    // Console.Write("Soyadınız: ");
    // string? surname =
    //     Console.ReadLine();

    // Console.Write("Yaşadığınız Şehir: ");
    // string? city = 
    //     Console.ReadLine();

    // Console.Write("Yaşınız: ");
    // var age = 
    //     Convert.ToInt32(Console.ReadLine());

    // string fullName = 
    //     $"{name} {surname}";

    // string message = 
    //     $"Merhaba {fullName}\n" +
    //     $"{city} şehrinde yaşıyorsunuz.\n" +
    //     $"Yaşınız: {age}";

    // Console.WriteLine(message);

}
//! DERS 12: String Metotları?
{
    //? Kullanıcıdan cümle al. Kaç karakter, Büyük harf versiyonu, Küçük harf versiyonu, içinde "C#" geçiyor mu, ilk 5 karakter, boşluk temizle.

    // Console.Write("Bir Cümle Giriniz: ");
    // string? sentence = 
    //     Console.ReadLine();
    // Console.WriteLine(sentence);

    // int letter = 
    //    sentence.Length;
    // Console.WriteLine(letter);

    // string upperCase = 
    //     sentence.ToUpper();
    // Console.WriteLine(upperCase);

    // string lowerCase =
    //     sentence.ToLower();
    // Console.WriteLine(lowerCase);

    // bool contain = 
    //     sentence.Contains("C#");
    // string message = $"Cümle içinde 'C#' {(contain ? "bulunuyor" : "bulunmuyor")}";
    // Console.WriteLine(message);

    // string firstFiveChar =
    //     sentence.Substring(0, 5);
    // Console.WriteLine(firstFiveChar);

    // string removeSpace =
    //     sentence.Trim();
    // Console.WriteLine(removeSpace);

}
//! DERS 13: Strings Uygulama
{
    // string course = ".NET10 ile C# Programlama Dili";

    // //? Kaç karaktere sahip?
    // //? Hepsini küçük harf yap.
    // //? '.' ile mi başlıyor?
    // //? C# bilgisinin konumu nedir?
    // //? 'C#' bilgisini içeriyor mu?
    // //? 'Dili' yerine 'Dersleri' yazınız.

    // int characterCount = 
    //     course.Length;
    // Console.WriteLine(
    //     $"Karakter Sayısı: {characterCount}"
    // );

    // string lowerCase =
    //     course.ToLower();
    // Console.WriteLine(
    //     $"Küçük harf: {lowerCase}"
    // );

    // bool isStartsWithDot = 
    //     course.StartsWith('.');
    // Console.WriteLine(
    //     $"Cümle '.' ile {(isStartsWithDot == true ? "başlıyor" : "başlamıyor")}"
    // );

    // int whereIsCSharp =
    //     course.IndexOf("C#");
    // Console.WriteLine(
    //     $"'C#' değerinin cümle içindeki konumu {whereIsCSharp} indexi ile başlar"
    // );

    // bool isContainCSharp =
    //     course.Contains("C#");
    // Console.WriteLine(
    //     $"Cümle 'C#' değerini {(isContainCSharp == true ? "içeriyor" : "içermiyor")}"
    // );

    // string updatedCourseName =
    //     course.Replace("Dili","Dersleri");
    // Console.WriteLine(
    //     $"Kursun güncel adı: {updatedCourseName}"
    // );
}
//! DERS 14: DateTime
{
    //? Mini Challenge 1 — Yaş Hesaplama: Kullanıcıdan: doğum yılını al. Sonra: mevcut yılı kullan, yaşını hesapla, ekrana yazdır.

    // Console.Write(
    //     "Doğum Yılınız: "
    // );
    // var birthYear = Convert.ToInt32(Console.ReadLine());

    // int currentYear = DateTime.Now.Year;
    // int age = currentYear - birthYear;

    // Console.WriteLine(
    //     $"Doğum Yılınız: {birthYear}\n" +
    //     $"Yaşınız: {age}"
    // );

    //? Bir etkinlik tarihi oluştur: DateTime eventDate = new DateTime(2026, 12, 31); Sonra: bu tarihe 30 gün ekle, 2 ay ekle,1 yıl ekle, ve sonuçları yazdır.

    // DateTime eventDate = new DateTime(2026, 5, 9);
    // DateTime updatedEventDate = eventDate.AddDays(30);
    // DateTime updatedEventDate2 = updatedEventDate.AddMonths(2);
    // DateTime updatedEventDate3 = updatedEventDate2.AddYears(1);

    // Console.WriteLine(
    //     $"Etkinlik Tarihi: {eventDate}\n" +
    //     $"Etkinlik Tarihi Güncelleme 1: {updatedEventDate}\n" +
    //     $"Etkinlik Tarihi Güncelleme 2: {updatedEventDate2}\n" +
    //     $"Etkinlik Tarihi Güncelleme 3: {updatedEventDate3}" 
    // );
}
//! DERS 15: Diziler
{
    //? 5 elemanlı bir string dizisi oluştur: şehir isimleri ekle ve tüm elemanları yazdır.

    // string[] cities = new string[5];

    // cities[0] = "Sarajevo";
    // cities[1] = "Budapest";
    // cities[2] = "Moscow";
    // cities[3] = "Minsk";
    // cities[4] = "İstanbul";

    // Console.WriteLine(
    //     $"Şehir 1: {cities[0]}\n" +
    //     $"Şehir 2: {cities[1]}\n" +
    //     $"Şehir 3: {cities[2]}\n" +
    //     $"Şehir 4: {cities[3]}\n" +
    //     $"Şehir 5: {cities[4]}\n" 
    // );

    //? 3 elemanlı int dizisi oluştur. Notları ekle ve ortalamayı hesapla.

    // int[] grades = [60, 80, 90];
    // int gradeCount = grades.Length;
    // int average = (grades[0] + grades[1] + grades[2]) / gradeCount;
    // Console.WriteLine(
    //     $"Not 1: {grades[0]} \n" +
    //     $"Not 2: {grades[1]} \n" +
    //     $"Not 3: {grades[2]} \n" +
    //     $"Ortalama: {average}" 
    // );

    //? 2x2 çok boyutlu dizi oluştur: tüm elemanları tek tek yazdır.

    // int[,] numbers = new int[2,2];

    // numbers[0,0] = 1;
    // numbers[0,1] = 2;
    // numbers[1,0] = 3;
    // numbers[1,1] = 4; 

    // Console.WriteLine(
    //     $"{numbers[0,0]} {numbers[0,1]}\n" +
    //     $"{numbers[1,0]} {numbers[1,1]}"
    // );
}
//! DERS 16: Dizi Tanımlama
{
    //? 5 elemanlı bir string dizisi oluştur. İçine: film isimleri ekle. Sonra: ✅ ilk filmi yazdır,✅ son filmi yazdır,✅ toplam kaç film olduğunu yazdır,✅ bütün film isimlerini tek tek yazdır.

    // string[] movies = {"Lord of the Rings","Harry Potter","Shawshank Redemption", "John Wick","Matrix"};

    // Console.WriteLine(
    //     $"İlk Film: {movies[0]}\n" +
    //     $"Son Film: {movies[movies.Length-1]}\n" +
    //     $"Film Sayısı: {movies.Length}"
    // );

    // Console.Write("Filmler: ");
    // for (int i = 0; i < movies.Length; i++)
    // {
    //     Console.WriteLine(movies[i]);
    // }

    //? Mini Challenge 2 — Kelime Analizi 🚀 Kullanıcıdan bir cümle al. Sonra: ✅ Split(" ") kullan ✅ kaç kelime olduğunu göster, ✅ ilk kelimeyi yazdı,✅ son kelimeyi yazdır, ✅ bütün kelimeleri tek tek yazdır

    // Console.Write("Bir Cümle Yazınız: ");
    // string? sentence = Console.ReadLine();

    // string[] sentencesPart = sentence.Split(" ");

    // int sentencesPartLength = sentencesPart.Length;

    // string firstWord = sentencesPart[0];
    // string lastWord = sentencesPart[sentencesPart.Length-1];

    // Console.WriteLine(
    //     $"Kaç Kelime: {sentencesPartLength}\n" +
    //     $"İlk Kelime: {firstWord}\n" +
    //     $"Son Kelime: {lastWord}"
    // );
    // Console.WriteLine("\nKelimeler:");
    // for (int i = 0; i < sentencesPart.Length; i++)
    // {
    //     Console.WriteLine(
    //         $"{i+1}. {sentencesPart[i]}"
    //     );
    // };
    
}
//! DERS 17: Dizi Metotları
{
    // string[] cities = {"İstanbul","Çanakkale","Bursa"};
    // Console.WriteLine(cities[1]);
    
    // cities[1] = "Budapeşte";
    // Console.WriteLine(cities[1]);

    // cities.SetValue("Saraybosna",1);
    // Console.WriteLine(cities[1]);

    // Console.WriteLine(cities.GetValue(1));

    // Console.WriteLine(cities.Length);

    // Console.WriteLine(Array.IndexOf(cities, "Çanakkale"));

    // Array.Sort(cities);
    // Console.WriteLine(cities[1]);
    // Console.WriteLine(cities[0]);
    // Array.Reverse(cities);
    // Console.WriteLine(cities[0]);

    // Array.Clear(cities);
    // Console.WriteLine(cities[0]);
    // Console.WriteLine(cities[1]);
    // Console.WriteLine(cities[2]);

    // cities.SetValue("Saraybosna",0);
    // cities.SetValue("Budapeşte",1);
    // cities.SetValue("İstanbul",2);
    // Console.WriteLine(cities[0]);
    // Console.WriteLine(cities[1]);
    // Console.WriteLine(cities[2]);

    //? Mini Challenge 1 — Öğrenci Sistemi 🎓 5 elemanlı bir string dizisi oluştur. İçine öğrenci isimleri ekle. Sonra: ✅ bütün öğrencileri yazdır ✅ alfabetik sırala Array.Sort) ✅ tekrar yazdır ✅ ters çevir (Array.Reverse) ✅ tekrar yazdır ✅ "Ahmet" isimli öğrenci var mı kontrol et (Array.IndexOf)

    // string[] students = {"Selim", "Hande", "Yüsra","Cihat","Ali"};
    // Console.WriteLine("Öğrenci Listesi");
    // for (int i = 0; i < students.Length; i++)
    // {
    //     Console.WriteLine(
    //         $"{i+1}." +
    //         $"{students[i]}"
    //     );
    // }

    // Array.Sort(students);
    // Console.WriteLine("Öğrenci Listesi");
    // for (int i = 0; i < students.Length; i++)
    // {
    //     Console.WriteLine(
    //         $"{i+1}." +
    //         $"{students[i]}"
    //     );
    // }

    // Array.Reverse(students);
    // Console.WriteLine("Öğrenci Listesi");
    // for (int i = 0; i < students.Length; i++)
    // {
    //     Console.WriteLine(
    //         $"{i+1}." +
    //         $"{students[i]}"
    //     );
    // }

    // string name = "Ahmet";
    // int searchIndex = Array.IndexOf(students, name);
    // string searchStudent = searchIndex == -1 ? "mevcut değil" : "mevcut";
    // Console.WriteLine(
    //     $"{name} isimli öğrenci listede {searchStudent}"
    // );
}
//! DERS 18: Array Slicing
{
    // string[] cities = {"Budapest","Moscow","Minsk","Sarajevo","Berlin","Bucharest","İstanbul"};
    // Console.WriteLine(cities.Length);
    // foreach(var i in cities) {
    //     Console.WriteLine(i);
    // }

    // string[] result = cities[0..3]; 
    // Console.WriteLine(result.Length);
    // foreach(var i in result) {
    //     Console.WriteLine(i);
    // }

    // //or

    // string[] result2 = cities[..4];
    // Console.WriteLine(result2.Length);

    // string[] result3 = cities[2..];
    // Console.WriteLine(result3.Length);
}
//! DERS 19: Diziler Uygulama
{
    //? Öğrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 Öğrenci). Öğrenciler dizisi kaç elemanlıdır yazdırınız. İlk 2 öğrencinin ad ve not bilgisini yazdırınız. Tüm öğrencilerin not ortalaması nedir?

    // Console.Write("1. Öğrenci: ");
    // string? student1 = Console.ReadLine();
    // Console.Write("1. Not: ");
    // int grade1 = Convert.ToInt32(Console.ReadLine());
    
    // Console.Write("2. Öğrenci: ");
    // string? student2 = Console.ReadLine();
    // Console.Write("2. Not: ");
    // int grade2 = Convert.ToInt32(Console.ReadLine());

    // Console.Write("3. Öğrenci: ");
    // string? student3 = Console.ReadLine();
    // Console.Write("3. Not: ");
    // int grade3 = Convert.ToInt32(Console.ReadLine());


    // string[] students = {student1 ?? string.Empty, student2 ?? string.Empty, student3 ?? string.Empty};
    // int[] grades = {grade1, grade2, grade3};

    // Console.WriteLine(
    //     $"Öğrenciler dizisinin uzunluğu: {students.Length}"
    // );

    // Console.WriteLine(
    //     $"1. Öğrencinin Adı: {students[0]}\n" +
    //     $"1. Öğrencinin Notu: {grades[0]}\n" +
    //     $"2. Öğrencinin Adı: {students[1]}\n" +
    //     $"2. Öğrencinin Notu: {grades[1]}"
    // );

    // double total = 0;
    // foreach (var grade in grades)
    // {
    //     total += grade;
    // }
    // Console.WriteLine(
    //     $"Öğrencilerin Not Ortalaması: {total / grades.Length}"
    // );

    //? Görev 1) 5 ürün adı ve fiyatı al: string[] products, decimal[] prices oluştur. Sonra: ✅ tüm ürünleri listele ✅ en pahalı ürünü bul ✅ ortalama fiyatı hesapla

    // string[] products = {"Iphone","Samsung","Vestel","Huawei","GM"};
    // decimal[] prices = {90000m, 75000m, 35000m, 55000m, 60000m};

    // for (int i = 0; i < products.Length && i < prices.Length; i++)
    // {
    //     Console.WriteLine($"{products[i]} : {prices[i]:C}");
    // }
    
    // decimal expensive = 0m;
    // string product = "";
    // for (int i = 0; i < prices.Length; i++)
    // {
    //     if (prices[i] > expensive)
    //     {
    //         expensive = prices[i];
    //         product = products[i];
    //     }
    // }
    // Console.WriteLine(
    //     $"En Pahalı Ürün:\n" +
    //     $"{product} : {expensive:C}"
    // );

    // decimal total = 0m;
    // foreach (var price in prices)
    // {
    //     total += price;
    // }
    // Console.WriteLine(
    //     $"Ortalama Fiyat: {total / prices.Length:C}"
    // );
    
    //? Görev 2 🚀 Bir cümle al. Sonra: ✅ Split() ile kelimelere ayır ✅ alfabetik sırala (Array.Sort) ✅ ters çevir (Array.Reverse) ✅ tekrar yazdır

    // Console.Write("Lütfen bir cümle giriniz: ");
    // string? sentence = Console.ReadLine();
    // string cleanSentence = (sentence ?? "").Trim();

    // string[] words = (cleanSentence ?? "").Split(" ");
    
    // Array.Sort(words);
    // Console.WriteLine("Alfabetik Düzen:");
    // foreach (var word in words)
    // {
    //     Console.WriteLine(
    //         word
    //     );
    // }

    // Array.Reverse(words);
    // Console.WriteLine("Ters Düzen:");
    // foreach (var word in words)
    // {
    //     Console.WriteLine(
    //         word
    //     );
    // }
}
//! DERS 20: Çok Boyutlu Diziler
{
    // string[] students = {"Selim","Hande","Yüsra"};
    // decimal [,] grades = new decimal[3,3];
    // // Selim
    // grades[0,0] = 50m;
    // grades[0,1] = 60m;
    // grades[0,2] = 70m;
    // // Hande
    // grades[1,0] = 60m;
    // grades[1,1] = 80m;
    // grades[1,2] = 90m;
    // // Yüsra
    // grades[2,0] = 50m;
    // grades[2,1] = 70m;
    // grades[2,2] = 30m;
    // // Average Calculation
    // decimal averageGrade1 = (grades[0,0] + grades[0,1] + grades[0,2]) / 3;
    // decimal averageGrade2 = (grades[1,0] + grades[1,1] + grades[1,2]) / 3;
    // decimal averageGrade3 = (grades[2,0] + grades[2,1] + grades[2,2]) / 3;

    // Console.WriteLine(
    //     $"{students[0]} isimli öğrencinin not ortalaması: {averageGrade1}\n" +
    //     $"{students[1]} isimli öğrencinin not ortalaması: {averageGrade2}\n" +
    //     $"{students[2]} isimli öğrencinin not ortalaması: {averageGrade3}"
    // );

    //? Mini Challenge 1 🚀 3 öğrenci için: ✅ 2 sınav notu gir ✅ her öğrencinin ortalamasını hesapla ✅ geçen/kalan bilgisini yazdır.

    // string[] students = {"Selim","Hande","Yüsra"};
    // decimal[,] grades = new decimal[3,2];

    // // Selim
    // grades[0,0] = 45m;
    // grades[0,1] = 50m;
    // // Hande
    // grades[1,0] = 90;
    // grades[1,1] = 100;
    // // Yüsra
    // grades[2,0] = 100;
    // grades[2,1] = 90;

    // for (int i = 0; i < students.Length; i++)
    // {
    //     decimal total = 0;
    //     for (int j = 0; j < 2; j++)
    //     {
    //         total += grades[i,j];
    //     }
    //     decimal average = total / 2;

    //     Console.WriteLine(
    //         $"{students[i]} : " +
    //         $"{average}\n" +
    //         $"{students[i]} Dersten {(average < 50 ? "Kaldı":"Geçti")}"
    //     );
        
    // }

    //? Mini Challenge 2 🚀 2x3 int dizisi oluştur: 1 2 3 4 5 6 Sonra: ✅ tüm elemanları yazdır ✅ bütün sayıların toplamını hesapla ✅ en büyük sayıyı bul

    // int[,] numbers = new int[2,3];
    
    // // First Line
    // numbers[0,0] = 1;
    // numbers[0,1] = 2;
    // numbers[0,2] = 3;
    // // Second Line
    // numbers[1,0] = 4;
    // numbers[1,1] = 5;
    // numbers[1,2] = 6;

    // int total = 0;
    // int biggestNumber = numbers[0,0];
    // foreach (var number in numbers)
    // {
    //     Console.WriteLine(number);
    //     total += number;
    //     if (number > biggestNumber)
    //     {
    //         biggestNumber = number;
    //     }
    // }
    // Console.WriteLine(
    //     $"Toplam: {total}\n" +
    //     $"En Büyük Numara: {biggestNumber}"
    // );
}
//! DERS 21: Referans Tipler
{
    // int[] x = {10,20};
    // int[] y = x;

    // Console.WriteLine(x[0]); // 10
    // Console.WriteLine(y[0]); // 10

    // x[0] = 20;

    // Console.WriteLine(x[0]); // 20
    // Console.WriteLine(y[0]); // 20
}
//! DERS 22: Operatörler
{
    // int a = 10;
    // int b = 5;
    // int c = 21;

    // int result = a + b;
    // int result = a - b;
    // int result = a * b;
    // int result = a / b;
    // int result = (a + b) * c;
    // int result = a % b;
    // int result = c % b;
    // int result = a++;
    // int result = ++a;

    // Console.WriteLine(result);

    //? Mini Challenge 1 🚀 Bir ürün fiyatı oluştur: ✅ KDV ekle ✅ indirim uygula ✅ son fiyatı hesapla

    // decimal price = 10000m;
    // decimal taxRate = 0.18m;
    // decimal discountRate = 0.20m;

    // decimal priceWithTax = price + (price * taxRate);
    // decimal discountedPrice = priceWithTax - (priceWithTax * discountRate);

    // Console.WriteLine(
    //     $"Fiyat: {price:C}\n" +
    //     $"KDV Oranı: {taxRate:P}\n" +
    //     $"KDV Dahil Fiyat: {priceWithTax:C}\n" +
    //     $"İndirim Oranı: {discountRate:P}\n" +
    //     $"İndirimli Fiyat: {discountedPrice:C}"

    // );

    //? Mini Challenge 2 🚀 Bir sayı oluştur. Sonra: ✅ çift mi tek mi kontrol et (%) ✅ 5’e tam bölünüyor mu kontrol et ✅ sayıyı 1 artır ✅ sayıyı 1 azalt

    // Console.Write("Bir Sayı Giriniz: ");
    // int number = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine(number);
    // string oddEven = number % 2 == 0 ? "Çift" : "Tek";
    // string multipleOf5 = number % 5 == 0 ? "bölünür" : "bölünmez";
    // int addition1 = number+1;
    // Console.WriteLine($"{number}+1= {addition1}");
    // int minus1 = number-1;
    // Console.WriteLine($"{number}-1= {minus1}");
    

    // Console.WriteLine(
    //     $"Sayı {oddEven}\n" +
    //     $"Sayı 5'e tam {multipleOf5}\n"      
    // );
}
//! DERS 23: Aritmetik Operatör Uygulamaları
{
    //? a=10, b=5, c=20 ise c - a b'nin kaç katıdır?

    // int a = 10;
    // int b = 5;
    // int c= 20;

    // int cMinusA = c - a;
    // int multiplier = cMinusA / b;

    // Console.WriteLine(
    //     $"{c} - {a} = {cMinusA}\n" +
    //     $"{cMinusA}, {b}'in {multiplier} katıdır"
    // );

    //? int? a = 50, int b = 20 ise a + b kaçtır? a null ise sonuç nedir?

    // int? a = 50;
    // int b = 20;
    // int total = (a ?? 0) + b;

    // Console.WriteLine(
    //     $"a + b = {total}"
    // );

    // // a null gelirse sonuç 20 olur çünkü null değer gelirse 0 kabul edeceğiz.

    //? a = 10 b = 20 ise a=b--; atamasından sonra a ve b değerleri ne olur?
    // a'ya önce b'yi atayıp bden sonra çıkarma işlemi yaptığımız için a = 20 b = 19 olur

    // int a = 10;
    // int b = 20;

    // a = b--;

    // Console.WriteLine(
    //     $"a = {a}\n" +
    //     $"b = {b}"
    // );

    //? Klavyeden girilen sayının tek/çift kontrolünü yapınız?

    // Console.Write("Bir sayı giriniz: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // string oddEven = number % 2 == 0? "çift":"tek";

    // Console.WriteLine(
    //     $"{number} sayısı {oddEven} sayıdır."
    // );
}
//! DERS 24: Atama Operatörleri
{
    // int a = 5;
    // int b = 10;

    // a += b;
    // a -= b;
    // a *= b;
    // a /= b;
    // a %= b;

    // Console.WriteLine(a);

    // //? Math

    // double sonuc;

    // sonuc = Math.Pow(2,3); // Üssünü alma
    // sonuc = Math.Sqrt(25); // Karekök alma
    // sonuc = Math.Abs(-10); // İşaret değiştirme
    // sonuc = Math.Round(4.5); // Yuvarlama
    // sonuc = Math.Ceiling(4.4); // Yukarı yuvarlama
    // sonuc = Math.Floor(4.6); // Aşağı yuvarlama
    // sonuc = Math.Max(10,20); // Büyük olan
    // sonuc = Math.Min(30,40); // Küçük olan

    // Console.WriteLine(sonuc);

    //? Mini Challenge 1 🚀: Bir ürün fiyatı tanımla: decimal price = 13749.99m; Sonra: ✅ %18 KDV ekle ✅ Sonucu 2 basamak yuvarla ✅ Ekrana yazdır

    // decimal price = 13749.99m;
    // decimal kdv = 0.18m;

    // price += price*kdv;

    // decimal roundedPrice = Math.Round(price,2);

    // Console.WriteLine(roundedPrice);

    //? Mini Challenge 2 🚀: Kullanıcıdan iki sayı al. Sonra: ✅ Büyük olanı bul (Math.Max) ✅ Küçük olanı bul (Math.Min) ✅ Birinci sayının mutlak değerini bul (Math.Abs) ✅ Birinci sayının karekökünü hesapla (Math.Sqrt) Karekök almadan önce sayının negatif olup olmadığını kontrol etmeyi dene. Bu sana ileride if konusuna hazırlık yapacak.

    // Console.Write("Bir Sayı Giriniz: ");
    // int number1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Bir Sayı Daha Giriniz: ");
    // int number2 = Convert.ToInt32(Console.ReadLine());

    // int bigger = Math.Max(number1, number2);
    // int smaller = Math.Min(number1, number2);
    // int absoluteValue = Math.Abs(number1);

    // bool isNegative = number1 < 0;
    // string status = isNegative == false ? "Pozitif" : "Negatif";
    // string squareRoot = isNegative ? "Hesaplanamaz" : Math.Sqrt(number1).ToString();

    // Console.WriteLine(
    //     $"Büyük Sayı: {bigger}\n" +
    //     $"Küçük Sayı: {smaller}\n" +
    //     $"Birinci Sayının Mutlak Değeri: {absoluteValue}\n" +
    //     $"Birinci Sayının Durumu: {status}\n" +
    //     $"Birinci Sayının Karekökü: {squareRoot}"
    // );

    //? Kullanıcıdan bir sayı al. Sonra: karesini hesapla (Math.Pow) küpünü hesapla (Math.Pow) karekökünü hesapla (Math.Sqrt)

    // Console.Write("Bir Sayı Giriniz: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // double square = Math.Pow(number,2);
    // double cube = Math.Pow(number, 3);
    // double squareRoot = Math.Sqrt(number);

    // Console.WriteLine(
    //     $"{number} sayısının;\n" +
    //     $"Karesi: {square}\n" +
    //     $"Küpü: {cube}\n" +
    //     $"Karekökü: {squareRoot}"
    // );

    //? Görev 2 🚀 Bir ürün fiyatı tanımla: decimal price = 23456.789m; Sonra: aşağı yuvarla (Math.Floor) yukarı yuvarla (Math.Ceiling) 2 basamak yuvarla (Math.Round(price, 2)) ve üç sonucu da karşılaştırarak yazdır.

    // decimal price = 23456.789m;

    // decimal floor = Math.Floor(price);
    // decimal ceiling = Math.Ceiling(price);
    // decimal roundedTwo = Math.Round(price,2);

    // Console.WriteLine(
    //     $"Ürün Fiyatı: {price:C}\n" +
    //     $"Aşağı Yuvarlanmış Fiyat: {floor:C}\n" +
    //     $"Yukarı Yuvarlanmış Fiyat: {ceiling:C}\n" +
    //     $"2 Basamak Yuvarlanmış Fiyat: {roundedTwo:C}"
    // );

    //? Görev 1 🚀 Bir öğrencinin: double vize = 67.4; double final = 78.8; notları olsun. Ortalama hesapla Sonucu Math.Round(..., 1) ile 1 basamağa yuvarla Ekrana yazdır

    // double midtermExam = 67.4;
    // double finalExam = 78.8;

    // double averageGrade = (midtermExam + finalExam) / 2;

    // double roundedGrade = Math.Round(averageGrade, 1);

    // Console.WriteLine(
    //     $"""
    //     Vize Notu: {midtermExam}
    //     Final Notu: {finalExam}
    //     Not Ortalaması: {averageGrade}
    //     Yuvarlanmış Ortalama: {roundedGrade}
    //     """
    // );

    //? Görev 2 🚀 Kullanıcıdan bir sayı al. Mutlak değerini bul Karesini bul Sayının 3 ile bölümünden kalanı bul (%) Sayıyı 5 artır (+=) Son sonucu ekrana yazdır

    // Console.Write("Bir Sayı Giriniz: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // double absoluteValue = Math.Abs(number);
    // double square = Math.Pow(number,2);
    // double moduloBy3 = number % 3;
    // int increasedNumber =
    // number;
    // increasedNumber += 5;

    // Console.WriteLine(
    //     $"""
    //     Girilen Değer: {number}
    //     Mutlak Değer: {absoluteValue}
    //     Karesi: {square}
    //     3 ile bölümünden kalan: {moduloBy3};
    //     5 artırılmış hali: {increasedNumber}
    //     """
    // );

    //? Mini Challenge 3 🚀 Bir ürün için: decimal price = 18599.95m; Tanımla. Sonra: %18 KDV ekle %10 indirim uygula Sonucu 2 basamak yuvarla İndirim tutarını hesapla KDV tutarını hesapla Hepsini ekrana yazdır.

    // decimal price = 18599.95m;
    // decimal taxRate = 0.18m;
    // decimal taxAmount = price * taxRate;
    // decimal priceWithTax = price; 
    // priceWithTax += taxAmount;
    // decimal discountRate = 0.10m;
    // decimal discountAmount = priceWithTax * discountRate;
    // decimal discountedPrice = priceWithTax; 
    // discountedPrice -= discountAmount;
    // double roundedTwo = Math.Round(Convert.ToDouble(discountedPrice), 2);

    // Console.WriteLine(
    //     $"""
    //     Ürün Fiyatı: {price:C}
    //     Vergi Oranı: {taxRate:P}
    //     Vergi Tutarı: {taxAmount:C}
    //     Vergi Dahil Fiyat: {priceWithTax:C}
    //     İndirim Oranı: {discountRate:P}
    //     İndirim Tutarı: {discountAmount:C}
    //     İndirimli Fiyat: {discountedPrice:C}
    //     2 Basamak Yuvarlanmış Fiyat: {roundedTwo:C}
    //     """
    // );
}
//! DERS 25: Karşılaştırma Operatörleri
{
    // int a = 5, b = 5, c = 10, d = 3;

    // bool result = a == b;
    // Console.WriteLine(result);
    // bool result2 = c == d;
    // Console.WriteLine(result2);

    // string userName = "DZEL";
    // string password = "sHy889122";

    // bool result3 = userName == "DZELAL";
    // bool result4 = password == "sHy889122";

    // string permission1 = result3 ? "Kullanıcı Adı Doğru" : "Kullanıcı Adı Yanlış"; 
    // Console.WriteLine(permission1);
    // string permission2 = !result4 ? "Şifre Yanlış" : "Şifre Doğru";
    // Console.WriteLine(permission2);

    // string permission = result3 ? "Kullanıcı Adı Doğru": !result4 ? "Şifre Yanlış" : "Kullanıcı Adı Yanlış, Şifre Doğru";
    // Console.WriteLine(permission);

    // Console.WriteLine(result3);
    // Console.WriteLine(result4);

    // bool result5 = a!= b;
    // bool result6 = b >= d;
    // bool result7 = a > c;
    
    // Console.WriteLine(result5);
    // Console.WriteLine(result6);
    // Console.WriteLine(result7);

    //? Mini Challenge 1 🚀 Bir öğrencinin notunu tanımla: int grade = 75; Sonra: not 50'den büyük mü? not 100'e eşit mi? not 0'dan küçük mü? Sonuçları ekrana yazdır.

    // Console.Write("Lütfen Notunuzu Giriniz: ");
    // int grade = Convert.ToInt32(Console.ReadLine());

    // bool greaterThan50 = grade > 50;
    // string greaterResult = greaterThan50 ? "50'den Büyüktür": "50'den Küçüktür";
    // bool equalTo100 = grade == 100;
    // string equalResult = equalTo100 ? "100'e Eşittir" : "100'e Eşit Değildir";
    // bool lessThanZero = grade < 0;
    // string lessResult = lessThanZero ? "0'dan Küçüktür" : "0'dan Büyüktür";

    // Console.WriteLine(
    //     $"""
    //     Notunuz: {grade};
    //     {greaterResult}
    //     {equalResult}
    //     {lessResult}
    //     """
    // );

    //? Mini Challenge 2 🚀 Kullanıcı adı ve şifre oluştur: string userName = "celal"; string password = "12345"; Sonra: string enteredUserName string enteredPassword oluştur. Karşılaştır: == kullan. Şunları yazdır: Kullanıcı adı doğru mu? Şifre doğru mu? İkisi de doğru mu?

    // string userName = "celal"; 
    // string password = "12345";

    // Console.Write("Kullanıcı Adınız: ");
    // string enteredUserName = Console.ReadLine() ?? string.Empty;

    // Console.Write("Şifreniz: ");
    // string enteredPassword = Console.ReadLine() ?? string.Empty;

    // bool userNameControl = enteredUserName == userName;
    // bool passwordControl = enteredPassword == password;
    // bool permissionControl = enteredUserName == userName && enteredPassword == password;

    // string userNameStatus = userNameControl ? "Doğru" : "Hatalı";
    // string passwordStatus = passwordControl ? "Doğru" : "Hatalı";
    // string permissionStatus = permissionControl ? "Kullanıcı Adı ve Şifre Doğru" : "Kullanıcı Adı veya Şifre Hatalı";

    // Console.WriteLine(
    //     $"""
    //     Girdiğiniz Kullanıcı Adı: {enteredUserName}
    //     Girdiğiniz Şifre: {enteredPassword}
    //     Kullanıcı Adınız {userNameStatus}
    //     Şifreniz {passwordStatus}
    //     Giriş Bilgileriniz: {permissionStatus}
    //     """
    // );

    //? Ek Pratik 🚀 Bu konu için sana bir görev daha bırakıyorum: int age = 19; Şunları kontrol et: Yaş 18 veya daha büyük mü? Yaş 65'ten küçük mü? Yaş tam olarak 30 mu? Yaş 18 ile 65 arasında mı? Sonuçları bool olarak ekrana yazdır.

    // Console.Write("Yaşınız: ");
    // int age = Convert.ToInt32(Console.ReadLine());

    // bool greaterThan18 = age >= 18;
    // string graterControl = greaterThan18 ? "Büyük veya Eşit" : "Küçük";
    // bool lessThan65 = age < 65;
    // string lessControl = lessThan65 ? "Küçük" : "Büyük veya Eşit";
    // bool equalTo30 = age == 30;
    // string equalControl = equalTo30 ? "Eşit" : "Eşit Değil";
    // bool rangeOf18to65 = age > 18 && age < 65;
    // string rangeControl = rangeOf18to65 ? "Arasında" : "Arasında Değil";

    // // Bool Answer
    // Console.WriteLine(
    //     $"""
    //     Yaşınız 18'den Büyük veya Eşit Mi?: {greaterThan18}
    //     Yaşınız 65'ten Küçük Mü?: {lessThan65}
    //     Yaşınız 30'a Eşit Mi?: {equalTo30};
    //     Yaşınız 18 ile 65 Arasında Mı?: {rangeOf18to65}  
    //     """
    // );

    // // User Friendly Answer
    // Console.WriteLine(
    //     $"""
    //     Yaşınız 18'den {graterControl}
    //     Yaşınız 65'ten {lessControl}
    //     Yaşınız 30'a {equalControl}
    //     Yaşınız 18 ile 65 {rangeControl}  
    //     """
    // );

    //? Mini Geliştirme Görevi 🔥 Bunu bir üst seviyeye taşı: Yaşına göre kategori yaz: - 0–12 → Çocuk - 13–17 → Genç - 18–64 → Yetişkin - 65+ → Yaşlı

    // Console.Write("Yaşınız: ");
    // int age = Convert.ToInt32(Console.ReadLine());

    // string ageCategory = age >= 0 && age <= 12 ? "Child" : age >= 13 && age <= 17 ? "Teen" : age >= 18 && age <= 64 ? "Adult" : age >= 65 && age <=100 ? "Old" : "Wrong Entry";

    // Console.WriteLine(
    //     $"Yaş Kategoriniz: {ageCategory}"
    // );
}
//! DERS 26: Karşılaştırma Operatörleri Uygulama
{
    //? Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.

    // Console.Write("Yaşınız: ");
    // int age = Convert.ToInt32(Console.ReadLine());

    // string voteStatus = age >= 18 ? "Oy Kullanabilirsiniz" : "Oy Kullanamazsınız";

    // Console.WriteLine(
    //     $"Oy Kullanma Durumunuz: {voteStatus}"
    // );

    //? Klavyeden girilen sayının işaretini ve tek/çift durumunu kontrol ediniz.

    // Console.Write("Bir Sayı Giriniz: ");
    // int number = Convert.ToInt32(Console.ReadLine());

    // string positiveNegative = number == 0 ? "0" : number > 0 ? "Pozitif" : "Negatif";
    // string evenOdd = number == 0 ? "0": number % 2 == 0 ? "Çift Sayı" : "Tek Sayı";

    // Console.WriteLine(
    //     $"""
    //     Girmiş olduğunuz sayı: {positiveNegative}
    //     Girmiş olduğunuz sayı: {evenOdd}
    //     """
    // );
}
//! DERS 27: Mantıksal Operatörler
{
    // bool a = true;
    // bool b = true;
    // bool c = false;
    // bool d = false;

    // bool result = (a && b);
    // bool result1 = (a && c);
    // bool result2= (c && d);

    // Console.WriteLine(result);
    // Console.WriteLine(result1);
    // Console.WriteLine(result2);

    // bool result3 = (a || b);
    // bool result4 = (c || b);
    // bool result5 = (c || d);

    // Console.WriteLine(result3);
    // Console.WriteLine(result4);
    // Console.WriteLine(result5);

    // bool result6 = !(a || b);
    // bool result7 = !(c || b);
    // bool result8 = !(c || d);

    // Console.WriteLine(result6);
    // Console.WriteLine(result7);
    // Console.WriteLine(result8);

    //? Mini Challenge 1 🚀 Bir kullanıcının: bool hasMembership = true; bool paidSubscription = false; değerleri olsun. Kontrol et: Üyeliği var mı ve aboneliği var mı? Üyeliği var mı veya aboneliği var mı? İkisinin de olmadığı durum nedir? Sonuçları yazdır.

    // bool hasMembership = true;
    // bool paidSubscription = false;

    // bool memberAndSubscripton = hasMembership && paidSubscription;
    // bool memberOrSubscription = hasMembership || paidSubscription;
    // bool notMemberAndSubscription = !hasMembership && paidSubscription;

    // Console.WriteLine(
    //     $"""
    //     Üyeliği ve Aboneliği Var Mı: {memberAndSubscripton}
    //     Üyeliği veya Aboneliği Var Mı: {memberOrSubscription}
    //     Üyelik ve Abonelik Yoksa: {notMemberAndSubscription};
    //     """
    // );

    //? Mini Challenge 2 🚀 Bir öğrencinin: int grade = 75; int absence = 3; değerleri olsun. Kontrol et: Notu 50 veya daha büyük mü? Devamsızlığı 5'ten az mı? Hem notu yeterli hem devamsızlığı uygun mu?

    // int grade = 75;
    // int absence = 3;

    // bool gradeBiggerThan50 = grade == 50 || grade > 50;
    // bool absenceLesserThan5 = absence < 5;
    // bool canGraduate = gradeBiggerThan50 && absenceLesserThan5;

    // Console.WriteLine(
    //     $"""
    //     Grade Greater Than or Equal to 50: {gradeBiggerThan50}
    //     Absence Lesser Than 5: {absenceLesserThan5};
    //     Graduation Status: {canGraduate}
    //     """
    // );

    //? Ek Görev 🚀 (Biraz Daha Zor) Bir kullanıcı için: bool isAdmin = false; bool isModerator = true; bool isBanned = false; şunları hesapla: Yönetim paneline girebilir mi? Admin VEYA Moderatör olmalı VE Banlı olmamalı. Banlı mı? Yetkili kullanıcı mı? Sonuçları bool olarak yazdır.

    // bool isAdmin = false;
    // bool isModerator = true;
    // bool isBanned = false;

    // bool canLoginManagementPanel = (isAdmin || isModerator) && !isBanned;
    // // Banlı mı? sorusunun yapmama gerek yok çünkü isBanned olarak false verdik zaten. Tekrar aynı kodu yazmak anlamlı olmaz.
    // bool isAuthorized = isAdmin || isModerator;

    // Console.WriteLine(
    //     $"""
    //     Can Login Management Panel: {canLoginManagementPanel}
    //     Is Banned: {isBanned}
    //     Is Authorized: {isAuthorized}
    //     """
    // );

    //? Ek Task 🚀 Bu biraz daha gerçek hayat senaryosu: bool hasDrivingLicense = true; bool ownsCar = false; bool hasInsurance = true; Aşağıdakileri hesapla: Aracı kullanabilir mi? Ehliyeti olmalı VE Arabası olmalı VE Sigortası olmalı. Araç sahibi mi? Yasal olarak trafiğe çıkabilir mi? Bu üç koşuldan herhangi biri eksik mi?

    // bool hasDrivingLicense = true;
    // bool ownsCar = false;
    // bool hasInsurance = true;

    // bool canDrive = hasDrivingLicense && ownsCar && hasInsurance;
    // bool legallyDriven = hasDrivingLicense && hasInsurance || ownsCar; // Arabası olmasa da yasal olarak araba kullanabilir. Aracının olmaması engel değil.
    // bool areConditionsMet = hasDrivingLicense && ownsCar && hasInsurance;

    // Console.WriteLine(
    //     $"""
    //     Can Drive: {canDrive}
    //     Legally Driven on the Road: {legallyDriven}
    //     Are All Conditions Met: {areConditionsMet}
    //     """
    // );
}
//! DERS 28: Mantıksal Operatörler Uygulama
{
    //? Yaşı 18'den büyük ya da veliz izni varsa varsa bir işte çalışabilir durumunu kontrol ediniz.

    // Console.Write("Yaşınızı Giriniz: ");
    // int age = Convert.ToInt32(Console.ReadLine());

    // if (age < 18)
    // {
    //     Console.Write("Veli İzni Var Mı?(E/H): ");
    //     char permission = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());
    //     if (permission == 'E')
    //     {
    //         Console.WriteLine("Bir İşte Çalışabilirsiniz");
    //     } else if (permission == 'H')
    //     {
    //         Console.WriteLine("Bir İşte Çalışamazsınız");
    //     } else
    //     {
    //         Console.WriteLine("Hatalı Giriş Yaptınız");
    //     }
    // } else
    // {
    //     Console.WriteLine("Bir İşte Çalışabilirsiniz");
    // }

    //* Alternatif

    // Console.Write("Yaşınız: ");
    // int age1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Veli İzni Var mı?(E/H): ");
    // char permission1 = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

    // bool workStatus = age1 >= 18 || permission1 == 'E';
    // string permissionNote = workStatus == true ? "Bir İşte Çalışabilirsiniz":"Bir İşte Çalışamazsınız";
    // Console.WriteLine(permissionNote);

    //? Ders notu 50 - 100 arasındaysa geçti değilse kalsın bilgisi yazdır.

    // Console.Write("Notunuzu Giriniz: ");
    // int grade = Convert.ToInt32(Console.ReadLine());
    // bool canPass = grade >= 50 && grade <= 100;
    // string status = canPass == true ? "Dersi Geçtiniz" : "Dersten Kaldınız";
    // Console.WriteLine(
    //     $"Notunuz: {grade}.{status}"
    // );

    //* Alternatif

    // Console.Write("Notunuzu Giriniz: ");
    // int grade = Convert.ToInt32(Console.ReadLine());

    // if (grade >= 50 && grade <= 100)
    // {
    //     Console.Write(
    //         $"""
    //         Notunuz: {grade}.
    //         Dersi geçtiniz. Tebrikler.
    //         """
    //     );
    // } else if (grade >= 0 && grade < 50)
    // {
    //     Console.Write(
    //         $"""
    //         Notunuz: {grade}.
    //         Dersten kaldınız.
    //         """
    //     );
    // } else
    // {
    //     Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Tekrar Deneyin.");
    // }

    //? Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

    // Console.Write("Matematik Notunuz: ");
    // int mathGrade = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Türkçe Notunuz: ");
    // int turkishGrade = Convert.ToInt32(Console.ReadLine());

    // double averageGrade = (mathGrade + turkishGrade) / 2;

    // bool certOfAppreciation = averageGrade >= 70 && (mathGrade >= 50 && turkishGrade >= 50 );
    // string certificateStatus = certOfAppreciation == true ? "Teşekkür Belgesi alabilir" : "Teşekkür Belgesi alamaz";

    // Console.WriteLine(certificateStatus);

    // //* Alternatif

    // Console.Write("Matematik Notunuz: ");
    // int mathGrade = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Türkçe Notunuz: ");
    // int turkishGrade = Convert.ToInt32(Console.ReadLine());

    // double averageGrade = (mathGrade + turkishGrade) / 2;

    // if (averageGrade >= 70)
    // {
    //     if (mathGrade >= 50 && turkishGrade >= 50)
    //     {
    //         Console.WriteLine(
    //             $"""
    //             Not ortalamanız: {averageGrade}
    //             Zayıf notunuz yok
    //             Teşekkür Belgesi alabilirsiniz.
    //             """
    //         );
    //     } else
    //     {
    //         Console.WriteLine(
    //             $"""
    //             Not ortalamanız: {averageGrade}
    //             Zayıf notunuz var.
    //             Teşekkür Belgesi alamazsınız.
    //             """
    //         );
    //     }
    // } else
    // {
    //     Console.WriteLine(
    //             $"""
    //             Not ortalamanız: {averageGrade}
    //             Not ortalamanız teşekkür belgesi almak için yetersiz.
    //             Teşekkür Belgesi alamazsınız.
    //             """
    //         );
    // }

    //? İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

    // Console.Write("Mezuniyet Durumunuz(Önlisans/Lisans): ");
    // string graduationStatus = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
    // Console.Write("Sigara Kullanıyor Musunuz?(E/H): ");
    // char smoker = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

    // bool isAssociateDegree = graduationStatus == "ÖNLİSANS";
    // bool isBachelorDegree = graduationStatus == "LİSANS";
    // bool isSmoker = smoker == 'E';

    // bool recruitment =( isAssociateDegree || isBachelorDegree ) && !isSmoker;

    // string recruitmentStatus = recruitment ? "İşe Alındınız" : "İşe Alınmadınız";
    // Console.WriteLine(recruitmentStatus);

    //* Alternatif

    // Console.Write("Mezuniyet Durumunuz(Önlisans/Lisans/Yüksek): ");
    // string graduationStatus = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
    

    // if (graduationStatus == "YÜKSEK" || graduationStatus == "ÖNLİSANS" || graduationStatus == "LİSANS")
    // {
    //     Console.Write("Sigara Kullanıyor Musunuz?(E/H): ");
    //     char smokingStatus = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());
    //     if (smokingStatus == 'H')
    //     {
    //         Console.WriteLine("Tebrikler. İşe Alındınız.");
    //     } else
    //     {
    //         Console.WriteLine("Üzgünüz. Sigara İçtiğiniz İçin İşe Alınmadınız.");
    //     }
    // } else
    // {
    //     Console.WriteLine("Üzgünüz. Mezuniyet Şartını Karşılamadığınız İçin İşe Alınmadınız.");
    // }

    //? Username ve password üzerinden uygulamaya giriş kontrolü yap.

    // string userName = "DZEL";
    // string password = "12345";

    // Console.Write("Kullanıcı Adınız: ");
    // string enteredUserName = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
    // Console.Write("Şifreniz: ");
    // string enteredPassword = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();

    // bool isUsernameMatch = enteredUserName == userName;
    // bool isPasswordMatch = enteredPassword == password;
    // bool isLogin = isUsernameMatch && isPasswordMatch;

    // string loginStatus = isLogin ? "Giriş Başarılı" : "Kullanıcı Adı veya Şifre Hatalı";

    // Console.WriteLine(loginStatus);

    //* Alternatif

    // string userName = "DZEL";
    // string password = "12345";

    // Console.Write("Kullanıcı Adınız: ");
    // string enteredUserName = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
    // Console.Write("Şifreniz: ");
    // string enteredPassword = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();

    // bool isUsernameMatch = enteredUserName == userName;
    // bool isPasswordMatch = enteredPassword == password;
    // bool isLogin = isUsernameMatch && isPasswordMatch;

    // if (isLogin)
    // {
    //     Console.WriteLine("Giriş Başarılı");
    // } else if (!isUsernameMatch)
    // {
    //     Console.WriteLine("Kullanıcı Adı Hatalı");
    // } else if (!isPasswordMatch)
    // {
    //     Console.WriteLine("Şifre Hatalı");
    // } else
    // {
    //     Console.WriteLine("Kullanıcı Adı ve Şifre Hatalı");
    // }
}
//! DERS 29: Random Operatörler
{
    // var rnd = new Random();

    // int number = rnd.Next();
    // Console.WriteLine(number);

    // int number1 = rnd.Next(100);
    // Console.WriteLine(number1);

    // int number2 = rnd.Next(50, 100);
    // Console.WriteLine(number2);

    // string[] teams = {"Fenerbahçe", "Galatasaray", "Beşiktaş", "Trabzonspor"};
    // var rnd1 = new Random();
    // int number3 = rnd1.Next(3);
    // Console.WriteLine(teams[number3]);

    //? Mini Challenge 1 🚀 Bir zar simülasyonu yap. Random rnd = new(); Kullanarak: 1 ile 6 arasında sayı üret. Sonucu ekrana yazdır

    // Random rnd = new();

    // int dice = rnd.Next(1,7);

    // Console.WriteLine(
    //     $"Attığınız Zar: {dice}"
    // );

    //? Mini Challenge 2 🚀 Bir ödül sistemi yap. string[] rewards = {"Altın", "Elmas", "Kılıç", "Zırh", "İksir"}; Rastgele bir ödül seç.

    // Random rnd1 = new();
    // string[] rewards = {"Altın", "Elmas", "Kılıç", "Zırh", "İksir"};
    // int indexNumber = rnd1.Next(rewards.Length);

    // Console.WriteLine(
    //     $"Ödülünüz: {rewards[indexNumber]}"
    // );

    //? Ek Görev (Unity Hazırlığı) 🎮 Bir RPG karakterine rastgele hasar ver: int health = 100; Rastgele: 10 - 30 arası hasar üret. Sonra: health -= damage; yap.
    
    // int health = 100;

    // Random rnd2 = new();
    // int damage = rnd2.Next(10, 31);

    // int remainingHealth = health - damage;

    // Console.WriteLine(
    //     $"""
    //     Karakter {damage} hasar aldı.
    //     Kalan can: {remainingHealth}
    //     """
    // );

    //? Ek Görev 🚀 (Biraz Daha Gerçekçi) Bir RPG sandığı oluştur: string[] items = { "Kılıç", "Zırh", "Altın", "İksir", "Yüzük" }; Görev: Rastgele bir eşya ver Eğer eşya "Altın" ise 100 altın kazandın yazdır. Eğer eşya "İksir" ise Canın 20 arttı yazdır. Diğer eşyalar için Yeni eşya bulundu: Kılıç şeklinde yazdır.

    // Random rnd = new();
    // string[] items = { "Kılıç", "Zırh", "Altın", "İksir", "Yüzük" };
    // int indexNumber = rnd.Next(items.Length);

    // if (items[indexNumber] == "Altın")
    // {
    //     Console.WriteLine($"100 {items[indexNumber]} kazandın");
    // } else if (items[indexNumber] == "İksir")
    // {
    //     Console.WriteLine($"Canın 20 arttı");
    // } else
    // {
    //     Console.WriteLine($"Yeni Eşya Bulundu: {items[indexNumber]}");
    // }

    //? Ek Görev 2 🎮 (Unity Mantığı) int enemyHealth = 100; Rastgele: 15-40 arası hasar vur. Sonra: enemyHealth -= damage; Eğer can: 0 veya altına düşerse Düşman öldü! yazdır. Değilse: Düşmanın kalan canı: X yazdır.

    // Random rnd1 = new();
    // int enemyHealth = 100;

    // while (enemyHealth > 0) {
    
    // int damage = rnd1.Next(15, 41);
    // enemyHealth -= damage;
    // Console.WriteLine($"Vurulan Hasar: {damage}");

    //     if (enemyHealth > 0)
    //     {
    //         Console.WriteLine($"Kalan Can: {enemyHealth}");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Düşman Öldü!");
    //     }
    // }
}
//! DERS 30: If / Else Bloğu
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

// string cardNumber = "1234"; 
// string pin = "9999"; 
// decimal balance = 5000m;

// Console.Write("Kart Numaranız: ");
// string enteredCardNumber = Console.ReadLine() ?? string.Empty;

// Console.Write("Pin Kodunuz: ");
// string enteredPin = Console.ReadLine() ?? string.Empty;

// if (enteredCardNumber == cardNumber)
//     {
//         if (enteredPin == pin)
//         {
//             Console.WriteLine(
//                 """
//                 Seçim Yapınız(1/2)
//                 1- Bakiye Görüntüle
//                 2- Para Çek
//                 """
//             );
//             char option = (Console.ReadLine() ?? string.Empty).FirstOrDefault();
//             if (option == '1')
//             {
//                 Console.WriteLine($"Güncel Bakiyeniz: {balance:C}");
//             } else
//             {
//                 if (option == '2')
//                 {
//                     Console.Write("Çekmek İstediğiniz Tutar: ");
//                     decimal withdraw = Convert.ToDecimal(Console.ReadLine());
//                     if (withdraw > balance)
//                     {
//                         Console.WriteLine("Yetersiz bakiye");
//                     } else
//                     {
//                         balance -= withdraw;
//                         Console.WriteLine(
//                             $"{withdraw:C} çekildikten sonra hesabınızda kalan tutar: {balance:C}"
//                         );
//                     }
//                 }
//             }
//         } else
//         {
//             Console.WriteLine("Hatalı Pin");
//         } 
//     } else
//     {
//         Console.WriteLine("Kart Bulunamadı");
//     }
}
//! DERS 31: If / Else If Bloğu
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

// Console.Write("Yaşınız: ");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.Write("Öğrencilik Durumu(E/H): ");
// char studentStatus = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

// decimal price = age >= 65 ? 120 : 18 <= age && age < 65 ? 250 : 13 <= age && age < 18 ? 150 : 0 <= age && age < 13 ? 100 : 0;
// decimal discountRate = 0.20m;
// decimal discountAmount = price * discountRate;

// if (age >= 65)
//     { 
//         if (studentStatus == 'E')
//         {
//             decimal discountedPrice = price - discountAmount;
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 İndirim: {discountAmount:C}
//                 İndirimli Fiyat: {discountedPrice:C}
//                 """
//             );
//         } else
//         {
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 """
//             );
//         }
//     } else if (18 <= age && age < 65)
//     {
//         price = 250m;
//         if (studentStatus == 'E')
//         {
//             decimal discountedPrice = price - discountAmount;
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 İndirim: {discountAmount:C}
//                 İndirimli Fiyat: {discountedPrice:C}
//                 """
//             );
//         } else
//         {
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 """
//             );
//         }
//     } else if (13 <= age && age < 18)
//     {
//         price = 150m;
//         if (studentStatus == 'E')
//         {
//             decimal discountedPrice = price - discountAmount;
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 İndirim: {discountAmount:C}
//                 İndirimli Fiyat: {discountedPrice:C}
//                 """
//             );
//         } else
//         {
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 """
//             );
//         }
//     } else if (0 <= age && age < 12)
//     {
//         price = 100m;
//         if (studentStatus == 'E')
//         {
//             decimal discountedPrice = price - discountAmount;
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 İndirim: {discountAmount:C}
//                 İndirimli Fiyat: {discountedPrice:C}
//                 """
//             );
//         } else
//         {
//             Console.WriteLine(
//                 $"""
//                 Yaş: {age}
//                 Öğrencilik Durumu: {studentStatus}
//                 Normal Fiyat: {price:C}
//                 """
//             );
//         }
//     } else
//     {
//         Console.WriteLine("Hatalı Giriş");
//     }
}
//! DERS 32: If / Else If Uygulama
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

    // Console.Write("Sipariş Tutarınız: ");
    // decimal cost = Convert.ToDecimal(Console.ReadLine());

    // Console.Write("Premium Üyelik (E/H): ");
    // char premiumMember = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

    // decimal shippingFee = 0m;
    // decimal totalCost = 0m;
    // string premiumStatus = premiumMember == 'E' ? "Üyelik Var" : "Üyelik Yok";

    // if (cost <= 0)
    //     {
    //         Console.WriteLine("Sipariş Tutarı 0₺'den az olamaz");
    //     } else
    //     {
    //         if (cost < 1000 && premiumMember != 'E')
    //             {
    //                 shippingFee = 99m;
    //                 totalCost = cost + shippingFee;
    //             } else if (cost < 1000 && premiumMember =='E' || cost >= 1000)
    //             {
    //                 shippingFee = 0m;
    //                 totalCost = cost + shippingFee;
    //             } else
    //             {
    //                 Console.WriteLine("Hatalı Giriş");
    //             }
    //             Console.WriteLine(
    //             $"""
    //             Sipariş Tutarı: {cost:C} 
    //             Premium Üye: {premiumStatus}
    //             Kargo Ücreti: {shippingFee:C}
    //             Toplam Ödeme: {totalCost:C}
    //             """
    //         );
    //     }
}
//! DERS 33: Switch - Case
{
    // int day = (int)DateTime.Now.DayOfWeek; //* 0 → pazar, 1 → ptesi, ... , 6 → ctesi

    // switch (day)
    // {
    //     case 0:
    //         Console.WriteLine("pazar");
    //         break;
    //     case 1:
    //         Console.WriteLine("pazartesi");
    //         break;
    //     case 2:
    //         Console.WriteLine("salı");
    //         break;
    //     case 3:
    //         Console.WriteLine("çarşamba");
    //         break;
    //     case 4:
    //         Console.WriteLine("perşembe");
    //         break;
    //     case 5:
    //         Console.WriteLine("cuma");
    //         break;
    //     case 6:
    //         Console.WriteLine("cumartesi");
    //         break;
    //     default:
    //         Console.WriteLine("Hatalı Gün");
    //         break;
    // }

    // int month = (int)DateTime.Now.Month;

    // switch (month)
    // {
    //     case 1:
    //         Console.WriteLine("Ocak");
    //         break;
    //     case 2:
    //         Console.WriteLine("Şubat");
    //         break;
    //     case 3:
    //         Console.WriteLine("Mart");
    //         break;
    //     case 4:
    //         Console.WriteLine("Nisan");
    //         break;
    //     case 5:
    //         Console.WriteLine("Mayıs");
    //         break;
    //     case 6:
    //         Console.WriteLine("Haziran");
    //         break;
    //     case 7:
    //         Console.WriteLine("Temmuz");
    //         break;
    //     case 8:
    //         Console.WriteLine("Ağustos");
    //         break;
    //     case 9:
    //         Console.WriteLine("Eylül");
    //         break;
    //     case 10:
    //         Console.WriteLine("Ekim");
    //         break;
    //     case 11:
    //         Console.WriteLine("Kasım");
    //         break;
    //     case 12:
    //         Console.WriteLine("Aralık");
    //         break;
    // }

    // int month = (int)DateTime.Now.Month;

    // switch (month)
    // {
    //     case 12:
    //     case 1:
    //     case 2:
    //         Console.WriteLine("Winter");
    //         break;
    //     case 3:
    //     case 4:
    //     case 5:
    //         Console.WriteLine("Spring");
    //         break;
    //     case 6:
    //     case 7:
    //     case 8:
    //         Console.WriteLine("Summer");
    //         break;
    //     case 9:
    //     case 10:
    //     case 11:
    //         Console.WriteLine("Autumn");
    //         break;
    // }

    //? Mini Challenge 1 🚀 Kullanıcıdan bir sayı al. 1 → Pazartesi 2 → Salı 3 → Çarşamba 4 → Perşembe 5 → Cuma 6 → Cumartesi 7 → Pazar. Switch kullanarak günü yazdır.

    // Console.Write("Bir Sayı Giriniz(1-7): ");
    // int numberOfDay = Convert.ToInt32(Console.ReadLine());

    // string dayOfWeek = numberOfDay == 1 ? "Pazartesi" : numberOfDay == 2 ? "Salı" : numberOfDay == 3 ? "Çarşamba" : numberOfDay == 4 ? "Perşembe" : numberOfDay == 5 ? "Cuma" : numberOfDay == 6 ? "Cumartesi" : numberOfDay == 7 ? "Pazar" : "Hatalı Giriş";

    // switch (numberOfDay)
    // {
    //     case 1:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     case 2:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     case 3:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     case 4:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     case 5:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     case 6:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     case 7:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    //     default:
    //         Console.WriteLine(dayOfWeek);
    //         break;
    // }

    //? Mini Challenge 2 🚀 Kullanıcıdan bir işlem seçmesini iste: 1 → Toplama 2 → Çıkarma 3 → Çarpma 4 → Bölme Sonra iki sayı al. Switch kullanarak işlemi gerçekleştir.

    // Console.Write(
    // """
    // 1 → Toplama
    // 2 → Çıkarma
    // 3 → Çarpma
    // 4 → Bölme
    // Lütfen Bir İşlem Numarası Giriniz: 
    // """
    // );
    // int number = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Bir Sayı Giriniz: ");
    // int number1 = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Bir Sayı Daha Giriniz: ");
    // int number2 = Convert.ToInt32(Console.ReadLine());

    // int result;

    // string message = 
    // $"""
    // İşlem: {number}
    // Sayı 1: {number1}
    // Sayı 2: {number2}
    // """;

    // switch (number)
    // {
    //     case 1:
    //         result = number1 + number2;
    //         Console.WriteLine(
    //             $"""
    //             {message}
    //             Sonuç: {result}
    //             """
    //         );
    //         break;
    //     case 2:
    //         result = number1 - number2;
    //         Console.WriteLine(
    //             $"""
    //             {message}
    //             Sonuç: {result}
    //             """
    //         );
    //         break;
    //     case 3:
    //         result = number1 * number2;
    //         Console.WriteLine(
    //             $"""
    //             {message}
    //             Sonuç: {result}
    //             """
    //         );
    //         break;
    //     case 4:
    //         if (number2 == 0)
    //         {
    //             Console.WriteLine("Herhangi bir sayının 0'a bölümü tanımsızdır");
    //         } else
    //         {
    //             result = number1 / number2;
    //            Console.WriteLine(
    //             $"""
    //             {message}
    //             Sonuç: {result}
    //             """
    //         );
    //         }
    //         break;
    //     default:
    //         Console.WriteLine("Hatalı Giriş");
    //         break;
            
    // }

    //? Ek Task 🎮 (Unity Hazırlığı) Bir RPG karakter sınıfı seçme sistemi yap. Kullanıcıdan: 1 → Warrior 2 → Mage 3 → Archer 4 → Assassin seçmesini iste. Switch ile: Warrior seçildi. Başlangıç Canı: 150 gibi bilgiler yazdır.

    // Console.Write(
    //     """
    //     1 → Warrior
    //     2 → Mage
    //     3 → Archer
    //     4 → Assassin
    //     Bir Karakter Sınıfı Seçiniz: 
    //     """
    // );
    // int numberOfChar = Convert.ToInt32(Console.ReadLine());

    // string character = numberOfChar == 1 ? "Warrior" : numberOfChar == 2 ? "Mage" : numberOfChar == 3 ? "Archer" : numberOfChar == 4 ? "Assassin" : "Hatalı Seçim";
    // int defaultHealth = numberOfChar == 1 ? 150 : numberOfChar == 2 ? 80 : numberOfChar == 3 ? 100 : numberOfChar == 4 ? 90 : 0;
    // string message = 
    //     $"""
    //     {character} seçildi.
    //     Başlangıç Canı: {defaultHealth}
    //     """;

    // Console.WriteLine(message);

    //* Switch İle Çözüm

    // string charType;
    // int health;     

    // switch (numberOfChar)
    // {
    //     case 1:
    //         charType = "Warrior";
    //         health = 150;
    //         Console.WriteLine(
    //             $"""
    //             Karakter: {charType}
    //             Başlangıç Canı: {health}
    //             """
    //         );
    //         break;
    //     case 2:
    //         charType = "Mage";
    //         health = 80;
    //         Console.WriteLine(
    //             $"""
    //             Karakter: {charType}
    //             Başlangıç Canı: {health}
    //             """
    //         );
    //         break;
    //     case 3:
    //         charType = "Archer";
    //         health = 100;
    //         Console.WriteLine(
    //             $"""
    //             Karakter: {charType}
    //             Başlangıç Canı: {health}
    //             """
    //         );
    //         break;
    //     case 4:
    //         charType = "Assassin";
    //         health = 90;
    //         Console.WriteLine(
    //             $"""
    //             Karakter: {charType}
    //             Başlangıç Canı: {health}
    //             """
    //         );
    //         break;
    //     default:
    //         Console.WriteLine("Hatalı Seçim");
    //         break;
    // }

    //? Ek Task 🚀 (Switch'i Pekiştirme) Bir restoran sipariş sistemi yap. Menü: 1 → Hamburger 2 → Pizza 3 → Döner 4 → Tavuk Pilav Fiyatlar: Hamburger   → 250  Pizza → 300 TL Döner → 200 TL Tavuk Pilav → 180 TL Switch kullanarak: Seçilen Ürün: Fiyat: bilgisini yazdır. Bonus 🎯 Sipariş adedini de kullanıcıdan al. Sonuçta: Ürün: Birim Fiyat: Adet: Toplam: hesapla.

    // Console.Write(
    //     """
    //     1 → Hamburger
    //     2 → Pizza
    //     3 → Döner
    //     4 → Tavuk Pilav
    //     Bir Menü Seçiniz: 
    //     """
    // );
    // int numberOfMenu = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Lütfen adet giriniz: ");
    // int quantity = Convert.ToInt32(Console.ReadLine());

    // if (quantity <= 0)
    //     {
    //     Console.WriteLine("Geçersiz adet.");
    //     return;
    //     }

    // string menu = "";
    // decimal price = 0;
    

    // switch (numberOfMenu)
    // {
    //     case 1:
    //         menu = "Hamburger";
    //         price = 250;
    //         break;
    //     case 2:
    //         menu = "Pizza";
    //         price = 300;
    //         break;
    //     case 3:
    //         menu = "Döner";
    //         price = 200;
    //         break;
    //     case 4:
    //         menu = "Tavuk Pilav";
    //         price = 180;
    //         break;
    //     default:
    //         Console.WriteLine("Hatalı Menü Seçimi");
    //         return;
    // }
    // decimal totalPrice = price * quantity;
    // Console.WriteLine(
    //     $"""
    //     Menü: {menu}
    //     Birim Fiyat: {price:C}
    //     Adet: {quantity}
    //     Toplam Fiyat: {totalPrice:C}
    //     """
    // );
}
//! DERS 34: Ternary
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

// decimal price = 1200m;

// bool isMember = true;
// bool isHoliday = true;
// bool hasCoupon = true;

// decimal finalPrice = price;

// finalPrice = isMember ? finalPrice * 0.90m : finalPrice;
// finalPrice = isHoliday ? finalPrice * 0.95m : finalPrice;
// finalPrice = hasCoupon ? finalPrice * 0.93m : finalPrice;

// decimal discount = price - finalPrice;

// Console.WriteLine(
// $"""
// Normal Fiyat: {price:C}
// İndirim: {discount:C}
// Son Fiyat: {finalPrice:C}
// """
// );
}
//! DERS 35: For Döngüsü
{   
    // for (int i = 1; i <= 100; i++)
    // {
    //     Console.WriteLine(i);
    // }

    //? Görev 1. 1–100 arası: sadece tek sayıları yazdır

    // for (int i = 1; i<=100; i++)
    // {
    //     if (i % 2 != 0)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

    //? Görev 2. 1–100 arası: sayıların toplamını bul

    // int sum = 0;
    // for (int i = 1; i <= 100; i++)
    // {
    //     sum += i;
    // }
    // Console.WriteLine(sum);

    //? Görev 3 (Unity Mantığı 🎮). int health = 100; 10 tur boyunca: her turda 5 hasar ver, kalan canı yazdır.

    // int health = 100;

    // for (int i = 1; i <= 10; i++)
    // {
    //     health -= 5;
    // }
    // Console.WriteLine(
    //     $"Kalan Can: {health}"
    // );
    
    //? Sonraki Seviye Task: Hasar Sistemi Geliştirme: Başlangıç can: 100 Her tur: random 5–15 hasar Can 0 olunca dur 👉 Random + for + if birleşimi

//     int health = 100;
//     Console.WriteLine(
//         $"Başlangıç Canı: {health}"
//     );
//    var rnd = new Random();

//     for (int i = 1; i <= 20; i++)
//     {
//         int damage = rnd.Next(5, 16);

//         health -= damage;

//         Console.WriteLine(
//             $"""
//             {i}. Tur
//             Alınan Hasar: {damage}
//             Kalan Can: {(health <= 0 ? 0 : health)}
//             """
//         );

//         if (health <= 0)
//         {
//             Console.WriteLine("Kaybettiniz...");
//             break;
//         }
//     }
}
//! DERS 36: For Döngüsü Uygulama
{
    //? "1-100" arasındaki sayıların toplamı

    // int sum = 0;

    // for (int i = 1; i <= 100; i++)
    // {
    //     sum += i;
    // }
    // Console.WriteLine(sum);

    //? Klavyeden girilen başlangıç ve bitiş değerleri arasındaki sayıların toplamı

    // Console.Write("Başlangıç Değeri Giriniz: ");
    // int startNumber = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Bitiş Değeri Giriniz: ");
    // int endNumber = Convert.ToInt32(Console.ReadLine());

    // int sum = 0;

    // for (int i = startNumber; i <= endNumber; i++)
    // {
    //     sum += i;
    // }
    // Console.WriteLine(sum);

    //? {"ali","veli","mehmet","ahmet","hikmet"} dizisindeki tüm elemanları yazdır

    // string[] names = {"ali","veli","mehmet","ahmet","hikmet"};

    // for (int i = 0; i < names.Length; i++)
    // {
    //     Console.WriteLine(names[i]);
    // }

    //? {1,3,4,34,41,56,89} dizisindeki sayılardan hangileri 3'ün katı?

    // int[] numbers = {1,3,4,34,41,56,89};

    // for (int i = 0; i < numbers.Length; i++)
    // {
    //     if (numbers[i] % 3 == 0)
    //     {
    //         Console.WriteLine(numbers[i]);
    //     }
    // }

    //? Görev 1 (Orta Seviye) 1–100 arası: → hem 3’e hem 5’e bölünenleri yazdır

    // for (int i = 1; i <= 100; i++)
    // {
    //     if (i % 3 == 0 && i % 5 == 0)
    //     {
    //         Console.WriteLine(
    //             $"{i} hem 3'e hem 5'e bölünür"
    //         );
    //     }
    // }

    //? Görev 2 (Biraz Zor) Bir dizi: int[] numbers = {10, 25, 33, 47, 50} → en büyük sayıyı bul → en küçük sayıyı bul

    // int[] numbers = {10, 25, 33, 47, 50};

    // int biggest = numbers[0];
    // int smallest = numbers[0];

    // for (int a = 0; a <= numbers.Length -1; a++)
    // {
    //     if (numbers[a] < smallest) {
    //         smallest = numbers[a];
    //     }
    //     if (numbers[a] > biggest)
    //     {
    //         biggest = numbers[a];
    //     }
    // }

    // Console.WriteLine(
    //     $"""
    //     En Büyük: {biggest}
    //     En Küçük: {smallest}
    //     """
    // );

    //? Görev 3 (Unity Mantığı 🎮) 5 düşman var her biri için: → random 10–30 can → ekrana yazdır

    // string[] enemies = {"Enemy 1", "Enemy 2", "Enemy 3", "Enemy 4", "Enemy 5"};
    // var rnd = new Random();

    // for (int i = 0; i <= enemies.Length - 1; i ++)
    // {
    //     int health = rnd.Next(15,31);
    //     Console.WriteLine(
    //         $"""
    //         {enemies[i]} Canı: {health};
    //         """
    //     );
    // }

    //? Mini Upgrade Task: Şunu yap: 5 düşman: → random can → en güçlü düşmanı bul (max HP) → ismini yazdır

    //   string[] enemies = {"Enemy 1", "Enemy 2", "Enemy 3", "Enemy 4", "Enemy 5"};
    //   int[] health = new int[5];
    //   var rnd = new Random();
    //   int power = 0;
    //   string powerfull = "";

    //   for (int i = 0; i <= enemies.Length - 1; i ++)
    //     {
            
    //         int hp = rnd.Next(10,31);
    //         health[i] = hp;
    //         Console.WriteLine($"{enemies[i]} → {health[i]} HP");
    //         if (health[i] >= power)
    //     {
    //         power = health[i];
    //         powerfull = enemies[i];
    //     }
    //     }
    //     Console.WriteLine(
    //             $"""
    //             En Güçlü Düşman
    //             {powerfull}: {power} HP
    //             """
    //         );
}
//! DERS 37: While Döngüsü
{
    // for (int i = 0; i <= 10; i++)
    // {
    //     Console.WriteLine(i);
    // }

    // int a = 0;
    // while(a <= 10)
    // {
    //     Console.WriteLine(a);
    //     a ++;
    // };

    // string[] names = {"ali","veli","ahmet"};

    // int b = 0;

    // while (b < names.Length)
    // {
    //     Console.WriteLine(names[b]);
    //     b++;
    // }

    // char option = 'e';
    // int counter = 1;
    // int sum = 0;

    // while (option == 'e')
    // {
    //     Console.Write($"{counter}. sayı: ");
    //     sum += Convert.ToInt32(Console.ReadLine());

    //     Console.Write("Devam Etmek İstiyor Musunuz?(e/h): ");
    //     option = Convert.ToChar(Console.ReadLine());

    //     counter ++;
    // }
    // Console.WriteLine($"{counter-1} adet sayının toplamı: {sum}");

    //? Görev 1: Kullanıcı sayı girsin, 0 girene kadar devam etsin. Toplamı yazdır

    // int exit = 1;
    // int sum = 0;

    // while (exit != 0)
    // {
    //     Console.Write("Sayı Giriniz: ");
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     exit = number;
    //     sum += number;
    // }
    // Console.WriteLine(sum);

    //? Görev 2 (Unity Mantığı 🎮) Karakter canı: 100 Random hasar ver Can 0 olana kadar while ile devam et

    // int health = 100;
    // Console.WriteLine($"Başlangıç Canı: {health}");
    // var rnd = new Random();
    // int count = 0;

    // while (health > 0)
    // {   
    //     count ++;
    //     int damage = rnd.Next(101);
    //     health -= damage;
    //     Console.WriteLine(
    //         $"""
    //         {count}. Tur
    //         Alınan Hasar: {damage}
    //         Kalan Can: {(health < 0 ? 0 : health)}
    //         """
    //     );
    // }
    // Console.WriteLine("Kaybettiniz");

    //? Görev 3 (Bir Tık Zor): Kullanıcıdan sayı al Negatif girene kadar devam et Girilen en büyük sayıyı bul

    
    // int number = 0;
    // int maxNumber = 0;
    
    // while (number >= 0)
    // {
    //     Console.Write("Bir Sayı Giriniz: ");
    //     number = Convert.ToInt32(Console.ReadLine());
    
    //     if (number > maxNumber)
    //     {
    //         maxNumber = number;
    //     }
        
    // }
    // Console.WriteLine($"Girilen En Büyük Sayı: {maxNumber}");

    //? Görev 4: Bir Sonraki Seviye: Girilen: → en büyük → en küçük → ortalama 👉 Tek while içinde çöz

    // int number;
    // int minNumber = 100000;
    // int maxNumber = 0;
    // int sum = 0;
    // int counter = 0;
    

    // while (true)
    // {
    //     Console.Write("Bir Sayı Giriniz (Çıkış İçin Negatif Değer): ");
    //     number = Convert.ToInt32(Console.ReadLine());
    //     if (number < 0) break;
    //     sum += number;
    //     counter ++;
    //     if (number < minNumber) minNumber = number;
    //     else if (number > maxNumber) maxNumber = number;
    // }

    // double avgNumber = (double)sum / counter;

    // Console.WriteLine(
    //     $"""
    //     Girilen Sayı: {counter}
    //     En Küçük Sayı: {minNumber}
    //     Ortalama: {avgNumber}
    //     En Büyük Sayı: {maxNumber}
    //     """
    // );
}
//! DERS 38: Break & Continue
{
    // string name = "Celal Selim";

    // for (int i = 0; i < name.Length; i++)
    // {
    //     if (name[i] == ' ') continue;
        
    //     Console.WriteLine(name[i]);
    // }

    // for (int a = 0; a < name.Length; a++)
    // {
    //     if (name[a] == ' ') break;
        
    //     Console.WriteLine(name[a]);
    // }

    // int x = 0;

    // while (x <= 20)
    // {
    //     x++;
    //     if (x % 2 == 1) continue;
    //     Console.WriteLine(x);
        
    // }

    //? Görev 1: 1–100 arası: → 3’e bölünenleri atla (continue) → diğerlerini yazdır

    // int num = 0;

    // while (num <= 99)
    // {
    //     num ++;
    //     if (num % 3 == 0) continue;
    //     Console.WriteLine(num);
    // }

    //? Kullanıcı sayı girsin → 0 girerse break → negatif girerse continue (yok say) → sadece pozitifleri topla

    // int sum = 0;

    // while (true)
    // {
    //     Console.Write("Sayı Giriniz(Çıkış için 0): ");
    //     int number = Convert.ToInt32(Console.ReadLine());
    //     if (number == 0) break;
    //     if (number < 0) continue;
    //     sum += number;
    // }
    // Console.WriteLine(sum);

    //? Görev 3 (Unity Mantığı 🎮) 10 tur: → random damage → eğer dodge olursa continue → can 0 olursa break

    // var rnd = new Random();
    // int health = 100;
    // int count = 0;
    

    // while (count <= 10)
    // {
        
    //     int damage = rnd.Next(21);
    //     health -= damage;
    //     if (health <= 0) break;
    //     if (damage == 0) continue;
    //     count ++;
    //     Console.WriteLine(
    //     $"""
    //     {count}. Tur
    //     Alınan Hasar: {damage}
    //     Kalan Can: {health}
    //     """
    // );
    // }
}
//! DERS 39: While Döngüsü Uygulama
{
    //? Kullanıcıya 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalış. 10 hak ver, aşağı ve yukarı yönlendirme yap. Kaçıncı tahmin? 

    // int right = 10;
    // int count = 0;
    // var rnd = new Random();
    // int number = rnd.Next(1,101);
    // Console.WriteLine(number);

    // while (right > 0)
    // {
        
    //     Console.Write("1-100 arası sayı giriniz: ");
    //     int guess = Convert.ToInt32(Console.ReadLine());
    //     count ++;

    //     if (guess == number) {
    //         Console.WriteLine($"Tebrikler Kazandınız | {count} denemede bildiniz."); 
    //         break;
    //     };

    //     right --;

    //     if (right == 0) {
    //         Console.WriteLine(
    //             $"""
    //             Hakkınız Kalmadı
    //             Sayı: {number}
    //             """);
    //         break;
    //     }    

    //     if (guess > number) {
    //         Console.WriteLine($"Aşağı ↓ | Kalan Hak: {right}");
    //     } else if (guess < number) {
    //         Console.WriteLine($"Yukarı ↑ | Kalan Hak: {right}");
    //     }  
    // }
}
//! DERS 40: Do-While Döngüsü Uygulama
{
    // int i = 1;
    // do
    // {
    //     Console.WriteLine(i);
    //     i++;
    // } while (i < 10);

    // Console.Write("Adet: ");
    // int amount = Convert.ToInt32(Console.ReadLine());

    // string[] products = new string[amount];
    // int i = 0;

    // do
    // {
    //     Console.Write("Ürün Adı: ");
    //     products[i] = Console.ReadLine() ?? "Ürün Adı Yok";
    //     i ++;
    // } while (amount != i);

    // Console.WriteLine("Ürünler Listeleniyor...");

    // for (int a = 0; a < products.Length; a++)
    // {
    //     Console.WriteLine(products[a]);
    // }

    //? Görev 1: Kullanıcıdan sayı al. 0 girene kadar devam et (do-while ile) toplamı yazdır

    // int number = 0;
    // int sum = 0;

    // do
    // {
    //    Console.Write("Bir Sayı Giriniz(Çıkış için 0): ");
    //    number = Convert.ToInt32(Console.ReadLine());
    //    sum += number;
    // } while (number != 0);
    // Console.WriteLine($"Girdiğiniz Sayıların Toplamı: {sum}");

    //? Görev 2 (Zor) Kullanıcıdan ürün al. "exit" yazana kadar devam et.

    // string product = "";

    // do
    // {
    //     Console.Write("Ürün Adı(Çıkış: exit): ");
    //     product = Console.ReadLine() ?? "Ürün Adı Yok";
    // } while (product != "exit");

    //? Görev 3 (Unity Mantığı 🎮) Oyun menüsü: 1- Başla 2- Çık Kullanıcı çık diyene kadar tekrar göster (do-while)

    // int option = 0;
    // do
    // {
    //     Console.Write(
    //         """
    //         1 → Başla
    //         2 → Çık
    //         Lütfen Seçiniz: 
    //         """
    //     );
    //     option = Convert.ToInt32(Console.ReadLine());

    //     if (option <= 0 || option > 2) {Console.WriteLine("Hatalı Seçim. Lütfen Tekrar Deneyiniz.");}

    // } while (option != 2);

    // Console.WriteLine("Çıkış Yaptınız");
}
//! DERS 41: Foreach Döngüsü
{
// string name = "Celal";
// for (int i = 0; i < name.Length; i++) {
// Console.WriteLine(name[i]);}

// foreach(char letter in name) {
// Console.WriteLine(letter);}

// int[] numbers = {10, 20, 40, 45};

// foreach(int number in numbers) {
// if (number == 20) continue;
// Console.WriteLine(number);}

// foreach(int number in numbers) {
// if (number == 20) break;
// Console.WriteLine(number);}

//? Bir int dizisi oluştur: int[] numbers = {10, 25, 30, 45, 60} → sadece 30’dan büyük sayıları yazdır

// int[] numbers = {10, 25, 30, 45, 60};

// foreach (int number in numbers)
// {
//     if (number > 30) Console.WriteLine(number);
// }

//? Bir string dizisi oluştur: string[] names = {"Ali", "Veli", "Ayşe", "Ahmet"} → sadece "A" ile başlayanları yazdır

// string[] names = {"Ali", "Veli", "Ayşe", "Ahmet"};

// foreach (string name in names)
//     {
//         if (name.StartsWith("A")) Console.WriteLine(name);
//     }

// foreach (string name in names)
//     {
//         if (name[0] == 'A') Console.WriteLine(name);
//     }

//? int[] numbers = {5, 10, 15, 20, 25} → sadece çift sayıların toplamını bul

// int[] numbers = {5, 10, 15, 20, 25};
// int sum = 0;

// foreach (int number in numbers)
//     {
//         if (number % 2 == 0)
//         {
//             sum += number;
//         }
//     }
// Console.WriteLine(sum);

//? int[] numbers = {12, 45, 3, 78, 34} → en küçük sayıyı bul → en büyük sayıyı bul

// int[] numbers = {12, 45, 3, 78, 34};
// int maxNumber = 0;
// int minNumber = 99999;

// foreach (int number in numbers)
//     {
//         if (number > maxNumber)
//         {
//             maxNumber = number;
//         }
//         if (number < minNumber)
//         {
//             minNumber = number;
//         }
//     }
//     Console.WriteLine(maxNumber);
//     Console.WriteLine(minNumber);

//? string[] enemies = {"Goblin", "Orc", "Troll"} → her düşman için: "X saldırıya uğradı!" yazdır

// string[] enemies = {"Goblin", "Orc", "Troll"};

// foreach (string enemy in enemies)
//     {
//         Console.WriteLine();
//     }

//? int[] enemyHealth = {100, 80, 120} → her düşmandan 20 can düş → yeni canları yazdır

// int[] enemyHealth = {100, 80, 120};

// foreach (int health in enemyHealth)
//     {
//         Console.WriteLine(
//             $"""
//             Hasar Öncesi Can: {health}
//             Hasar Sonrası Can: {health - 20}
//             """
//         );
//     }

//? int[] numbers = {3, 7, 12, 18, 21, 24} → 3’e bölünen kaç sayı var? → yazdır

// int[] numbers = {3, 7, 12, 18, 21, 24};
// int counter = 0;

// foreach (int number in numbers)
//     {
//         if (number % 3 == 0) counter ++;
//     }
// Console.WriteLine($"3'e tam bölünen sayı adedi: {counter}");

//? string[] products = {"Laptop", "Mouse", "Keyboard", "Monitor", "Screen", "Wifi Adapter"} → içinde "o" harfi geçenleri yazdır

// string[] products = {"Laptop", "Mouse", "Keyboard", "Monitor", "Screen", "Wifi Adapter"};

// foreach (string product in products)
//     {
//         if (product.Contains("o")) Console.WriteLine(product);
//     }
}