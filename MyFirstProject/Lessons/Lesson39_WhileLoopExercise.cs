namespace MyFirstProject.Lessons
{
    public static class Lesson39_WhileLoopExercise
    {
        public static void Run()
        {
            //? Kullanıcıya 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalış. 10 hak ver, aşağı ve yukarı yönlendirme yap. Kaçıncı tahmin? 

            int right = 10;
            int count = 0;
            var rnd = new Random();
            int number = rnd.Next(1,101);
            Console.WriteLine(number);

            while (right > 0)
            {
                
                Console.Write("1-100 arası sayı giriniz: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                count ++;

                if (guess == number) {
                    Console.WriteLine($"Tebrikler Kazandınız | {count} denemede bildiniz."); 
                    break;
                };

                right --;

                if (right == 0) {
                    Console.WriteLine(
                        $"""
                        Hakkınız Kalmadı
                        Sayı: {number}
                        """);
                    break;
                }    

                if (guess > number) {
                    Console.WriteLine($"Aşağı ↓ | Kalan Hak: {right}");
                } else if (guess < number) {
                    Console.WriteLine($"Yukarı ↑ | Kalan Hak: {right}");
                }  
            }
        }
    }
}