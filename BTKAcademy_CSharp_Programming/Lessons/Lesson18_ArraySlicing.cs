namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson18_ArraySlicing
    {
        public static void Run()
        {
            string[] cities = {"Budapest","Moscow","Minsk","Sarajevo","Berlin","Bucharest","İstanbul"};
            Console.WriteLine(cities.Length);
            foreach(var i in cities) {
                Console.WriteLine(i);
            }

            string[] result = cities[0..3]; 
            Console.WriteLine(result.Length);
            foreach(var i in result) {
                Console.WriteLine(i);
            }

            //*or

            string[] result2 = cities[..4];
            Console.WriteLine(result2.Length);

            string[] result3 = cities[2..];
            Console.WriteLine(result3.Length);
        }
    }
}