using System.Collections.Generic;
using System.Linq;
namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson59_ExceptionThrowing
    {
        static void password_check(string password)
        {
            if(password.Length < 6 || password.Length > 10)
            {
                throw new Exception("Parola 6-10 karakter uzunluğunda olmalı");
            }
            if(!password.Any(char.IsDigit))
            {
                throw new Exception("Şifre en az bir rakam içermeli");
            }
            if (!password.Any(char.IsLetter))
            {
                throw new Exception("Şifre en az bir harf içermeli");
            }
            if (!password.Any(char.IsSymbol))
            {
                throw new Exception("Şifre en az bir sembol içermeli");
            }
        }
        public static void Run()
        {     

            Console.Write("Parolanız: ");
            string password = Console.ReadLine() ?? string.Empty;

            try
            {
                password_check(password);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        


        
                
    }

    }

   


}