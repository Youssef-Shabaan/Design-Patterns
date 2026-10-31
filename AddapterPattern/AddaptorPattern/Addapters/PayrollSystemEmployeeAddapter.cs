using AddaptorPattern.Core;

namespace AddaptorPattern.Addapters;

public class PayrollSystemEmployeeAddapter
{
    private readonly Employee employee;
    private readonly IEnumerable<PayrollSystemPayItemAddapter> _payItems;
    public PayrollSystemEmployeeAddapter(Employee employee)
    {
        this.employee = employee;
        _payItems = employee.PayItems.Select(x => new PayrollSystemPayItemAddapter(x)).ToList();
    }

    public string FullName => $"{employee.FirstName} {employee.LastName}";

    public IEnumerable<PayrollSystemPayItemAddapter> PayItems => _payItems;
}
