using System;

public class Product
{
    private string Name;
    private double Price;
    private double Discount;

    public Product() { }
    public Product(string name, double price, double discount)
    {
        Name = name;
        Price = price;
        Discount = discount;
    }
    public Product(string name,double price)
    {
        Name = name; 
        Price = price;
        Discount = 0.0;
    }
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    public double price
    {
        get { return Price; }
        set
        {
            if(value >= 0)
            {
                Price = value;
            }
            else
            {
                throw new ArgumentException("Price can't be negative.");
            }
        }
    }
    public double discount
    {
        get { return Discount; }
        set
        {
            if(value >= 0 && value <= 100)
            {
                Discount = value;
            }
            else
            {
                throw new ArgumentException("Discount must be between 0 and 100.");
            }
        }
    }
    private double GetImportTax()
    {
        double result = 0.1 * Price;
        return result;
    }
    public void Input()
    {
        Console.Write("Enter product name: ");
        Name = Console.ReadLine();
        Console.Write("Enter product price: ");
        Price = double.Parse(Console.ReadLine());
        Console.Write("Enter discount: ");
        Discount = double.Parse(Console.ReadLine());
    }
    public void Display()
    {
        Console.WriteLine($"Product Name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Discount: {Discount}%");
    }
}
