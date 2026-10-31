namespace SingletonPattern;

internal class CurrencyConverterSingleton
{
    private List<ExchangeRate>? _exchangeRates;
    private CurrencyConverterSingleton()
    {
        LoadExchangeRates();
    }

    private static CurrencyConverterSingleton? _instance;

    private static object _instanceLock = new object();
    public static CurrencyConverterSingleton Instance
    {
        get
        {
            if( _instance is null )
            {
                lock( _instanceLock )
                {
                    if ( _instance is null )
                        _instance = new CurrencyConverterSingleton();
                }
            }

            return _instance;
        }
    }

    private void LoadExchangeRates()
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
