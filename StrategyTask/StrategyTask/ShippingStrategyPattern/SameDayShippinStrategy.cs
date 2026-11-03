using StrategyTask.Core;
using StrategyTask.ShippingStrategyPattern.PremiumMembership;

namespace StrategyTask.ShippingStrategyPattern;

internal class SameDayShippinStrategy : IShippingStrategy
{
    public Result<decimal> CalculateShippingCost(Order order)
    {
        if (order.ShippingAddress.Contains("Cairo"))
        {
            decimal shippingCost = 
                AdditionalShippingService.ApplyDiscountForPremiumMembership(order, 150 + (order.TotalPrice * 0.08m));
            return Result.Success(shippingCost);
        }
        
        return Result.Failure<decimal>("Same day shipping is not available in this area");
    }
}
