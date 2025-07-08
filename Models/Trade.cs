using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeFilteringApp.Models
{
    public class Trade
    {
        public string Type { get; set; }
        public string SubType { get; set; }
        public double Amount { get; set; }
    }
}
