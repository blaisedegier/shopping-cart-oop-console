namespace ShoppingCartApp
{
    // A derived class of Product for electronics products.
    public class ElectronicsProduct : Product
    {
        // Fields
        // The brand of the electronics product.
        private string brand;
        // The model of the electronics product.
        private string model;

        // Properties
        // Gets the brand of the electronics product.
        public string Brand { get { return brand; } }
        // Gets the model of the electronics product.
        public string Model { get { return model; } }

        // Constructors
        // Creates a new instance of the ElectronicsProduct class with the specified name, price, category, brand, and model.
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model) : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        // Methods
        // Gets the information about the electronics product.
        public override void GetInfo()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Price: " + base.Price);
            Console.WriteLine("Category: " + base.Category);
            Console.WriteLine("Brand" + this.brand);
            Console.WriteLine("Model:" + this.model);
        }
    }
}
