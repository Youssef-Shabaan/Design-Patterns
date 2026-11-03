using StrategyTask.Core;

namespace StrategyTask.ShippingStrategyPattern.PremiumMembership;

internal class AdditionalShippingService 
{
    public static decimal ApplyDiscountForPremiumMembership(Order order, decimal shippingCost)
    {
        shippingCost += totalWeightCostIfGreaterThan20Kg(order.TotalWeight);

        return order.IsPremiumCustomer ?
            shippingCost - shippingCost * 0.1m
            : shippingCost;
    }

    private static decimal totalWeightCostIfGreaterThan20Kg(decimal totalWeight)
    {
        decimal cost = 0;
        if (totalWeight > 20)
            cost = 100;
        return cost;
    }
}
