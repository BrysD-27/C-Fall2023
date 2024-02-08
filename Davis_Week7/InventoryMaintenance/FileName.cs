using System;

public class Product
{
    private string code;
    private string description;
    private decimal price;
    
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public Product() { }
    public Product(string code, string description, decimal price)
    {
        this.code = code;
        this.description = description;
        this.price = price;
    }

    public string ProductDetail()
    {
        return "The Product Number " + this.code + " is a " + this.description;
    }

    public string ProductPrice()
    {
        return "The Price for Product Number " + this.code + " is $" + this.price;
    }
}