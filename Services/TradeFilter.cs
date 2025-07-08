using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeFilteringApp.Enums;
using TradeFilteringApp.Filters;
using TradeFilteringApp.Models;

namespace TradeFilteringApp.Services
{
    public class TradeFilter
    {
        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank)
        {
            var filter = FilterFactory.CreateFilter(bank);

            return filter.Match(trades);
        }
    }
}
