using System.Collections;

namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson54_ArrayList
    {
        public static void Run()
        {
        //* non-generic => Tüm veriler object. Tip sınırı yok. Dinamik yapıda.

        ArrayList list = [10, "Celal", "10", null, true];

        ArrayList list2 = new ArrayList()
        {
            5, "Selim", false, 4.5, null
        };

        int[] numbers = {10, 20, 30};

        list.AddRange(numbers);

        list2.Add("DZEL");

        //? insert

        list.Insert(0, "Eklenen Eleman");

        list.InsertRange(list.Count, list2);

        list2.Insert(list2.Count, "Eklenen Eleman");

        list.Remove(null); //* Bulduğu ilk null'u siler
        list2.RemoveAt(1); //* Index numaralı elemanı siler
        list.RemoveRange(2,5); //* 2. indexten başla 5 eleman sil

        Console.WriteLine(
            $"İçeriyor mu: {list.Contains("Celal")}"
        );

        Console.WriteLine(
            $"İçerik Kontrol: {list2.IndexOf("DZEL")}"
        );


        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        foreach (var i in list2)
        {
            Console.WriteLine(i);
        }

        }
    }

    

    
}