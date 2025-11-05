namespace OpenReport_Blazor.Models;

public class InvoiceItem
{
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; } = 1;
    public decimal UnitPrice { get; set; } = 0m;
    public decimal Total => Quantity * UnitPrice;
}

