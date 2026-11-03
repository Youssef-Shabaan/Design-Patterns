using StrategyPattern.Core.DiscoutnStrategies;

namespace StrategyPattern.Core;

internal class InvoiceManager
{
    private ICustomerDiscoutnStrategy _customerDiscoutnStrategy = null!;
    public void SetDiscountStrategy(ICustomerDiscoutnStrategy customerDiscoutnStrategy)
    {
        _customerDiscoutnStrategy = customerDiscoutnStrategy;
    }

    public Invoice CreateInvoice(Customer customer, int quantity, double unitPrice)
    {
        var invoice = new Invoice
        {
            Customer = customer,
            Lines = new List<InvoiceLine>
            {
                new InvoiceLine { Quantity = quantity, UnitPrice = unitPrice }
            }
        };

        invoice.DiscountPercentage = _customerDiscoutnStrategy.CalculateDiscount(invoice.TotalPrice);

        return invoice;
    }
}
