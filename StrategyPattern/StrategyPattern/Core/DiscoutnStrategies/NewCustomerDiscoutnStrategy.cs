namespace StrategyPattern.Core.DiscoutnStrategies;

internal class NewCustomerDiscoutnStrategy : ICustomerDiscoutnStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return 0;
    }
}
