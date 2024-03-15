namespace ShoppingCartApp
{
    // A derived class of Product for clothing products.
    public class ClothingProduct : Product
    {
        // Fields
        // The size of the clothing product.
        private string size;
        // The color of the clothing product.
        private string color;

        // Properties
        // Gets the size of the clothing product.
        public string Size { get { return size; } }
        // Gets the color of the clothing product.
        public string Color { get { return color; } }

        // Creates a new instance of the ClothingProduct class with the specified name, price, category, size, and color.
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color) : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        // Methods
        // Gets the information about the clothing product.
        public override void GetInfo()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Price: " + base.Price);
            Console.WriteLine("Category: " + base.Category);
            Console.WriteLine("Size" + this.size);
            Console.WriteLine("Color:" + this.color);
        }
    }
}
