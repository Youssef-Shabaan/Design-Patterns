namespace StrategyTask.Core;

public class Order
{
    public decimal TotalPrice { get; set; }
    public decimal TotalWeight { get; set; }
    public bool IsPremiumCustomer { get; set; }
    public string ShippingAddress { get; set; } = string.Empty;
    public ShippingType ShippingType { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
}

public enum ShippingType
{
    Standard,
    Express,
    SameDay,
    International
}

public enum PaymentMethod
{
    CashOnDelivery,
    CreditCard,
    Wallet
}
