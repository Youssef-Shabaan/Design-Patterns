namespace PayrollSystem.Core;

public class Employee
{
    public string FullName { get; set; } = string.Empty;
    public IEnumerable<PayItem> PayItems { get; set; } = [];
}
