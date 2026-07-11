namespace MyFirstProject.Lessons
{
    public static class Lesson52_StaticMethods
    {
        public static void Run()
        {
          string result = HelperMethods.ReplaceChars("ölçme ve değerlendırme");
          Console.WriteLine(result);
        }
    }

    class HelperMethods
    {
        public static string ReplaceChars(string str)
        {
            return str.Replace("ö","o").Replace("ü","u").Replace("ı","i").Replace("ğ","g").Replace("ç","c");
        }
    }

    
}