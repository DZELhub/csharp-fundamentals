namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson23_ArithmeticOperators
    {
        public static void Run()
        {
            //? a=10, b=5, c=20 ise c - a b'nin kaç katıdır?

            int a = 10;
            int b = 5;
            int c= 20;

            int cMinusA = c - a;
            int multiplier = cMinusA / b;

            Console.WriteLine(
                $"{c} - {a} = {cMinusA}\n" +
                $"{cMinusA}, {b}'in {multiplier} katıdır"
            );

            //? int? d = 50, int e = 20 ise d + e kaçtır? a null ise sonuç nedir?

            int? d = 50;
            int e = 20;
            int total = (d ?? 0) + e;

            Console.WriteLine(
                $"d + e = {total}"
            );

            // d null gelirse sonuç 20 olur çünkü null değer gelirse 0 kabul edeceğiz.

            //? f = 10 g = 20 ise f=g--; atamasından sonra f ve g değerleri ne olur?
            // f'ya önce g'yi atayıp bden sonra çıkarma işlemi yaptığımız için f = 20 g = 19 olur

            int f = 10;
            int g = 20;

            f = g--;

            Console.WriteLine(
                $"f = {f}\n" +
                $"g = {g}"
            );

            //? Klavyeden girilen sayının tek/çift kontrolünü yapınız?

            Console.Write("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string oddEven = number % 2 == 0? "çift":"tek";

            Console.WriteLine(
                $"{number} sayısı {oddEven} sayıdır."
            );
        }
    }
}