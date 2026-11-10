namespace ShoppingCartApp
{
    /// <summary>
    /// A clothing product, which adds a size and a colour to the base product.
    /// </summary>
    public class ClothingProduct : Product
    {
        /// <summary>
        /// Creates a clothing product with the given name, price, category, size and colour.
        /// </summary>
        public ClothingProduct(string name, decimal price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            Size = size;
            Color = color;
        }

        /// <summary>The garment size, for example "M".</summary>
        public string Size { get; }

        /// <summary>The colour of the garment.</summary>
        public string Color { get; }

        /// <inheritdoc />
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Size: " + Size);
            Console.WriteLine("Color: " + Color);
        }
    }
}
