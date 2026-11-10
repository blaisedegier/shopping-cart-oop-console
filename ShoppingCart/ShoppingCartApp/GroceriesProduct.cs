namespace ShoppingCartApp
{
    /// <summary>
    /// A grocery product, which adds a quantity and the number of shopping bags that quantity needs.
    /// </summary>
    public class GroceriesProduct : Product
    {
        /// <summary>How many units fit in one shopping bag.</summary>
        public const int UnitsPerBag = 5;

        /// <summary>
        /// Creates a grocery product with the given name, price, category and quantity.
        /// </summary>
        public GroceriesProduct(string name, decimal price, ProductCategory category, int quantity)
            : base(name, price, category)
        {
            Quantity = quantity;
            ShoppingBags = CalculateShoppingBags();
        }

        /// <summary>The number of units.</summary>
        public int Quantity { get; }

        /// <summary>The number of shopping bags needed for <see cref="Quantity"/>.</summary>
        public int ShoppingBags { get; }

        /// <summary>
        /// Returns the number of bags needed: one per <see cref="UnitsPerBag"/> units, rounded up.
        /// </summary>
        public int CalculateShoppingBags() => (Quantity + UnitsPerBag - 1) / UnitsPerBag;

        /// <inheritdoc />
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Shopping Bags: " + ShoppingBags);
        }
    }
}
