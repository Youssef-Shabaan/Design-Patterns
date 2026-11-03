namespace StrategyPattern.Core.DiscoutnStrategies;

internal class GoldCustomerDiscoutnStrategy : ICustomerDiscoutnStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return totalPrice >= 10000 ?  0.1 : 0;
    }
}
