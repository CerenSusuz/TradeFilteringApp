using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
