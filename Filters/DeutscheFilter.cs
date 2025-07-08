using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeFilteringApp.Models;

namespace TradeFilteringApp.Filters
{
    public class DeutscheFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(t =>
                t.Type == "Option" &&
                t.SubType == "NewOption" &&
                t.Amount > 90 &&
                t.Amount < 120);
        }
    }
}
