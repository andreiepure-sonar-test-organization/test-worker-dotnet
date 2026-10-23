namespace TestWorkerDotnet;

public class Inventory
{
    private readonly Dictionary<string, int> _stock = new();

    // Intentional issue: this private field is never used.
    private readonly string _unusedLabel = "inventory";

    public void Add(string sku, int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive.");
        }

        _stock[sku] = QuantityOf(sku) + quantity;
    }

    public bool Remove(string sku, int quantity)
    {
        var available = QuantityOf(sku);
        if (available < quantity)
        {
            return false;
        }

        _stock[sku] = available - quantity;
        return true;
    }

    public int QuantityOf(string sku) => _stock.GetValueOrDefault(sku, 0);

    // Intentional issue: the exception is swallowed by an empty catch block.
    public int ParseQuantity(string raw)
    {
        try
        {
            return int.Parse(raw);
        }
        catch (FormatException)
        {
        }

        return 0;
    }
}
