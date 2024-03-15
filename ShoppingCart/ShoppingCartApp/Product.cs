namespace ShoppingCartApp
{
    // The base class for all products.
    public class Product
    {
        // Fields
        // The name of the product.
        private string name;
        // The price of the product.
        private double price;
        // The category of the product.
        private ProductCategory category;

        // Properties
        // Gets the name of the product.
        public string Name { get { return name; } set { name = value; } }
        // Gets the price of the product.
        public double Price { get { return price; } set { price = value; } }
        // Gets the category of the product.
        public ProductCategory Category { get { return category; } set { category = value; } }

        // Constructors
        // Creates a new instance of the Product class with the specified name, price & category.
        public Product(string name, double price, ProductCategory category)
        { 
            this.name = name;
            this.price = price;
            this.category = category;
        }

        // Methods
        // Gets the information about the product.
        public virtual void GetInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Price: " + this.price);
            Console.WriteLine("Category: " + this.category);
        }
    }
}