namespace ShoppingCartApp
{
    // A derived class of Product for groceries products.
    public class GroceriesProduct : Product
    {
        // Fields
        // The quantity of the groceries product.
        private int quantity;
        // The shoppingBags of the groceries product.
        private int shoppingBags;

        // Properties
        // Gets the quantity of the groceries product.
        public int Quantity { get { return quantity; } }
        // Gets the shoppingBags of the groceries product.
        public int ShoppingBags { get { return shoppingBags; } }

        // Creates a new instance of the groceries class with the specified name, price, category, quantity, and shoppingBags.
        public GroceriesProduct(string name, double price, ProductCategory category, int quantity) : base(name, price, category)
        {
            this.quantity = quantity;
            this.shoppingBags = CalculateShoppingBags();
        }

        // Methods
        // Calculate the total amounut of shopping bags needed
        public int CalculateShoppingBags()
        {
            return (int)Math.Ceiling((double)this.quantity / 5);
        }
        // Gets the information about the groceries product.
        public override void GetInfo()
        {
            Console.WriteLine("Name: " + base.Name);
            Console.WriteLine("Price: " + base.Price);
            Console.WriteLine("Category: " + base.Category);
            Console.WriteLine("Quantity: " + this.quantity);
            Console.WriteLine("Shopping Bags: " + this.shoppingBags);
        }
    }
}