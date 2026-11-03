using StrategyTask.Core;
using StrategyTask.ShippingStrategyPattern;

namespace StrategyTask;

internal partial class Program
{
    static void Main(string[] args)
    {
        var order = new Order
        {
            TotalPrice = 5001,
            ShippingAddress = "Cairo",
            TotalWeight = 30,
            IsPremiumCustomer = true,
            PaymentMethod = PaymentMethod.CreditCard,
            ShippingType = ShippingType.SameDay
        };

        Console.WriteLine("Enter shipping strategy you want ?" +
            "\n[1] Express \n[2] Standard \n[3] Same Day \n[4] International");
        while (true)
        {
            Console.WriteLine("------------------------------");
            int x = int.Parse(Console.ReadLine());

            IShippingStrategy shippingStrategy = x switch
            {
                1 => new ExpressShippinStrategy(),
                2 => new StandardShippinStrategy(),
                3 => new SameDayShippinStrategy(),
                4 => new InternationalShippinStrategy(),
                _ => throw new InvalidOperationException()
            };

            var service = new ShippingService(shippingStrategy);
            var result = service.CalculateShippingCost(order);

            if (result.IsSuccess)
                Console.WriteLine($"Shipping cost = {result.Value}");
            else
                Console.WriteLine(result.Error);

            Console.WriteLine("Press any key to continue :)");
            Console.ReadKey();
        }
        
    }
}

