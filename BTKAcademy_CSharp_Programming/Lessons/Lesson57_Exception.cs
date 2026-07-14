using System.Collections.Generic;
namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson57_Exception
    {
        public static void Run()
        {
        //* Exception

        Console.Write("1. Sayı: "); 
        int number1 = Convert.ToInt32(Console.ReadLine());
        //? Kullanıcı int'e çevirilemeyecek bir giriş yapabilir: System.FormatException
        Console.Write("2. Sayı: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int result = number1 / number2;
        //? Kullanıcı ikinci sayıyı "0" girebilir: System.DivideByZeroException

        Product product = null;
        Console.WriteLine(product.productName);
        //? System.NullReferenceException
                
    }

    }

    class Product
    {
        public string productName {get; set;} = "";
    }


}