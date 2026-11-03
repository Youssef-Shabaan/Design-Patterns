using StrategyTask.ShippingStrategyPattern;

namespace StrategyTask.Core;

public class ShippingService
{
    private IShippingStrategy _shippingStrategy;

    public ShippingService(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public void SwitchShippingStrategy(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public Result<decimal> CalculateShippingCost(Order order)
    {
        
        var shippingCost = _shippingStrategy.CalculateShippingCost(order);

        return shippingCost;
    }
}