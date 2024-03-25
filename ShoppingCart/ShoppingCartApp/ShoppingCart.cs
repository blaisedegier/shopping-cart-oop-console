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
            products[itemCount] = product;
            itemCount++;
            Console.WriteLine(product.Name + " added to the shopping cart.");
        }

        // Removes a product from the shopping cart.
        public void RemoveProduct(Product product)
        {
            int oldLength = products.Length;
            products = products.Where(p => p != product).ToArray();
            if (oldLength != products.Length)
            {
                itemCount--;
                Console.WriteLine(product.Name + " removed from the shopping cart.");
            }
            else
            {
                Console.WriteLine("Product not found in the shopping cart.");
            }
        }
    }
}
