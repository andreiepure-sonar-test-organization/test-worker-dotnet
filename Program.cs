using TestWorkerDotnet;

var inventory = new Inventory();
inventory.Add("APPLE", 10);
inventory.Remove("APPLE", 3);
Console.WriteLine($"APPLE in stock: {inventory.QuantityOf("APPLE")}");
