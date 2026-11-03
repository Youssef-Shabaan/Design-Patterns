using StrategyPattern.Core;
using StrategyPattern.Core.DiscoutnStrategies;

namespace StrategyPattern;

internal class Program
{
    static void Main(string[] args)
    {
        var customers = CustomerDataReader.GetCustomers();
        foreach(var c in customers)
        {
            Console.WriteLine($"[{c.Id}]: {c.Name}");
        }
        while (true)
        {
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Enter Cutomer ID: ");
            int customerId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Item Quantity: ");
            int quantity = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter Cutomer ID: ");
            double unitPrice = double.Parse(Console.ReadLine()!);

            var customer = customers.First(c => c.Id == customerId);

            InvoiceManager invoiceManager = new InvoiceManager();
            ICustomerDiscoutnStrategy customerDiscoutnStrategy = new NewCustomerDiscoutnStrategy();
            if (customer.Category == CustomerCategory.Gold)
                customerDiscoutnStrategy = new GoldCustomerDiscoutnStrategy();
            else if (customer.Category == CustomerCategory.Silver)
                customerDiscoutnStrategy = new SilverCustomerDiscoutnStrategy();

            invoiceManager.SetDiscountStrategy(customerDiscoutnStrategy);

            var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);


            Console.WriteLine($"Invoice created for customer: {customer.Name}, with net price {invoice.NetPrice}");

            Console.WriteLine("\nPress any key to create another invoice :)");
            Console.ReadKey();
        }

    }
}
