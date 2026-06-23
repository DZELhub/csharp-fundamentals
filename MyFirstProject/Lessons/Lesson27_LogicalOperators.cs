namespace MyFirstProject.Lessons
{
    public static class Lesson27_LogicalOperators
    {
        public static void Run()
        {
            bool a = true;
            bool b = true;
            bool c = false;
            bool d = false;

            bool result = (a && b);
            bool result1 = (a && c);
            bool result2= (c && d);

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            bool result3 = (a || b);
            bool result4 = (c || b);
            bool result5 = (c || d);

            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            bool result6 = !(a || b);
            bool result7 = !(c || b);
            bool result8 = !(c || d);

            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);

            //? Mini Challenge 1 🚀 Bir kullanıcının: bool hasMembership = true; bool paidSubscription = false; değerleri olsun. Kontrol et: Üyeliği var mı ve aboneliği var mı? Üyeliği var mı veya aboneliği var mı? İkisinin de olmadığı durum nedir? Sonuçları yazdır.

            bool hasMembership = true;
            bool paidSubscription = false;

            bool memberAndSubscripton = hasMembership && paidSubscription;
            bool memberOrSubscription = hasMembership || paidSubscription;
            bool notMemberAndSubscription = !hasMembership && paidSubscription;

            Console.WriteLine(
                $"""
                Üyeliği ve Aboneliği Var Mı: {memberAndSubscripton}
                Üyeliği veya Aboneliği Var Mı: {memberOrSubscription}
                Üyelik ve Abonelik Yoksa: {notMemberAndSubscription};
                """
            );

            //? Mini Challenge 2 🚀 Bir öğrencinin: int grade = 75; int absence = 3; değerleri olsun. Kontrol et: Notu 50 veya daha büyük mü? Devamsızlığı 5'ten az mı? Hem notu yeterli hem devamsızlığı uygun mu?

            int grade = 75;
            int absence = 3;

            bool gradeBiggerThan50 = grade == 50 || grade > 50;
            bool absenceLesserThan5 = absence < 5;
            bool canGraduate = gradeBiggerThan50 && absenceLesserThan5;

            Console.WriteLine(
                $"""
                Grade Greater Than or Equal to 50: {gradeBiggerThan50}
                Absence Lesser Than 5: {absenceLesserThan5};
                Graduation Status: {canGraduate}
                """
            );

            //? Ek Görev 🚀 (Biraz Daha Zor) Bir kullanıcı için: bool isAdmin = false; bool isModerator = true; bool isBanned = false; şunları hesapla: Yönetim paneline girebilir mi? Admin VEYA Moderatör olmalı VE Banlı olmamalı. Banlı mı? Yetkili kullanıcı mı? Sonuçları bool olarak yazdır.

            bool isAdmin = false;
            bool isModerator = true;
            bool isBanned = false;

            bool canLoginManagementPanel = (isAdmin || isModerator) && !isBanned;
            // Banlı mı? sorusunun yapmama gerek yok çünkü isBanned olarak false verdik zaten. Tekrar aynı kodu yazmak anlamlı olmaz.
            bool isAuthorized = isAdmin || isModerator;

            Console.WriteLine(
                $"""
                Can Login Management Panel: {canLoginManagementPanel}
                Is Banned: {isBanned}
                Is Authorized: {isAuthorized}
                """
            );

            //? Ek Task 🚀 Bu biraz daha gerçek hayat senaryosu: bool hasDrivingLicense = true; bool ownsCar = false; bool hasInsurance = true; Aşağıdakileri hesapla: Aracı kullanabilir mi? Ehliyeti olmalı VE Arabası olmalı VE Sigortası olmalı. Araç sahibi mi? Yasal olarak trafiğe çıkabilir mi? Bu üç koşuldan herhangi biri eksik mi?

            bool hasDrivingLicense = true;
            bool ownsCar = false;
            bool hasInsurance = true;

            bool canDrive = hasDrivingLicense && ownsCar && hasInsurance;
            bool legallyDriven = hasDrivingLicense && hasInsurance || ownsCar; // Arabası olmasa da yasal olarak araba kullanabilir. Aracının olmaması engel değil.
            bool areConditionsMet = hasDrivingLicense && ownsCar && hasInsurance;

            Console.WriteLine(
                $"""
                Can Drive: {canDrive}
                Legally Driven on the Road: {legallyDriven}
                Are All Conditions Met: {areConditionsMet}
                """
            );
        }
    }
}