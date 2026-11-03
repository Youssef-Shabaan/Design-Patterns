using StrategyTask.Core;
using StrategyTask.ShippingStrategyPattern.PremiumMembership;

namespace StrategyTask.ShippingStrategyPattern;

internal class ExpressShippinStrategy : IShippingStrategy
{
    public Result<decimal> CalculateShippingCost(Order order)
    {
        decimal shippingCost = 
            AdditionalShippingService.ApplyDiscountForPremiumMembership(order ,100 + (order.TotalPrice * 0.05m));

        return Result.Success(shippingCost);
    }
}
