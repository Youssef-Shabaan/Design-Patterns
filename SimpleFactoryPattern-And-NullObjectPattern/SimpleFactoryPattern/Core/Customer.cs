namespace SimpleFactoryPattern.Core;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public CustomerCategory Category { get; set; }
}