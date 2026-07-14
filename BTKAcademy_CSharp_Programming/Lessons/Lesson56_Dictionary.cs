using System.Collections.Generic;
namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson56_Dictionary
    {
        public static void Run()
        {
            //* Dictionary: Key - Value → Plaka - Şehir. Generic.

            Dictionary<int, string> plates = new Dictionary<int, string>();

            plates.Add(34, "İstanbul");
            plates.Add(17, "Çanakkale");
            plates.Add(16, "Bursa");

            foreach (var item in plates)
            {
                Console.WriteLine(
                    $"{item.Value} şehrinin plaka kodu: {item.Key}"
                );
            }

            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {1, "Bir"},
                {2, "İki"},
                {3, "Üç"}
            };

            numbers[1] = "One";

            numbers.Remove(1);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            
           

       
    }

    }


}