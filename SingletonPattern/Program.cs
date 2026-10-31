using SingletonPattern;

while (true)
{
    Console.WriteLine("Enter base currecny");
    string? baseCurrency = Console.ReadLine();

    Console.WriteLine("Enter target currecny");
    string? targetCurrency = Console.ReadLine();

    Console.WriteLine("Enter the amoutn");
    Decimal.TryParse(Console.ReadLine()!, out decimal amoutn);

    var currencyConverter = CurrencyConverterSingleton.Instance;

    currencyConverter.Convert(baseCurrency!, targetCurrency!, amoutn);

    Console.ReadKey();
}