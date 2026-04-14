# ShoppingCartApp 🛒

A .NET 8 console application that models a shopping cart system using object-oriented programming principles. Built as a demonstration of **inheritance**, **polymorphism**, and **encapsulation** in C#, featuring a product hierarchy with five distinct categories and a fixed-capacity cart.

## Table of Contents

- [Features](#features)
- [Class Diagram](#class-diagram)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Product Categories](#product-categories)
- [Sample Output](#sample-output)

## Features

- **Fixed-capacity shopping cart** with configurable size
- **Add and remove products** with console feedback
- **Polymorphic product info** via `virtual`/`override` on `GetInfo()`
- **Five product categories**, each with category-specific properties
- **Shopping bag calculator** for grocery items (1 bag per 5 items, rounded up)
- **LINQ-based removal** that filters the internal product array

## Class Diagram

```text
Product (base class)
├── ClothingProduct      (size, color)
├── ElectronicsProduct   (brand, model)
├── HomeProduct          (size, color)
├── BeautyProduct        (brand, color)
└── GroceriesProduct     (quantity, shoppingBags)

ShoppingCart
└── manages a Product[] with add/remove operations

ProductCategory (enum)
└── Clothing | Electronics | Home | Beauty | Groceries
```

## Tech Stack

| Component        | Details                 |
| ---------------- | ----------------------- |
| Language         | C# 12                   |
| Runtime          | .NET 8 (`net8.0`)       |
| IDE              | Visual Studio 2022 17.9 |
| Implicit Usings  | Enabled                 |
| Nullable Context | Enabled                 |

## Project Structure

```text
ShoppingCartApp/
├── ShoppingCart/
│   ├── ShoppingCart.sln              # Visual Studio solution file
│   ├── Program/
│   │   ├── Program.cs                # Console entry point
│   │   └── Program.csproj            # Executable project (references ShoppingCartApp)
│   └── ShoppingCartApp/
│       ├── Product.cs                # Base product class
│       ├── ProductCategory.cs        # Product category enum
│       ├── ShoppingCart.cs           # Shopping cart logic
│       ├── ClothingProduct.cs        # Clothing subclass
│       ├── ElectronicsProduct.cs     # Electronics subclass
│       ├── HomeProduct.cs            # Home subclass
│       ├── BeautyProduct.cs          # Beauty subclass
│       ├── GroceriesProduct.cs       # Groceries subclass
│       └── ShoppingCartApp.csproj    # Class library project
├── .gitattributes
└── README.md
```

The solution is split into two projects:

- **Program** (Console Executable): Contains the `Main` entry point that demonstrates cart operations.
- **ShoppingCartApp** (Class Library): Contains all domain models, the `ShoppingCart` class, and the `ProductCategory` enum.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later
- (Optional) [Visual Studio 2022](https://visualstudio.microsoft.com/) version 17.9+

## Getting Started

### Clone the repository

```bash
git clone https://github.com/your-username/ShoppingCartApp.git
cd ShoppingCartApp
```

### Build the solution

```bash
dotnet build ShoppingCart/ShoppingCart.sln
```

### Run the application

```bash
dotnet run --project ShoppingCart/Program/Program.csproj
```

### Or use Visual Studio

1. Open `ShoppingCart/ShoppingCart.sln` in Visual Studio.
2. Set **Program** as the startup project.
3. Press **F5** or click **Start** to run.

## Usage

The application creates a shopping cart with a capacity of 5, populates it with sample products, displays their details, and then demonstrates product removal.

```csharp
ShoppingCart shoppingCart = new ShoppingCart(5);

ClothingProduct shirt = new ClothingProduct("Shirt", 10, ProductCategory.Clothing, "M", "Blue");
ElectronicsProduct phone = new ElectronicsProduct("Phone", 1000, ProductCategory.Electronics, "Samsung", "Galaxy S21");

shoppingCart.AddProduct(shirt);
shoppingCart.AddProduct(phone);

shoppingCart.RemoveProduct(phone);
```

## Product Categories

Each product type extends the base `Product` class and overrides `GetInfo()` to display category-specific attributes:

| Category    | Class                | Extra Properties       | Notes                                      |
| ----------- | -------------------- | ---------------------- | ------------------------------------------ |
| Clothing    | `ClothingProduct`    | Size, Color            |                                            |
| Electronics | `ElectronicsProduct` | Brand, Model           |                                            |
| Home        | `HomeProduct`        | Size, Color            |                                            |
| Beauty      | `BeautyProduct`      | Brand, Color           |                                            |
| Groceries   | `GroceriesProduct`   | Quantity, ShoppingBags | Bags calculated as `Ceiling(quantity / 5)` |

## Sample Output

```text
Shirt added to the shopping cart.
Phone added to the shopping cart.
Chair added to the shopping cart.
Lipstick added to the shopping cart.
Milk added to the shopping cart.

Name: Shirt
Price: 10
Category: Clothing
Size: M
Color: Blue

Name: Phone
Price: 1000
Category: Electronics
Brand: Samsung
Model: Galaxy S21

Name: Chair
Price: 50
Category: Home
Size: 21m
Color: Brown

Name: Lipstick
Price: 5
Category: Beauty
Brand: Matte
Color: Red

Name: Milk
Price: 2
Category: Groceries
Quantity: 24
Shopping Bags: 5

Number of items in the shopping cart: 5

Phone removed from the shopping cart.

Number of items in the shopping cart after removing a product: 4

Name: Shirt
Price: 10
Category: Clothing
Size: M
Color: Blue

Name: Chair
Price: 50
Category: Home
Size: 21m
Color: Brown

Name: Lipstick
Price: 5
Category: Beauty
Brand: Matte
Color: Red

Name: Milk
Price: 2
Category: Groceries
Quantity: 24
Shopping Bags: 5
```
