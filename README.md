# Shopping Cart (OOP console)

A .NET console program and class library that model a capacity-limited shopping cart over a small product class hierarchy.

[![CI](https://github.com/blaisedegier/shopping-cart-oop-console/actions/workflows/ci.yml/badge.svg)](https://github.com/blaisedegier/shopping-cart-oop-console/actions/workflows/ci.yml)

## What it does

The console program creates a cart with room for five products and then:

1. Adds five products, one from each category, and tries a sixth, which is refused because the cart is full.
2. Prints every product's details.
3. Removes one product, tries to remove it again (reported as not in the cart), and adds the refused product into
   the freed slot.
4. Prints the cart again.

Grocery products also report how many shopping bags they need, at five units per bag rounded up.

## How it works

The solution has two projects: `ShoppingCartApp`, a class library with the domain types, and `Program`, the console
entry point that drives it.

`Product` holds the name, price and category and declares a virtual `GetInfo()`. Each subclass adds its own
fields and overrides `GetInfo()`, calling the base version first and then printing what it adds:

| Category    | Class                | Adds                   |
| ----------- | -------------------- | ---------------------- |
| Clothing    | `ClothingProduct`    | Size, Color            |
| Electronics | `ElectronicsProduct` | Brand, Model           |
| Home        | `HomeProduct`        | Size, Color            |
| Beauty      | `BeautyProduct`      | Brand, Color           |
| Groceries   | `GroceriesProduct`   | Quantity, ShoppingBags |

The demo prints the cart through a `foreach` over `Product`, so each object's own override runs.

`ShoppingCart` wraps a `List<Product>` with a fixed `Capacity`. `AddProduct` returns `false` instead of throwing
when the cart is full, and `RemoveProduct` returns whether anything was removed; removing a product frees a slot
without lowering the capacity. The library does no console output of its own for cart operations: the caller
decides what to print. Prices are `decimal`.

## Running it

Prerequisites: the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0). Runs on Windows, macOS and Linux.

```bash
git clone https://github.com/blaisedegier/shopping-cart-oop-console.git
cd shopping-cart-oop-console
dotnet build ShoppingCart/ShoppingCart.sln -c Release
dotnet run --project ShoppingCart/Program/Program.csproj -c Release
```

## Tech

C# 14, .NET 10 (`net10.0`), console app plus class library. No NuGet packages.

## Known limitations

- The products and actions are fixed in `Program.cs`; there is no interactive input.
- A cart holds products, not quantities: the same product object can be added more than once and takes a slot each time.
- No automated tests; CI builds the solution and runs the demo.

## Licence

MIT. See [LICENSE](LICENSE).
