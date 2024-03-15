using ShoppingCartApp;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Shopping Cart
            ShoppingCart shoppingCart = new ShoppingCart(5);
            // Create Products
            ClothingProduct shirt = new ClothingProduct("Shirt", 10, ProductCategory.Clothing, "L", "White");
            ElectronicsProduct phone = new ElectronicsProduct("Phone", 100, ProductCategory.Electronics, "Apple", "15");
            // Add Products
            shoppingCart.AddProduct(phone);
            shoppingCart.AddProduct(shirt);
            // Remove Product
            shoppingCart.RemoveProduct(phone);
        }
    }
}