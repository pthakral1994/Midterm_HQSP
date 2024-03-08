public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Insufficient stock to complete the sale.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Item: {ItemName}, ID: {ItemId}, Price: {Price:C}, Stock: {QuantityInStock}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items
        item1.PrintDetails();
        item2.PrintDetails();

        // Sell some items and then print the updated details
        item1.SellItem(1); // Selling 1 laptop
        item2.SellItem(2); // Selling 2 smartphones
        Console.WriteLine("\nAfter selling some items:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Restock an item and print the updated details
        item1.RestockItem(5); // Restocking 5 laptops
        item1.UpdatePrice(1250.00);
        Console.WriteLine("\nAfter restocking laptops and updating price:");
        item1.PrintDetails();

        // Check if an item is in stock and print a message accordingly
        Console.WriteLine("\nChecking stock status:");
        Console.WriteLine(item1.ItemName + " is in stock: " + item1.IsInStock());
        Console.WriteLine(item2.ItemName + " is in stock: " + item2.IsInStock());
    }
}