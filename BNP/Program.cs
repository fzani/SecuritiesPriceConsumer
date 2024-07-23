// See https://aka.ms/new-console-template for more information
using BNP.contract;
using BNP.external;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Hello, BNP World! My name is Zani :)  \n\n");

        using (var externalPriceService = new ExternalStockPrice<ISIN>())
        {
            var response = externalPriceService.ExternalService.GetCurrentPrice<ISIN>();

            // Processar a resposta conforme necessário
        }
    }
}

