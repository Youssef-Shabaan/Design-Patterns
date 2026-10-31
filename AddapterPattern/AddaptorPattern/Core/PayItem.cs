namespace AddaptorPattern.Core;

public class PayItem
{
    public string Name { get; set; } = string.Empty;
    public decimal Value { get; set; }
    public bool IsDeduction { get; set; }
}
