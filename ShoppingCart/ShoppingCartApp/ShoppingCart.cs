namespace ShoppingCartApp
{
    // A class that represents a shopping cart.
    public class ShoppingCart
    {
        // Fields
        // The products in the shopping cart.
        private Product[] products;
        // The number of items in the shopping cart.
        private int itemCount;

        // Properties
        // Gets the array of products in the shopping cart.
        public Product[] Products { get { return products; } }
        // Gets the number of items in the shopping cart.
        public int ItemCount { get { return itemCount; } }

        // Constructors
        // Creates a new instance of the ShoppingCart class with the specified capacity.
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }
        
        // Methods
        // Adds a product to the shopping cart.
        public void AddProduct(Product product)
        {
            products[itemCount++] = product;
            itemCount++;
        }
        // Removes a product from the shopping cart.
        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(products, product);
            for (int i = index + 1; i < products.Length; i++)
            {
                products[i - 1] = products[i];
            }
            products[products.Length - 1] = null;
            itemCount--;
        }
    }
}
