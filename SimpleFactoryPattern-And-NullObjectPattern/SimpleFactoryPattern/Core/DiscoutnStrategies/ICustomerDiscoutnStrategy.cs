namespace SimpleFactoryPattern.Core.DiscoutnStrategies;

public interface ICustomerDiscoutnStrategy
{
    public double CalculateDiscount(double totalPrice);
}
