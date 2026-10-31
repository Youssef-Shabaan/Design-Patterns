namespace AddaptorPattern.Core;

public static class EmployeeDataReader
{
    public static IEnumerable<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                FirstName = "Youssef",
                LastName= "Shaaban",
                PayItems = new List<PayItem>
                {
                    new PayItem {Name = "Basic Salary", Value = 1000},
                    new PayItem {Name = "Transportation", Value = 250},
                    new PayItem {Name = "Medical Insurance", Value = 150, IsDeduction = true},
                }
            },
            new Employee
            {
                FirstName = "Ahmed",
                LastName= "Mohmed",
                PayItems = new List<PayItem>
                {
                    new PayItem {Name = "Basic Salary", Value = 1000},
                    new PayItem {Name = "Transportation", Value = 250},
                    new PayItem {Name = "Medical Insurance", Value = -150},
                }
            }
        };
    }
}
