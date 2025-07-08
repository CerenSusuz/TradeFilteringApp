using System;
using TradeFilteringApp.Enums;

namespace TradeFilteringApp.Filters
{
    public static class FilterFactory
    {
        public static IFilter CreateFilter(Bank bank)
        {
            return bank switch
            {
                Bank.Bofa => new BofaFilter(),
                Bank.Connacord => new ConnacordFilter(),
                Bank.Barclays => new BarclaysFilter(),
                Bank.Deutsche => new DeutscheFilter(),
                _ => throw new NotImplementedException("Unsupported bank")
            };
        }

        public static IFilter CreateFilter(Bank bank, Country country)
        {
            if (bank == Bank.Barclays)
            {
                return country switch
                {
                    Country.USA => new BarclaysUSAFilter(),
                    Country.England => new BarclaysEnglandFilter(),
                    _ => new BarclaysFilter()
                };
            }

            return CreateFilter(bank);
        }
    }
}
