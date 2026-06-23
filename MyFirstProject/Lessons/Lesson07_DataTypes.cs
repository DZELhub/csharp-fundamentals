namespace MyFirstProject.Lessons
{
    public static class Lesson07_DataTypes
    {
        public static void Run()
        {
            //? Mini Challenge 🚀 Şunları yap: Bir byte değişken oluştur ve sınırı aşmayı dene. Bir float, double ve decimal değişken oluştur. Bir char ve bir string oluştur. Şunu test et: int a = 10; int b = a; b = 99; Sonra: a ve b değerlerini yazdır ve neden farklı olduklarını açıklamaya çalış.

            byte number = 100;
            Console.WriteLine(number);

            byte number2 = 255;
            Console.WriteLine(number2);

            // byte number3 = 256; //* Çalışmaz çünkü sınırı aştık
            // Console.WriteLine(number3);

            float number4 = 12.5f;
            Console.WriteLine(number4);

            double number5 = 122.500;
            Console.WriteLine(number5);

            decimal number6 = 135400m;
            Console.WriteLine($"{number6:C}");

            char letter = 'C';
            Console.WriteLine(letter);

            string fullName = "Celal Selim Binay";
            Console.WriteLine(fullName);

            int a = 10;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = 99;
            Console.WriteLine(b);
        }
    }
}