namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson40_DoWhile
    {
        public static void Run()
        {
            // int i = 1;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // } while (i < 10);

            // Console.Write("Adet: ");
            // int amount = Convert.ToInt32(Console.ReadLine());

            // string[] products = new string[amount];
            // int i = 0;

            // do
            // {
            //     Console.Write("Ürün Adı: ");
            //     products[i] = Console.ReadLine() ?? "Ürün Adı Yok";
            //     i ++;
            // } while (amount != i);

            // Console.WriteLine("Ürünler Listeleniyor...");

            // for (int a = 0; a < products.Length; a++)
            // {
            //     Console.WriteLine(products[a]);
            // }

            //? Görev 1: Kullanıcıdan sayı al. 0 girene kadar devam et (do-while ile) toplamı yazdır

            // int number = 0;
            // int sum = 0;

            // do
            // {
            //    Console.Write("Bir Sayı Giriniz(Çıkış için 0): ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    sum += number;
            // } while (number != 0);
            // Console.WriteLine($"Girdiğiniz Sayıların Toplamı: {sum}");

            //? Görev 2 (Zor) Kullanıcıdan ürün al. "exit" yazana kadar devam et.

            // string product = "";

            // do
            // {
            //     Console.Write("Ürün Adı(Çıkış: exit): ");
            //     product = Console.ReadLine() ?? "Ürün Adı Yok";
            // } while (product != "exit");

            //? Görev 3 (Unity Mantığı 🎮) Oyun menüsü: 1- Başla 2- Çık Kullanıcı çık diyene kadar tekrar göster (do-while)

            int option = 0;
            do
            {
                Console.Write(
                    """
                    1 → Başla
                    2 → Çık
                    Lütfen Seçiniz: 
                    """
                );
                option = Convert.ToInt32(Console.ReadLine());

                if (option <= 0 || option > 2) {Console.WriteLine("Hatalı Seçim. Lütfen Tekrar Deneyiniz.");}

            } while (option != 2);

            Console.WriteLine("Çıkış Yaptınız");
        }
    }
}