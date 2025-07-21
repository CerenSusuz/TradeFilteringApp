using System;
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
            new() { Type = "Future", Amount = 35 },
            new() { Type = "Option", SubType = "NyOption", Amount = 60 },
            new() { Type = "Option", SubType = "NyOption", Amount = 40 },
            new() { Type = "Option", SubType = "NewOption", Amount = 100 },
            new() { Type = "Option", SubType = "NewOption", Amount = 130 },
            new() { Type = "Future", Amount = 80 },
            new() { Type = "Future", Amount = 150 },
        };

        var tradeFilter = new TradeFilter();

        TestFilter(trades, tradeFilter, Bank.Bofa);
        TestFilter(trades, tradeFilter, Bank.Connacord);
        TestFilter(trades, tradeFilter, Bank.Deutsche);
        TestFilter(trades, tradeFilter, Bank.Barclays);
        TestFilterByCountry(trades, tradeFilter, Bank.Barclays, Country.USA);
        TestFilterByCountry(trades, tradeFilter, Bank.Barclays, Country.England);
    }

    static void TestFilter(List<Trade> trades, TradeFilter tradeFilter, Bank bank)
    {
        Console.WriteLine($"\n--- Filtered Trades for {bank} ---");

        try
        {
            var filtered = tradeFilter.FilterForBank(trades, bank);

            foreach (var trade in filtered)
            {
                Console.WriteLine($"Type: {trade.Type}, SubType: {trade.SubType}, Amount: {trade.Amount}");
            }
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void TestFilterByCountry(List<Trade> trades, TradeFilter tradeFilter, Bank bank, Country country)
    {
        Console.WriteLine($"\n--- Filtered Trades for {bank} in {country} ---");

        try
        {
            var filtered = tradeFilter.FilterForBank(trades, bank, country);

            foreach (var trade in filtered)
            {
                Console.WriteLine($"Type: {trade.Type}, SubType: {trade.SubType}, Amount: {trade.Amount}");
            }
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
