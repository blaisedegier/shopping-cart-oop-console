namespace ShoppingCartApp
{
    /// <summary>
    /// A beauty product, which adds a brand and a colour to the base product.
    /// </summary>
    public class BeautyProduct : Product
    {
        /// <summary>
        /// Creates a beauty product with the given name, price, category, brand and colour.
        /// </summary>
        public BeautyProduct(string name, decimal price, ProductCategory category, string brand, string color)
            : base(name, price, category)
        {
            Brand = brand;
            Color = color;
        }

        /// <summary>The brand of the product.</summary>
        public string Brand { get; }

        /// <summary>The colour of the product.</summary>
        public string Color { get; }

        /// <inheritdoc />
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Color: " + Color);
        }
    }
}
