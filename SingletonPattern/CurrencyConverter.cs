namespace SingletonPattern;

internal class CurrencyConverter
{
    private List<ExchangeRate>? _exchangeRates;
    public CurrencyConverter()
    {
        LoadCurrencies();
    }

    private void LoadCurrencies()
    {
        Thread.Sleep(3000);

        _exchangeRates = new List<ExchangeRate>()
        {
            new ExchangeRate("USD", "SAR", 3.75m),
            new ExchangeRate("USD", "EGP", 30.60m),
            new ExchangeRate("SAR", "EGP", 8.16m)
        };
    }

    public void Convert(string baseCurrency, string targetCurrency, decimal amount)
    {
        var target = _exchangeRates?
            .FirstOrDefault(x => x.BaseCurrency == baseCurrency && x.TargetCurrency == targetCurrency);

        if(target is null)
            Console.WriteLine("Convert Not Supported");

        Console.WriteLine($"{amount} {baseCurrency} = {amount * target!.Rate} {targetCurrency}");
    }

}
