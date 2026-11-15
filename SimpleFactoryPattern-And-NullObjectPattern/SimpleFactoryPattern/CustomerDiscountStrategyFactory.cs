using SimpleFactoryPattern.Core;
using SimpleFactoryPattern.Core.DiscoutnStrategies;

namespace SimpleFactoryPattern;

public class CustomerDiscountStrategyFactory
{
    public ICustomerDiscoutnStrategy CreateCustomerDisconutStrategy(CustomerCategory category)
    {
        if (category == CustomerCategory.Gold)
            return new GoldCustomerDiscoutnStrategy();

        else if (category == CustomerCategory.Silver)
            return new SilverCustomerDiscoutnStrategy();

        // Instead of return null (we return default implementation for this state)
        // This is null object pattern 
        return new NewCustomerDiscoutnStrategy();
    }
}
