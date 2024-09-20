using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //Product product = new Product();
        //product.Input();
        //product.Display();
        //Console.WriteLine($"Tax:{product.GetImportTax()}");
        //Product pd1 = new Product();
        //Product pd2 = new Product();
        //pd1.Input();
        //pd2.Input();
        //pd2.Display();
        //pd2.Display();
        Product pd1 = new Product("Tra Sua",20000,10);
        Product pd2 = new Product("Tra Dao", 15000);
        Console.WriteLine("\nProduct 1 details information:");
        pd1.Display();
        Console.WriteLine("\nProduct 2 details information:");
        pd2.Display();

        pd1.name = "Tra Vai";
        Console.WriteLine("\nUpdate product 1:");
        pd1.Display();

        pd2.price = 10000;
        Console.WriteLine("\nUpdate product 2:");
        pd2.Display();
    }
}
