using ShoppingCartApp;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Shopping Cart
            ShoppingCart shoppingCart = new ShoppingCart(5);

            // Create products to add to shopping cart
            ClothingProduct shirt = new ClothingProduct("Shirt", 10, ProductCategory.Clothing, "M", "Blue");
            ElectronicsProduct phone = new ElectronicsProduct("Phone", 1000, ProductCategory.Electronics, "Samsung", "Galaxy S21");
            HomeProduct chair = new HomeProduct("Chair", 50, ProductCategory.Home, "21m", "Brown");
            BeautyProduct lipstick = new BeautyProduct("Lipstick", 5, ProductCategory.Beauty, "Matte", "Red");
            GroceriesProduct milk = new GroceriesProduct("Milk", 2, ProductCategory.Groceries, 24);

            // Add products to shopping cart
            shoppingCart.AddProduct(shirt);
            shoppingCart.AddProduct(phone);
            shoppingCart.AddProduct(chair);
            shoppingCart.AddProduct(lipstick);
            shoppingCart.AddProduct(milk);
            Console.WriteLine();

            // Display product information in shopping cart
            foreach (Product product in shoppingCart.Products)
            {
                product.GetInfo();
                Console.WriteLine();
            }

            // Display the number of items in the shopping cart
            Console.WriteLine("Number of items in the shopping cart: " + shoppingCart.ItemCount);

            // Remove a product from the shopping cart
            Console.WriteLine();
            shoppingCart.RemoveProduct(phone);

            // Display the number of items in the shopping cart after removing a product
            Console.WriteLine("\nNumber of items in the shopping cart after removing a product: " + shoppingCart.ItemCount);
            Console.WriteLine();
            
            // Display product information in shopping cart
            foreach (Product product in shoppingCart.Products)
            {
                product.GetInfo();
                Console.WriteLine();
            }
        }
    }
}