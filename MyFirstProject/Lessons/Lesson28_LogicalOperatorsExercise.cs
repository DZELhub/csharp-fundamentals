namespace MyFirstProject.Lessons
{
    public static class Lesson28_LogicalOperatorsExercise
    {
        public static void Run()
        {
            //? Yaşı 18'den büyük ya da veliz izni varsa varsa bir işte çalışabilir durumunu kontrol ediniz.

            Console.Write("Yaşınızı Giriniz: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.Write("Veli İzni Var Mı?(E/H): ");
                char permission = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());
                if (permission == 'E')
                {
                    Console.WriteLine("Bir İşte Çalışabilirsiniz");
                } else if (permission == 'H')
                {
                    Console.WriteLine("Bir İşte Çalışamazsınız");
                } else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız");
                }
            } else
            {
                Console.WriteLine("Bir İşte Çalışabilirsiniz");
            }

            //* Alternatif

            Console.Write("Yaşınız: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Veli İzni Var mı?(E/H): ");
            char permission1 = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

            bool workStatus = age1 >= 18 || permission1 == 'E';
            string permissionNote = workStatus == true ? "Bir İşte Çalışabilirsiniz":"Bir İşte Çalışamazsınız";
            Console.WriteLine(permissionNote);

            //? Ders notu 50 - 100 arasındaysa geçti değilse kalsın bilgisi yazdır.

            Console.Write("Notunuzu Giriniz: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            bool canPass = grade >= 50 && grade <= 100;
            string status = canPass == true ? "Dersi Geçtiniz" : "Dersten Kaldınız";
            Console.WriteLine(
                $"Notunuz: {grade}.{status}"
            );

            //* Alternatif

            Console.Write("Notunuzu Giriniz: ");
            int grade1 = Convert.ToInt32(Console.ReadLine());

            if (grade1 >= 50 && grade1 <= 100)
            {
                Console.Write(
                    $"""
                    Notunuz: {grade1}.
                    Dersi geçtiniz. Tebrikler.
                    """
                );
            } else if (grade1 >= 0 && grade1 < 50)
            {
                Console.Write(
                    $"""
                    Notunuz: {grade1}.
                    Dersten kaldınız.
                    """
                );
            } else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Tekrar Deneyin.");
            }

            //? Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

            Console.Write("Matematik Notunuz: ");
            int mathGrade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Türkçe Notunuz: ");
            int turkishGrade = Convert.ToInt32(Console.ReadLine());

            double averageGrade = (mathGrade + turkishGrade) / 2;

            bool certOfAppreciation = averageGrade >= 70 && (mathGrade >= 50 && turkishGrade >= 50 );
            string certificateStatus = certOfAppreciation == true ? "Teşekkür Belgesi alabilir" : "Teşekkür Belgesi alamaz";

            Console.WriteLine(certificateStatus);

            // //* Alternatif

            Console.Write("Matematik Notunuz: ");
            int mathGrade1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Türkçe Notunuz: ");
            int turkishGrade1 = Convert.ToInt32(Console.ReadLine());

            double averageGrade1 = (mathGrade1 + turkishGrade1) / 2;

            if (averageGrade1 >= 70)
            {
                if (mathGrade1 >= 50 && turkishGrade1 >= 50)
                {
                    Console.WriteLine(
                        $"""
                        Not ortalamanız: {averageGrade1}
                        Zayıf notunuz yok
                        Teşekkür Belgesi alabilirsiniz.
                        """
                    );
                } else
                {
                    Console.WriteLine(
                        $"""
                        Not ortalamanız: {averageGrade1}
                        Zayıf notunuz var.
                        Teşekkür Belgesi alamazsınız.
                        """
                    );
                }
            } else
            {
                Console.WriteLine(
                        $"""
                        Not ortalamanız: {averageGrade1}
                        Not ortalamanız teşekkür belgesi almak için yetersiz.
                        Teşekkür Belgesi alamazsınız.
                        """
                    );
            }

            //? İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

            Console.Write("Mezuniyet Durumunuz(Önlisans/Lisans): ");
            string graduationStatus = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
            Console.Write("Sigara Kullanıyor Musunuz?(E/H): ");
            char smoker = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());

            bool isAssociateDegree = graduationStatus == "ÖNLİSANS";
            bool isBachelorDegree = graduationStatus == "LİSANS";
            bool isSmoker = smoker == 'E';

            bool recruitment =( isAssociateDegree || isBachelorDegree ) && !isSmoker;

            string recruitmentStatus = recruitment ? "İşe Alındınız" : "İşe Alınmadınız";
            Console.WriteLine(recruitmentStatus);

            //* Alternatif

            Console.Write("Mezuniyet Durumunuz(Önlisans/Lisans/Yüksek): ");
            string graduationStatus1 = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
            

            if (graduationStatus1 == "YÜKSEK" || graduationStatus1 == "ÖNLİSANS" || graduationStatus1 == "LİSANS")
            {
                Console.Write("Sigara Kullanıyor Musunuz?(E/H): ");
                char smokingStatus = char.ToUpper((Console.ReadLine() ?? string.Empty).FirstOrDefault());
                if (smokingStatus == 'H')
                {
                    Console.WriteLine("Tebrikler. İşe Alındınız.");
                } else
                {
                    Console.WriteLine("Üzgünüz. Sigara İçtiğiniz İçin İşe Alınmadınız.");
                }
            } else
            {
                Console.WriteLine("Üzgünüz. Mezuniyet Şartını Karşılamadığınız İçin İşe Alınmadınız.");
            }

            //? Username ve password üzerinden uygulamaya giriş kontrolü yap.

            string userName = "DZEL";
            string password = "12345";

            Console.Write("Kullanıcı Adınız: ");
            string enteredUserName = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
            Console.Write("Şifreniz: ");
            string enteredPassword = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();

            bool isUsernameMatch = enteredUserName == userName;
            bool isPasswordMatch = enteredPassword == password;
            bool isLogin = isUsernameMatch && isPasswordMatch;

            string loginStatus = isLogin ? "Giriş Başarılı" : "Kullanıcı Adı veya Şifre Hatalı";

            Console.WriteLine(loginStatus);

            //* Alternatif

            string userName1 = "DZEL";
            string password1 = "12345";

            Console.Write("Kullanıcı Adınız: ");
            string enteredUserName1 = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();
            Console.Write("Şifreniz: ");
            string enteredPassword1 = (Console.ReadLine() ?? string.Empty).ToUpper().Trim();

            bool isUsernameMatch1 = enteredUserName1 == userName1;
            bool isPasswordMatch1 = enteredPassword1 == password1;
            bool isLogin1 = isUsernameMatch1 && isPasswordMatch1;

            if (isLogin1)
            {
                Console.WriteLine("Giriş Başarılı");
            } else if (!isUsernameMatch1)
            {
                Console.WriteLine("Kullanıcı Adı Hatalı");
            } else if (!isPasswordMatch1)
            {
                Console.WriteLine("Şifre Hatalı");
            } else
            {
                Console.WriteLine("Kullanıcı Adı ve Şifre Hatalı");
            }
        }
    }
}