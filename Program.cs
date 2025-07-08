using System.Collections.Generic;
using TradeFilteringApp.Enums;
using TradeFilteringApp.Models;
using TradeFilteringApp.Services;

class Program
{
    static void Main()
    {
        var trades = new List<Trade>
        {
            new() { Type = "Future", Amount = 20 },
            new() { Type = "Option", SubType = "NyOption", Amount = 60 },
            new() { Type = "Option", SubType = "NyOption", Amount = 40 },
            new() { Type = "Future", Amount = 80 },
        };

        var tradeFilter = new TradeFilter();

        var filteredTrades = tradeFilter.FilterForBank(trades, Bank.Barclays);

        Console.WriteLine("Filtered Trades:");

        foreach (var trade in filteredTrades)
        {
            Console.WriteLine($"Type: {trade.Type}, SubType: {trade.SubType}, Amount: {trade.Amount}");
        }
    }
}
