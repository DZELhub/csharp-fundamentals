namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson02_Variables
    {
        public static void Run()
        {
            int x = 10;
            int y = 20;
            int total = x + y;
            Console.WriteLine(total);

            string name = "Celal Selim";
            string surname = "Binay";
            string city = "Çanakkale";
            int age = 38;

            Console.WriteLine("Ad: "+name);
            Console.WriteLine("Soyad: "+surname);
            Console.WriteLine("Şehir: "+city);
            Console.WriteLine("Yaş: "+age);
        }
    }
}