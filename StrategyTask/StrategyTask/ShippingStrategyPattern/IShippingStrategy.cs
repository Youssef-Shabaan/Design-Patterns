using StrategyTask.Core;

namespace StrategyTask.ShippingStrategyPattern;

public interface IShippingStrategy
{
    Result<decimal> CalculateShippingCost(Order order);
}
