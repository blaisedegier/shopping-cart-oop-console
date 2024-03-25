namespace ShoppingCartApp
{
    // A derived class of Product for beauty products.
    public class BeautyProduct : Product
    {
        // Fields
        // The brand of the beauty product.
        private string brand;
        // The color of the beaity product.
        private string color;

        // Properties
        // Gets the brand of the beauty product.
        public string Brand { get { return brand; } }
        // Gets the color of the beauty product.
        public string Color { get { return color; } }

        // Creates a new instance of the BeautyProduct class with the specified name, price, category, brand, and color.
        public BeautyProduct(string name, double price, ProductCategory category, string brand, string color) : base(name, price, category)
        {
            this.brand = brand;
            this.color = color;
        }

        // Methods
        // Gets the information about the beauty product.
        public override void GetInfo()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Price: " + base.Price);
            Console.WriteLine("Category: " + base.Category);
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Color: " + this.color);
        }
    }
}