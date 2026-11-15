namespace SimpleFactoryPattern.Core.DiscoutnStrategies;

public class NewCustomerDiscoutnStrategy : ICustomerDiscoutnStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return 0;
    }
}
