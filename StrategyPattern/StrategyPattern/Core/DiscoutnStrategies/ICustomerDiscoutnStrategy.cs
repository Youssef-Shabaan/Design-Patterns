namespace StrategyPattern.Core.DiscoutnStrategies;

internal interface ICustomerDiscoutnStrategy
{
    public double CalculateDiscount(double totalPrice);
}
