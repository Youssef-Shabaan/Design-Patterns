using StrategyTask.Core;
using StrategyTask.ShippingStrategyPattern.PremiumMembership;

namespace StrategyTask.ShippingStrategyPattern;

internal class StandardShippinStrategy : IShippingStrategy
{
    public Result<decimal> CalculateShippingCost(Order order)
    {
        if (order.TotalPrice > 5000)
        {
            return Result
                .Success(AdditionalShippingService.ApplyDiscountForPremiumMembership(order, 0.0m));
        }

        var shippingCost = 
            AdditionalShippingService.ApplyDiscountForPremiumMembership(order, 50 + (order.TotalPrice * 0.02m));

        return Result.Success(shippingCost);
    }
}
