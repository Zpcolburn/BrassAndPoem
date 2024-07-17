using System;
using System.Numerics;
using System.Linq;
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "The Sun and Her Flowers",
        Price = 12.99m,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Yamaha YTR-2330 Standard Bb Trumpet",
        Price = 499.99m,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Milk and Honey",
        Price = 15.49m,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Bach 42BO Stradivarius Series Trombone",
        Price = 799.99m,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "The Collected Poems of W.B. Yeats",
        Price = 10.75m,
        ProductTypeId = 1
    }
};

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Poetry Books",
        Id = 1
    },
    new ProductType()
    {
        Title = "Brass Instruments",
        Id = 2
    }
};

string greeting = @"Welcome to Brass & Poem – Your One-Stop Shop for Timeless Brass Instruments and Soul-Stirring Poetry!";
Console.WriteLine(greeting);

string choice = null;
while (choice != "5")
{
    Console.WriteLine(@"Please choose a option:
                        1. Display menu
                        2. Display all products
                        3. Delete a product
                        4. Add a new product
                        5. Update product
                        6. Exit");

    choice = Console.ReadLine();
    if (choice == "1")
    {
        DisplayMenu();
    }
    else if (choice == "2")
    {
        DisplayAllProducts();
    }
    else if (choice == "3")
    {
        // DeleteProduct();
    }
    else if (choice == "4")
    {
        // AddProduct();
    }
    else if (choice == "5")
    {
        // UpdateProduct();
    }
    else if (choice == "6")
    {
        Console.WriteLine("Goodbye!");
    }

}
void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Please choose a option:
                        1. Display all products
                        2. Delete a product
                        3. Add a new product
                        4. Update product
                        5. Exit");

        choice = Console.ReadLine();

        if (choice == "1")
        {
            DisplayAllProducts();
        }
        else if (choice == "2")
        {
            // DeleteProduct();
        }
        else if (choice == "3")
        {
            // AddProduct();
        }
        else if (choice == "4")
        {
            // UpdateProduct();
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
    }
}    

void DisplayAllProducts()
{
    for (int i = 0; i < products.Count; i++)
    {
        string title = productTypes.First(p => p.Id == products[i].ProductTypeId).Title;
        Console.WriteLine($"Item:{products[i].Name} Price: {products[i].Price} Type: {title} ");
    }
}
void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
     throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
     throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
     throw new NotImplementedException();
}
// don't move or change this!
public partial class Program { }