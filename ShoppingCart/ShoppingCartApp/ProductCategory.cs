namespace ShoppingCartApp
{
    /// <summary>
    /// The categories a product can belong to. Each has a matching <see cref="Product"/> subclass.
    /// </summary>
    public enum ProductCategory
    {
        /// <summary>Clothing, see <see cref="ClothingProduct"/>.</summary>
        Clothing,

        /// <summary>Electronics, see <see cref="ElectronicsProduct"/>.</summary>
        Electronics,

        /// <summary>Home goods, see <see cref="HomeProduct"/>.</summary>
        Home,

        /// <summary>Beauty products, see <see cref="BeautyProduct"/>.</summary>
        Beauty,

        /// <summary>Groceries, see <see cref="GroceriesProduct"/>.</summary>
        Groceries
    }
}
