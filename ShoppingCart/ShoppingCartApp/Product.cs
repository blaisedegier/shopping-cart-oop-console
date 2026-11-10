namespace ShoppingCartApp
{
    /// <summary>
    /// The base class for every product: a name, a price and a category.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Creates a product with the given name, price and category.
        /// </summary>
        public Product(string name, decimal price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        /// <summary>The product's display name.</summary>
        public string Name { get; set; }

        /// <summary>The unit price.</summary>
        public decimal Price { get; set; }

        /// <summary>The category the product belongs to.</summary>
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Writes the product's details to the console. Derived classes call this and then add their own fields.
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine($"Price: {Price:0.00}");
            Console.WriteLine("Category: " + Category);
        }
    }
}
