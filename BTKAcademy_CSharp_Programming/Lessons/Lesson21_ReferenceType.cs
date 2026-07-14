namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson21_ReferenceType
    {
        public static void Run()
        {
            int[] x = {10,20};
            int[] y = x;

            Console.WriteLine(x[0]); // 10
            Console.WriteLine(y[0]); // 10

            x[0] = 20;

            Console.WriteLine(x[0]); // 20
            Console.WriteLine(y[0]); // 20
        }
    }
}