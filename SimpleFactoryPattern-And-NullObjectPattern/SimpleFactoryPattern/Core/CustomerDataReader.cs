namespace SimpleFactoryPattern.Core;

public static class CustomerDataReader
{
    public static List<Customer> GetCustomers()
    {
        return new List<Customer>()
        {
            new Customer
            {
                Id = 1,
                Name = "Youssef Shaaban Ahmed",
                Category = CustomerCategory.Gold
            },
            new Customer
            {
                Id = 2,
                Name = "Ibrahim Khalid Elnaggar",
                Category = CustomerCategory.Silver
            },
            new Customer
            {
                Id = 3,
                Name = "Ahmed Mohamed Ahmed",
                Category = CustomerCategory.New
            }
        };
    }
}
