using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeFilteringApp.Models;

namespace TradeFilteringApp.Filters
{
    public class BofaFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t => t.Amount <= 70);
        }
    }
}
