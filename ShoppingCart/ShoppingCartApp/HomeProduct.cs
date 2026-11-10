namespace ShoppingCartApp
{
    /// <summary>
    /// A home product, which adds a size and a colour to the base product.
    /// </summary>
    public class HomeProduct : Product
    {
        /// <summary>
        /// Creates a home product with the given name, price, category, size and colour.
        /// </summary>
        public HomeProduct(string name, decimal price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            Size = size;
            Color = color;
        }

        /// <summary>The size of the item, as free text.</summary>
        public string Size { get; }

        /// <summary>The colour of the item.</summary>
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
