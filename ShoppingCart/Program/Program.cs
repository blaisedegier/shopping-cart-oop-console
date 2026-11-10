using ShoppingCartApp;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart(5);

            ClothingProduct shirt = new ClothingProduct("Shirt", 10, ProductCategory.Clothing, "M", "Blue");
            ElectronicsProduct phone = new ElectronicsProduct("Phone", 1000, ProductCategory.Electronics, "Samsung", "Galaxy S21");
            HomeProduct chair = new HomeProduct("Chair", 50, ProductCategory.Home, "21m", "Brown");
            BeautyProduct lipstick = new BeautyProduct("Lipstick", 5, ProductCategory.Beauty, "Matte", "Red");
            GroceriesProduct milk = new GroceriesProduct("Milk", 2, ProductCategory.Groceries, 24);
            ClothingProduct jacket = new ClothingProduct("Jacket", 60, ProductCategory.Clothing, "L", "Black");

            // Fill the cart, then try one more than it can hold.
            Add(shoppingCart, shirt);
            Add(shoppingCart, phone);
            Add(shoppingCart, chair);
            Add(shoppingCart, lipstick);
            Add(shoppingCart, milk);
            Add(shoppingCart, jacket);

            PrintCart(shoppingCart);

            // Removing a product frees a slot without shrinking the cart, so the jacket now fits.
            Remove(shoppingCart, phone);
            Remove(shoppingCart, phone);
            Add(shoppingCart, jacket);

            PrintCart(shoppingCart);
        }

        static void Add(ShoppingCart cart, Product product)
        {
            Console.WriteLine(cart.AddProduct(product)
                ? $"{product.Name} added to the shopping cart."
                : $"{product.Name} not added: the cart is full ({cart.Capacity} items).");
        }

        static void Remove(ShoppingCart cart, Product product)
        {
            Console.WriteLine(cart.RemoveProduct(product)
                ? $"{product.Name} removed from the shopping cart."
                : $"{product.Name} is not in the shopping cart.");
        }

        static void PrintCart(ShoppingCart cart)
        {
            Console.WriteLine();
            Console.WriteLine($"Items in the shopping cart: {cart.ItemCount} of {cart.Capacity}");
            Console.WriteLine();

            // Each product prints its own details through the virtual GetInfo method.
            foreach (Product product in cart.Products)
            {
                product.GetInfo();
                Console.WriteLine();
            }
        }
    }
}
