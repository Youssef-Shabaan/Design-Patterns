namespace SimpleFactoryPattern.Core.DiscoutnStrategies;

public class SilverCustomerDiscoutnStrategy : ICustomerDiscoutnStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return totalPrice >= 10000 ?  0.05 : 0;
    }
}
