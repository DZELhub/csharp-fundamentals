using System.Collections.Generic;
namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson58_ExceptionHandling
    {
        public static void Run()
        {     

        try {
            Console.Write("1. Sayı: "); 
            int number1 = Convert.ToInt32(Console.ReadLine());
            //? Kullanıcı int'e çevirilemeyecek bir giriş yapabilir: System.FormatException
            Console.Write("2. Sayı: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 / number2;
            //? Kullanıcı ikinci sayıyı "0" girebilir: System.DivideByZeroException
        }
        // catch(FormatException)
        //     {
        //         Console.WriteLine("Sayısal bilgileri düzgün giriniz");
        //     }
        //     catch (DivideByZeroException)
        //     {
        //         Console.WriteLine("2. sayı 0 olamaz");
        //     }
        //* Hataları tek tek ele almak yerine tümünü birden ele alabiliriz.
        // catch (Exception)
        //     {
        //         Console.WriteLine("Bir hata oluştu");
        //     }
        //* Hataları toplu olarak ele alırken ne olduğunu öğrenmek için;
            catch (Exception ex)
                { 
                    Console.WriteLine(
                        $"""
                        Bir hata oluştu
                        Hata Kaynağı: {ex.Message}
                        """
                    );
                }


        
                
    }

    }

   


}