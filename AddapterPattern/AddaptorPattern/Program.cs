using AddaptorPattern.Core;
using System.Text.Json;
using System.Text;
using AddaptorPattern.Addapters;
namespace AddaptorPattern;

internal class Program
{
    static async Task Main(string[] args)
    {
        string payrollCalculatorUrl = "https://localhost:7272/api/PayrollCalculator";

        var employees = EmployeeDataReader.GetEmployees();

        var client = new HttpClient();
        foreach(var employee in employees)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorUrl);

            var employeeAddapter = new PayrollSystemEmployeeAddapter(employee);

            request.Content = new StringContent(JsonSerializer.Serialize(employeeAddapter), Encoding.UTF8, "application/json");

            var response = await client.SendAsync(request);
            var responseJson = await response.Content.ReadAsStringAsync();
            var salary = decimal.Parse(responseJson);

            Console.WriteLine($"Salary for employee: {employeeAddapter.FullName}, as of today = {salary}");
        }
    }
}
