namespace ShoppingCartApp
{
    /// <summary>
    /// A shopping cart that holds up to a fixed number of products.
    /// </summary>
    public class ShoppingCart
    {
        private readonly List<Product> products;

        /// <summary>
        /// Creates an empty cart that can hold at most <paramref name="capacity"/> products.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The capacity is less than 1.</exception>
        public ShoppingCart(int capacity)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(capacity, 1);
            Capacity = capacity;
            products = new List<Product>(capacity);
        }

        /// <summary>The maximum number of products the cart can hold. Removing a product does not change it.</summary>
        public int Capacity { get; }

        /// <summary>The products currently in the cart, in the order they were added.</summary>
        public IReadOnlyList<Product> Products => products;

        /// <summary>The number of products currently in the cart.</summary>
        public int ItemCount => products.Count;

        /// <summary>Whether the cart has reached its capacity.</summary>
        public bool IsFull => products.Count >= Capacity;

        /// <summary>
        /// Adds a product if there is room.
        /// </summary>
        /// <returns><see langword="true"/> if the product was added; <see langword="false"/> if the cart is full.</returns>
        public bool AddProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);
            if (IsFull)
            {
                return false;
            }
            products.Add(product);
            return true;
        }

        /// <summary>
        /// Removes a product from the cart.
        /// </summary>
        /// <returns><see langword="true"/> if the product was in the cart and has been removed; otherwise <see langword="false"/>.</returns>
        public bool RemoveProduct(Product product) => products.Remove(product);
    }
}
