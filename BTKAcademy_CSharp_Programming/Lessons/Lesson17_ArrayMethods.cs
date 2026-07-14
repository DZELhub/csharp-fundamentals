namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson17_ArrayMethods
    {
        public static void Run()
        {
            string[] cities = {"İstanbul","Çanakkale","Bursa"};
            Console.WriteLine(cities[1]);
            
            cities[1] = "Budapeşte";
            Console.WriteLine(cities[1]);

            cities.SetValue("Saraybosna",1);
            Console.WriteLine(cities[1]);

            Console.WriteLine(cities.GetValue(1));

            Console.WriteLine(cities.Length);

            Console.WriteLine(Array.IndexOf(cities, "Çanakkale"));

            Array.Sort(cities);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[0]);
            Array.Reverse(cities);
            Console.WriteLine(cities[0]);

            Array.Clear(cities);
            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);

            cities.SetValue("Saraybosna",0);
            cities.SetValue("Budapeşte",1);
            cities.SetValue("İstanbul",2);
            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);

            //? Mini Challenge 1 — Öğrenci Sistemi 🎓 5 elemanlı bir string dizisi oluştur. İçine öğrenci isimleri ekle. Sonra: ✅ bütün öğrencileri yazdır ✅ alfabetik sırala Array.Sort) ✅ tekrar yazdır ✅ ters çevir (Array.Reverse) ✅ tekrar yazdır ✅ "Ahmet" isimli öğrenci var mı kontrol et (Array.IndexOf)

            string[] students = {"Selim", "Hande", "Yüsra","Cihat","Ali"};
            Console.WriteLine("Öğrenci Listesi");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(
                    $"{i+1}." +
                    $"{students[i]}"
                );
            }

            Array.Sort(students);
            Console.WriteLine("Öğrenci Listesi");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(
                    $"{i+1}." +
                    $"{students[i]}"
                );
            }

            Array.Reverse(students);
            Console.WriteLine("Öğrenci Listesi");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(
                    $"{i+1}." +
                    $"{students[i]}"
                );
            }

            string name = "Ahmet";
            int searchIndex = Array.IndexOf(students, name);
            string searchStudent = searchIndex == -1 ? "mevcut değil" : "mevcut";
            Console.WriteLine(
                $"{name} isimli öğrenci listede {searchStudent}"
            );
        }
    }
}