using StrategyTask.Core;
using StrategyTask.ShippingStrategyPattern.PremiumMembership;

namespace StrategyTask.ShippingStrategyPattern;

internal class InternationalShippinStrategy : IShippingStrategy
{
    public Result<decimal> CalculateShippingCost(Order order)
    {
        if(order.PaymentMethod == PaymentMethod.CashOnDelivery)
        {
            return Result.Failure<decimal>("Cash on Delivery does't supported in International Shipping");
        }

        var shippingCost = 
            AdditionalShippingService.ApplyDiscountForPremiumMembership(order , 300 + (order.TotalPrice * 0.15m));

        return Result.Success(shippingCost);
    }
}
