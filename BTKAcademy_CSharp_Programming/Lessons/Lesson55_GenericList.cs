using System.Collections.Generic;
namespace BTKAcademy_CSharp_Programming.Lessons
{
    public static class Lesson55_GenericList
    {
        public static void Run()
        {

            //* Generic List → Tipe bağımlı liste

            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);

            List<string> names = new List<string>() {"Celal","Selim","Binay"};

            List<Products> products = new List<Products>();

            products.Add(new Products() {Id=1, Title="Televizyon", Price= 10000});
            products.Add(new Products() {Id=2, Title="Telefon", Price= 20000});
            products.Add(new Products() {Id=3, Title="Laptop", Price= 30000});

            products.Insert(products.Count,new Products() {Id=4, Title="All in One", Price= 40000});

            products.RemoveAt(3);
            products.RemoveAt(0);

            foreach (var product in products)
            {
                Console.WriteLine(
                    $"""
                    {product.Id}.{product.Title}: {product.Price:C}
                    """
                );
            }

       
    }

    }

    class Products
    {
        public int Id {get; set;}
        public string Title {get; set;} = "";
        public decimal Price {get; set;}
    }

}