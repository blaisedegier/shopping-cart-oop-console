namespace ShoppingCartApp
{
    /// <summary>
    /// An electronics product, which adds a brand and a model to the base product.
    /// </summary>
    public class ElectronicsProduct : Product
    {
        /// <summary>
        /// Creates an electronics product with the given name, price, category, brand and model.
        /// </summary>
        public ElectronicsProduct(string name, decimal price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            Brand = brand;
            Model = model;
        }

        /// <summary>The manufacturer's brand.</summary>
        public string Brand { get; }

        /// <summary>The model name or number.</summary>
        public string Model { get; }

        /// <inheritdoc />
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
    }
}
