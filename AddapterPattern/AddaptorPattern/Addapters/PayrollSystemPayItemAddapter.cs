using AddaptorPattern.Core;

namespace AddaptorPattern.Addapters;

public class PayrollSystemPayItemAddapter
{
    private readonly PayItem _payItem;

    public PayrollSystemPayItemAddapter(PayItem payItem)
    {
        _payItem = payItem;
    }

    public string Name => _payItem.Name;
    public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 : _payItem.Value;
}
